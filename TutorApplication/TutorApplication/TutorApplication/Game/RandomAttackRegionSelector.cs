using TutorApplication.Task2API;

namespace TutorApplication
{
    public class RandomAttackRegionSelector : RandomSelector, IAttackRegionSelector
    {
        public RandomAttackRegionSelector(int seed) : base(seed)
        {
        }

        public BodyRegion Select()
        {
            return SelectRegion();
        }
    }
}