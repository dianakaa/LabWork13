using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Patient
    {
        public string _fio { get; set; }
        public string _policy { get; set; }
        public DateTime _birthDate { get; set; }

        public Patient(string fio, string policy, DateTime birthDate)
        {
            _fio = fio;
            _policy = policy;
            _birthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{_fio.ToUpper()};{_policy.PadLeft(9, '0')};{_birthDate.ToString("yyyy/MM/dd")}";
        }
    }
}

