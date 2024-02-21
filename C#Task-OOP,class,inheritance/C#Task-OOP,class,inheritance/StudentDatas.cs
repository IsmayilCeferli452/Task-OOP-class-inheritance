using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task_OOP_class_inheritance
{
    class StudentDatas
    {
        public string name = "Data not found";
        public string surname = "Data not found";
        public int age;
        public string address = "Data not found";
        public string phonenumber = "Data not found";


        public string FullData()
        {
            return "Name:" + name + " " + "Surname:" + surname + " " + "Age:" + age + " " + "Address:" + address;
        }
    }
}
