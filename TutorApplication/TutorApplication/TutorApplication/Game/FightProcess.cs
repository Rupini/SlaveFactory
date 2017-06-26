using System;
using TutorApplication.Task2API;

namespace TutorApplication
{
    public class FightProcess : IFightProcess
    {
        private IFighter _first;
        private IFighter _second;
        private IFightState _currentState;
        private readonly IFightArbiter _arbiter;
        private readonly IFightRule _rule;

        public FightProcess(IFightArbiter arbiter, IFightRule rule)
        {
            _arbiter = arbiter;
            _rule = rule;
            _currentState = State.FightProcess;
        }

        public IFightState GetLastFightState()
        {
            return _currentState;
        }

        public void SetFirstFighter(IFighter fighter)
        {
            _first = fighter;
        }

        public void SetSecondFighter(IFighter fighter)
        {
            _second = fighter;
        }

        public void Execute()
        {
            while (_currentState.Equals(State.FightProcess))
            {
                if (IsAllAlive())
                {
                    Console.WriteLine(_arbiter.Judje(_currentState));
                    SimulateFight();
                }
                else
                {
                    _currentState = new State(_first.IsAlive ? _first : _second);
                    Console.WriteLine(_arbiter.Judje(_currentState));
                }
            }
        }

        private void SimulateFight()
        {
            var result = _rule.TryApplyFightTurn(_first, _second);
            if (!result)
            {
                Console.WriteLine($"Rule [{_rule}] can't be applied on current turn.");
            }
            CheckDeadAndApplyDamage();
        }

        private void CheckDeadAndApplyDamage()
        {
            if (IsAllAlive())
            {
                ApplyDamage(_first, _second);
            }
            if (IsAllAlive())
            {
                ApplyDamage(_second, _first);
            }
        }

        private void ApplyDamage(IFighter first, IFighter second)
        {
            var provider = first as IDamageProvider;
            if (provider != null)
            {
                (second as IDamageTarget)?.Apply(provider.Provide());
            }
        }

        private bool IsAllAlive()
        {
            return _first.IsAlive && _second.IsAlive;
        }
    }
}