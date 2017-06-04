namespace TutorApplication.Task2API
{
    public interface IFightRule: ITurnStateGenerator
    {
        bool TryApplyFightTurn(IFighter fighter1, IFighter fighter2);
    }
}