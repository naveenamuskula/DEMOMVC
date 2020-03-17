using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DEMOMVC.Models
{
    public class DBOperations
    {
        
           static DemoEntities  D = new DemoEntities();
        
        public static string InsertEmp(EMPDATA E)
        {
            try
            {
                D.EMPDATAs.Add(E);
                D.SaveChanges();
            }
            catch(DbUpdateException p)
            {
                SqlException ex = p.GetBaseException() as SqlException;
                if (ex.Message.Contains("FK_EMPDATA"))
                {
                    return "No proper deptno";
                }
                else if (ex.Message.Contains("EMP_PK"))
                {
                    return " no duplicate Empno ";
                }
                else
                    return "error occured";
            }
            
            return "1 row inserted";
        }
        public static List<EMPDATA> GetDept(int Deptno)
        {
            var LE = from L in D.EMPDATAs
                     where L.DEPTNO == Deptno
                     select L;
            return LE.ToList();
        }
        public static List<DEPTDATA> GetDetails()
        {
            var Dept= from D1 in D.DEPTDATAs 
                     select D1;
            return Dept.ToList();//for multiple records we use Tolist
        }
        public static List<EMPDATA> Emp()
        {
            var LE = from L in D.EMPDATAs                   
                     select L;
            return LE.ToList();
        }
        public static string DelEmp(int empno)
        {
            var Z = from L in D.EMPDATAs
                     where L.EMPNO == empno
                     select L;
            D.EMPDATAs.Remove(Z.First());
            D.SaveChanges();
            return "1 Row Deleted";
        }
        public static EMPDATA  extractemp(int empno)
        {
            var LE = from L in D.EMPDATAs
                     where L.EMPNO == empno
                     select L;
            return LE.FirstOrDefault();
        }
        public static string updatedata(int empno, EMPDATA emp)
        {
            var le = from l in D.EMPDATAs
                     where l.EMPNO == empno
                     select l;
            

            foreach (var item in le)
            {
                item.JOB = emp.JOB;
                item.MGR = emp.MGR;
                item.SAL = emp.SAL;
                item.COMM = emp.COMM;
                item.DEPTNO = emp.DEPTNO;
            }
            D.SaveChanges();
            return "1 row updated";
        }
        public static List<EMPDATA> Empdate(DateTime sd,DateTime ed)
        {
            var LE = from l in D.EMPDATAs
                     where l.HIREDATE > sd && l.HIREDATE < ed
                     select l;
            return LE.ToList();
        }
        public static EMPDATA Display(int empno)//or use extractemp method
        {
             EMPDATA E = (from L in D.EMPDATAs
                     where L.EMPNO == empno
                     select L).FirstOrDefault();
            return E;
        }


    }
}