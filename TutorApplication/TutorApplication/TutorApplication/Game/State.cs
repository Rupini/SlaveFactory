using System;
using TutorApplication.Task2API;

namespace TutorApplication
{
    public class State : IFightState, IEquatable<State>
    {
        private const string Description = "[Fight Info] : ";
        public static readonly State FightProcess = new State($"\n\t{Description} Go and fight, busters!\n");
        private readonly string _description;

        public State(string description)
        {
            _description = description;
        }

        public State(IFighter fighter) : this(GetWinMessage(fighter))
        {
        }

        private static string GetWinMessage(IFighter fighter)
        {
            return $"\n\t[{fighter}] won the fight! Congratulations!";
        }

        public void Print()
        {
            ConcoleWriter.WriteLine(_description, ConsoleColor.Cyan);
        }

        public bool Equals(State other)
        {
            if (ReferenceEquals(null, other)) return false;
            return ReferenceEquals(this, other) || string.Equals(_description, other._description);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((State) obj);
        }

        public override int GetHashCode()
        {
            return _description != null ? _description.GetHashCode() : 0;
        }
    }
}