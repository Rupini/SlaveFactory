using TutorApplication.Task2API;

namespace TutorApplication
{
    public class Stat : IStat
    {
        private const int DefaultStatValue = 0;
        public int Value { get; set; }

        public Stat() : this(DefaultStatValue)
        {
        }

        public Stat(int value)
        {
            Value = value;
        }
    }
}