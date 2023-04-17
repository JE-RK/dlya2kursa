using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlya2kursa
{
    public class Employee
    {
        public string surname;
        public string name;
        public string patronymic;
        public string post;
        public string phone_number;
        public Employee(string surname, string name, string patronymic, string post, string phone_number)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.post = post;
            this.phone_number = phone_number;
        }
    }
}
