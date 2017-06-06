using System;

namespace TutorApplication
{
    public class Task1Part2 : ITask
    {
        private readonly int[] _array;

        public Task1Part2(int[] array)
        {
            _array = array;
        }

        public void Execute()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine(_array[i]);
               
            }
        }
    }


}
