namespace TutorApplication.Task2API
{
    public interface IFightArbiter
    {
        IArbiterDecision Judje(IFightState state);
    }
}