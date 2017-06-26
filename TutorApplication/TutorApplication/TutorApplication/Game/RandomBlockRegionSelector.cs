using TutorApplication.Task2API;

namespace TutorApplication
{
    public class RandomBlockRegionSelector : RandomSelector, IBlockRegionSelector
    {
        public RandomBlockRegionSelector(int seed) : base(seed)
        {
        }

        public BodyRegion Select()
        {
            return SelectRegion();
        }
    }
}