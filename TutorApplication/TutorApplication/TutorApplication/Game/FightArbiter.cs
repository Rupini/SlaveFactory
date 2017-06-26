using TutorApplication.Task2API;

namespace TutorApplication
{
    public class FightArbiter : IFightArbiter
    {
        public IArbiterDecision Judje(IFightState state)
        {
            state.Print();
            return new ArbiterDecision(state);
        }
    }
}