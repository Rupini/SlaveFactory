namespace TutorApplication.Task2API
{
    public interface IStatContainer
    {
        IStat GetStat(StatType statType);
    }
}