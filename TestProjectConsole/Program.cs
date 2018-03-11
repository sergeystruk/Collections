using System;
using CollectionUtil;

namespace TestProjectConsole
{
    public class Student
    {
        #region Fields and Properties

        private string Name { get; set; }
        private string Surname { get; set; }
        private byte age;

        public byte Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 0)
                {
                    age = 1;
                }
                else
                {
                    age = value;
                }
            }
        }

        #endregion

        #region Constructions

        public Student() : this(string.Empty, string.Empty, 1)
        {
        }

        public Student(string name, string surname, byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        #endregion

        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q1 = new Queue<int>();
            Console.WriteLine("Queue of ints:");
            q1.Enqueue(5);
            q1.Enqueue(3);
            q1.Enqueue(2);
            q1.Enqueue(1);
            q1.Enqueue(6);
            Console.WriteLine(q1.ToString());
            q1.Dequeue();
            Console.WriteLine("Deleting");
            Console.WriteLine(q1.ToString());
            Console.WriteLine();
            q1.Enqueue(5);
            Console.WriteLine("Now we added element 5 to the end:");
            Console.WriteLine(q1.ToString());
            Console.WriteLine();
            Console.WriteLine();

            Queue<string> q2 = new Queue<string>(5);
            q2.Enqueue("aaa");
            q2.Enqueue("bbb");
            q2.Enqueue("ccc");
            q2.Enqueue("ddd");
            q2.Enqueue("eee");
            q2.Enqueue("fff");
            Console.WriteLine("Queue of strings:");
            Console.WriteLine(q2.ToString());
            Console.WriteLine();
            q2.Dequeue();
            Console.WriteLine("Queue of strings after deleting:");
            Console.WriteLine(q2.ToString());
            try
            {
                Queue<Student> q3 = new Queue<Student>();
                q3.Enqueue(new Student("Alex", "Ivanov", 22));
                q3.Enqueue(new Student("Andrew", "Petrov", 20));
                Console.WriteLine("\n\nQueue of reference user's type:");
                Console.WriteLine(q3.ToString());
            }
            catch (FormatException)
            { Console.WriteLine("Wrong Data!"); }
            Console.WriteLine();
        }
    }
}
