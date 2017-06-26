using TutorApplication.Task2API;

namespace TutorApplication
{
    public class ArbiterDecision : IArbiterDecision
    {
        private const string Description = "[Arbiter] : ";
        private readonly string _description;

        public ArbiterDecision(IFightState state)
        {
            _description = GetDescription(state);
        }

        private string GetDescription(IFightState state)
        {
            return state.Equals(State.FightProcess) ? 
                $"\t{Description} F**k up and show me who's the daddy!\n" : 
                $"\n\t{Description} That was interesting. Take away the corpse!";
        }

        public override string ToString()
        {
            return _description;
        }
    }
}