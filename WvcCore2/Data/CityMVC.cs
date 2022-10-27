using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WvcCore2.Models;

namespace WvcCore2.Data
{
    internal class CityMVC : CityMVCBase
    {
        //private string connectionstring = "data source = (localdb)\\mssqllocaldb;initial catalog = master; integrated security = true; connect timeout = 30; encrypt=false;trustservercertificate=false;applicationintent=readwrite;multisubnetfailover=false;";
        //public list<province> fetchall()
        //{
        //    list<province> retrunlist = new list<province>();
        //    using (sqlconnection connection = new sqlconnection(connectionstring))
        //    {
        //        string sqlquery = "select * from province";
        //        sqlcommand command = new sqlcommand(sqlquery, connection);

        //        connection.open();
        //        sqldatareader reader = command.executereader();

        //        if (reader.hasrows)
        //        {
        //            while (reader.read())
        //            {
        //                province province = new province();
        //                province.id = reader.getint32(0);
        //                province.name = reader.getstring(1);

        //                retrunlist.add(province);
        //            }
        //        }
        //        retrun retrunlist;
        //    }

        //}
    }
}