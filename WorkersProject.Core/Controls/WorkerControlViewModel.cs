using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersProject.Core
{
    public class WorkerControlViewModel
    {
        public string WorkerName { get; set; }
        public string WorkerSurname { get; set; }
        public string WorkerProfession { get; set; }
        public int WorkerAge { get; set; }

        public WorkerControlViewModel(string name, string surname, string profession, int age)
        {
            WorkerName = name;
            WorkerSurname = surname;
            WorkerProfession = profession;
            WorkerAge = age;
        }
    }
}
