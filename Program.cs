using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2委托List排序
{
    class Program
    {
        class Student
        {
            public string name;
            public int score;
            public Student(string name,int score)
            {
                this.name = name;
                this.score = score;
            }
            public override string ToString()
            {return string.Format($"学生{name},分数{score}");}
        }
        static void PrintList<T>(List<T> list)
        {
            foreach(T n in list)
            {Console.WriteLine(n + "  ");}
            Console.WriteLine("======");
        }
        static int CompareStudents(Student a, Student b)
        {
            //if(a.score > b.score)
            //{return 1;}
            //if(a.score < b.score)
            //{return -1;}
            //return 0;
            return a.score.CompareTo(b.score);
            //return a.name.CompareTo(b.name);
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 23, 56, 73, 60 };
            list.Add(4);
            list.Add(50);
            list.Add(0);
            list.Add(39);
            list.Sort();
            PrintList(list);
            Student s1 = new Student("小张", 34);
            Student s2 = new Student("小智", 45);
            Student s3 = new Student("小陈", 90);
            Student s4 = new Student("小李", 90);
            List<Student> students = new List<Student> { s1,s2,s3,s4};
            students.Sort(CompareStudents);
            PrintList(students);
            Console.ReadKey();
        }
    }
}
