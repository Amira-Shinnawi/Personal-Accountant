using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Personal_Accountant.Logic.Services
{
    public static class EmployeeServices
    {
        public static bool EmployeeInsert(string empName, string gender, double salary, string phone_Num)
        {
            return DBHelper.excuteData("EmployeeInsert", () => EmployeeParameterInsert(empName, gender, salary, phone_Num,DBHelper.command));


        }

        public static void EmployeeParameterInsert(string empName, string gender, double salary, string phone_Num, SqlCommand command)
        {

            command.Parameters.AddWithValue("@empName", SqlDbType.VarChar).Value = empName;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@salary", SqlDbType.Real).Value = salary;
            command.Parameters.Add("@phon_Num", SqlDbType.VarChar).Value = phone_Num;

        }

        //udate
        public static bool EmployeeUpdate(string empName, string gender, double salary, string phone_Num)
        {
            return DBHelper.excuteData("EmployeeUpdate", () => EmployeeParameterUpdate(empName, gender, salary, phone_Num, DBHelper.command));
        }

        public static void EmployeeParameterUpdate(string empName, string gender, double salary, string phone_Num, SqlCommand command)
        {
            command.Parameters.Add("@empName", SqlDbType.VarChar).Value = empName;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@salary", SqlDbType.Real).Value = salary;
            command.Parameters.Add("@phon_Num", SqlDbType.VarChar).Value = phone_Num;


        }

        //delete
        public static bool EmployeeDelete(string empName)
        {
            return DBHelper.excuteData("EmployeeDelete", () => EmployeeParameterDelete(empName, DBHelper.command));
        }

        public static void EmployeeParameterDelete(string empName, SqlCommand command)
        {
            command.Parameters.Add("@empName", SqlDbType.VarChar).Value = empName;
        }

        //Reset
        public static bool EmployeeReset()
        {
            return DBHelper.excuteData("EmployeeReset", () => EmployeeParameterReset(DBHelper.command));

        }

        public static void EmployeeParameterReset(SqlCommand command)
        {
        }
        //select

        static public DataTable EmployeeSelect()
        {
            return DBHelper.getData("EmployeeGetAll", () => { });
        }
    }
}
