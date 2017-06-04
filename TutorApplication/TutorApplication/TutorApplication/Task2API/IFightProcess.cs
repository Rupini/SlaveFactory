namespace TutorApplication.Task2API
{
    public interface IFightProcess : ITurnStateGenerator
    {
        void SetFirstFighter(IFighter fighter);
        void SetSecondFighter(IFighter fighter);
        void Execute();
    }
}