using System;

namespace TutorApplication
{
    public class Task1Part3 : ITask
    {
        private readonly int[] _array;

        public Task1Part3(int[] array)
        {
            _array = array;
        }

        public void Execute()
        {
            int i = 0;
            while (i < _array.Length)
            {

                Console.WriteLine(_array[i]);
                i++;
            }
        }
    }


}
