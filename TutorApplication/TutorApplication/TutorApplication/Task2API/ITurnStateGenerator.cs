namespace TutorApplication.Task2API
{
    public interface ITurnStateGenerator
    {
        IFightState GetLastFightState();
    }
}