using System;

namespace TutorApplication
{
    class Launcher
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Почем халва на колыме?");
            var array = new ArrayGenerator().Generate();
            var task = new Task1Part1(array);
            var task2 = new Task1Part2(array);
            var task3 = new Task1Part3(array);
            var task4 = new Task1Part3(array);

            task.Execute();
            task2.Execute();
            task3.Execute();
            task4.Execute();
            Console.ReadLine();
        }
    }
}
