using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    interface ITeacher
    {
        //void SetPost(TPost Post);
        string TAction();
    }

    interface IStudent
    {
        string SAction();
    }
    interface IJobHunter
    {
        string JAction1(string FIO, School.SchoolWorkers.Jobs name);
        string JAction2(string FIO, int value);
    }
}
