using System;

namespace TutorApplication
{
    public class Task1Part4 : ITask
    {
        private readonly int[] _array;

        public Task1Part4(int[] array)
        {
            _array = array;
        }

        public void Execute()
        {
            int i = 0;
            do
            {
                Console.WriteLine(_array[i]);
                i++;
            }
            while (i < _array.Length);

        }
    }
}
