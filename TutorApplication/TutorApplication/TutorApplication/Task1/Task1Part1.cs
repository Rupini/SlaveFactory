using System;

namespace TutorApplication
{
    public class Task1Part1 : ITask
    {
        private readonly int[] _array;

        public Task1Part1(int[] array)
        {
            _array = array;
        }

        public void Execute()
        {
            foreach (int i in _array)
                Console.WriteLine(i);
            
        }
    }


}
