using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Personal_Accountant.Logic.Services
{
    public static class ExpensesServices
    {
        public static bool ExpensesInsert(string item, int quantity, int price,DateTime date )
        {
            return DBHelper.excuteData("ExpensesInsert", () => ExpensesParameterInsert(item, quantity, price,date, DBHelper.command));


        }

        public static void ExpensesParameterInsert( string item, int quantity, int price,DateTime date, SqlCommand command)
        {
            
            command.Parameters.Add("@item", SqlDbType.NVarChar).Value = item;
            command.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@AddedDate", SqlDbType.Date).Value = date;

        }

        //udate
        public static bool ExpensesUpdate(string item, int quantity, int price,DateTime date)
        {
            return DBHelper.excuteData("ExpensesUpdate", () => ExpensesParameterUpdate(item, quantity, price,date, DBHelper.command));
        }

        public static void ExpensesParameterUpdate(string item, int quantity, int price,DateTime date, SqlCommand command)
        {
            command.Parameters.Add("@item", SqlDbType.NVarChar).Value = item;
            command.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@AddedDate", SqlDbType.Date).Value = date;


        }

        //delete
        public static bool ExpensesDelete(string item)
        {
            return DBHelper.excuteData("ExpensesDelete", () => ExpensesParameterDelete(item, DBHelper.command));
        }

        public static void ExpensesParameterDelete(string item, SqlCommand command)
        {
            command.Parameters.Add("@item", SqlDbType.NVarChar).Value = item;
        }

        //Reset
        public static bool ExpensesReset()
        {
            return DBHelper.excuteData("ExpensesReset", () => ExpensesParameterReset(DBHelper.command));

        }

        public static void ExpensesParameterReset(SqlCommand command)
        {
        }
        //select

        static public DataTable ExpensesSelect()
        {
            return DBHelper.getData("EepensesGetAll", () => { });
        }
    }
}
