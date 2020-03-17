using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEMOMVC.Models
{
    public class Emp
    {
         int Empno;
         string Ename;
         double Salary;

        public int Empno1 { get => Empno; set => Empno = value; }
        public string Ename1 { get => Ename; set => Ename = value; }
        public double Salary1 { get => Salary; set => Salary = value; }
    }
}