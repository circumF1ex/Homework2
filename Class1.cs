using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class School
    {
        //Списки, содержащие экземпляры классов
        public static List<Teacher> teachers = new List<Teacher>();
        public static List<Student> students = new List<Student>();
        public static List<JobHunter> jobhunters = new List<JobHunter>();

        public class Human
        {
            public string FIO { get; set; }
            public int i { get; set; }
            public Human (string FIO) { this.FIO = FIO; }
        }

        public class SchoolWorkers: Human
        {
            public enum Jobs { Senior, Assistant, JobHunter }
            public Jobs jobes;
            public string Post { get; set; }
            public SchoolWorkers(string FIO, Jobs name): base(FIO) { this.jobes = name; }
        }

        //Класс преподаватель: Имеет поля ФИО и субдолжность, может проводить лекции
        public class Teacher: SchoolWorkers, ITeacher
        {
            //public TPost Post;

            public Teacher(string FIO, Jobs jobes) : base(FIO, jobes)
            {
                this.FIO = FIO;
                this.jobes = jobes;
            }

            public string TAction() //Действие
            {
                return $"{FIO}: Лекция проведена";
            }


        }
        //Класс студент: имеет поля ФИО и учебная группа, может подать заявление на отчисление
        public class Student: Human, IStudent 
        {
            public int SGroup;
            public Student(string FIO, int SGroup): base(FIO)
            {
                this.FIO = FIO;
                this.SGroup = SGroup;
            }

            public string SAction()
            {
                return ($"{FIO}, уч.группа №{SGroup} : Заявление на отчисление подано");
            }
        }
        //Класс кадровик: имеет поля ФИО, должность, может нанимать преподавателей и студентов
        public class JobHunter: SchoolWorkers, IJobHunter
        {
            public string message = " ";

            public JobHunter(string FIO, Jobs jobes): base(FIO, jobes)
            {
                this.FIO = FIO;
                this.jobes = jobes;
            }

            public string JAction1(string FIO, Jobs jobes) //метод для создания преподавателей
            {
                switch (jobes)
                {
                    case Jobs.Senior:
                        teachers.Add(new Teacher(FIO, Jobs.Senior));
                        message = $"{FIO}: {jobes}";
                        break;

                    case Jobs.Assistant:
                        teachers.Add(new Teacher(FIO, Jobs.Assistant));
                        message = $"{FIO}: {jobes}";
                        break;
                }
                return message;
            }
            public string JAction2(string FIO, int SGroup) //метод для создания студента
            {
                students.Add(new Student(FIO, SGroup));
                string message = $"Создан студент {FIO}: учебная группа {SGroup}";
                return message;
            }
        }      
    }
}
