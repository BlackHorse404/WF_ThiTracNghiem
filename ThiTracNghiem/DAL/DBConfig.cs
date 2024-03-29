﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ThiTracNghiem.DAL
{
    class DBConfig
    {
        private static string serverName = "localhost";
        private static string dBname = "QLTracNghiem";
        private static string user = "sa";
        private static string pass = "sa";
        public static string Username { set { user = value; } get { return user; } }
        public static string Password { set { user = value; } get { return pass; } }
        public static string ServerName { get => serverName;}
        public static string DBname { get => dBname; }

        public static SqlConnection getConnectString()
        {
            string strConn = "Data Source=" + ServerName + ";Initial Catalog=" + DBname + ";Integrated Security=True";
            return new SqlConnection(strConn);
        }
    }
}
