using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Personal_Accountant.Logic.Services
{
    static public class RevenueServices
    {
        public static bool RevenueInsert(string item, int quantity, int price, DateTime date)
        {
            return DBHelper.excuteData("RevenueInsert", () => RevenueParameterInsert(item, quantity, price, date, DBHelper.command));


        }

        public static void RevenueParameterInsert(string item, int quantity, int price, DateTime date, SqlCommand command)
        {

            command.Parameters.Add("@item", SqlDbType.NVarChar).Value = item;
            command.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@AddedDate", SqlDbType.Date).Value = date;

        }

        //udate
        public static bool RevenueUpdate(string item, int quantity, int price, DateTime date)
        {
            return DBHelper.excuteData("RevenueUpdate", () => RevenueParameterUpdate(item, quantity, price, date, DBHelper.command));
        }

        public static void RevenueParameterUpdate(string item, int quantity, int price, DateTime date, SqlCommand command)
        {
            command.Parameters.Add("@item", SqlDbType.NVarChar).Value = item;
            command.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@AddedDate", SqlDbType.Date).Value = date;


        }

        //delete
        public static bool RevenueDelete(string item)
        {
            return DBHelper.excuteData("RevenueDelete", () => RevenueParameterDelete(item, DBHelper.command));
        }

        public static void RevenueParameterDelete(string item, SqlCommand command)
        {
            command.Parameters.Add("@item", SqlDbType.NVarChar).Value = item;
        }

        //Reset
        public static bool RevenueReset()
        {
            return DBHelper.excuteData("RevenueReset", () => RevenueParameterReset(DBHelper.command));

        }

        public static void RevenueParameterReset(SqlCommand command)
        {
        }
        //select

        static public DataTable RevenueSelect()
        {
            return DBHelper.getData("RevenueGetAll", () => { });
        }
    }
}
