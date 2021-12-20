using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            School.jobhunters.Add(new School.JobHunter("Создан кадровик - Паннакотта Георгий Викторович", JPost.JobHunter));
            Console.WriteLine($"{School.jobhunters[0].FIO}: {School.jobhunters[0].Post}");
            
            School.jobhunters.Add(new School.JobHunter("Создан кадровик - Тирамису Мария Нафановна", JPost.JobHunter));
            Console.WriteLine($"{School.jobhunters[1].FIO}: {School.jobhunters[1].Post}");

            School.jobhunters[0].JAction1("Танненбаум Виктор Юрьевич", TPost.Assistant);
            Console.WriteLine(School.jobhunters[0].message);

            School.jobhunters[1].JAction1("Силенок Юрий Викторович", TPost.Senior);
            Console.WriteLine(School.jobhunters[1].message);

            Console.WriteLine(School.teachers[0].TAction());
            Console.WriteLine(School.teachers[1].TAction());

            School.jobhunters[0].JAction2("Сизов Данил Евгеньевич", 2);
            Console.WriteLine(School.students[0].SAction());

            Console.ReadLine();
        }
    }
}
