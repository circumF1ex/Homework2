using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            School.jobhunters.Add(new School.JobHunter("Паннакотта Георгий Викторович", School.SchoolWorkers.Jobs.JobHunter));
            Console.WriteLine($"{School.jobhunters[0].FIO}: {School.jobhunters[0].jobes}");
            
            School.jobhunters.Add(new School.JobHunter("Тирамису Мария Нафановна", School.SchoolWorkers.Jobs.JobHunter));
            Console.WriteLine($"{School.jobhunters[1].FIO}: {School.jobhunters[1].jobes}");

            School.jobhunters[0].JAction1("Танненбаум Виктор Юрьевич", School.SchoolWorkers.Jobs.Assistant);
            Console.WriteLine(School.jobhunters[0].message);

            School.jobhunters[1].JAction1("Силенок Юрий Викторович", School.SchoolWorkers.Jobs.Senior);
            Console.WriteLine(School.jobhunters[1].message);

            Console.WriteLine(School.teachers[0].TAction());
            Console.WriteLine(School.teachers[1].TAction());

            School.jobhunters[0].JAction2("Сизов Данил Евгеньевич", 2);
            Console.WriteLine(School.students[0].SAction());

            School.jobhunters[1].JAction2("Распутин Владимир Владимирович", 2);
            Console.WriteLine(School.students[1].SAction());
            Console.ReadLine();
        }
    }
}
