﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CoilGun_PC.SQL
{
    static class SQL_commands
    {
        public static bool Initialized = false;
        private static SqlConnection connection;
        private static string connStr, DB, TB;
        

        public static void Initialize(string _server, string _db, string _tb)
        {
            connStr = string.Format(@"Server={0};Initial Catalog=master;Integrated Security=True;", _server);
            DB = _db;
            TB = _tb;
            Initialized = true;
        }

        //Connect to db and return list of collumns names and data types//
        public static List<object[]> ConnectTB()
        {
            //List of column names and data type//
            string SQL = String.Format("USE [{1}] SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS" +
                " WHERE TABLE_NAME = '{0}'", TB, DB);

            SqlCommand cmd= CreateCommand(SQL);
            SqlDataReader sdr = cmd.ExecuteReader();

            List <object[]> data = new List<object[]>();

            while (sdr.Read())
            {
                string[] row = new string[sdr.FieldCount];
                sdr.GetValues(row);

                data.Add(row);
            }
            sdr.Close();
            connection.Close();

            return data;
        }

        public static List<object[]> GetDataFromTB()
        {
            string SQL = String.Format("USE [{1}] SELECT * FROM [{0}]", TB, DB);

            SqlCommand cmd = CreateCommand(SQL);
            SqlDataReader sdr = cmd.ExecuteReader();

            List<object[]> data = new List<object[]>();

            while (sdr.Read())
            {
                object[] row = new object[sdr.FieldCount];
                sdr.GetValues(row);

                data.Add(row);
            }
            sdr.Close();
            connection.Close();

            return data;
        }
         //bez id
        public static void AddData(Object [] data)
        {
            string SQL = string.Format("INSERT INTO [{0}].[dbo].[{1}] " +
        " VALUES( ", DB, TB);

            for (int i = 0; i < data.Length ; i++)
            {
                if (data[i].GetType() == typeof(String)) SQL += "'" + data[i] + "'";
                else SQL += data[i];

                if (i!=data.Length-1) SQL += " , "; 
            }
            SQL += " )";

            RunQuery(SQL);
        }

        public static SqlCommand CreateCommand(string query)
        {
            connection = new SqlConnection(connStr);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);

            return cmd;
        }

        public static void RunQuery(string query)
        {
            SqlCommand cmd = CreateCommand(query);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}

/*public void ConnectDB(string name)
        {
            string SQL = String.Format("IF(NOT EXISTS(SELECT name FROM dbo.sysdatabases " +
                "WHERE('[' + name + ']' = '{0}' OR name = '{0}'))) " +
                " CREATE DATABASE [{0}] ", name);
            RunQuery(SQL);
        }*/

/*public void CreateTB(string tb_name, string db_name,List<string> col_names) //col_names=[Name][nchar](50) NULL
    {
        string SQL = String.Format("USE [{1}] " +
            "SET ANSI_NULLS ON  " +
            "SET QUOTED_IDENTIFIER ON   " +
            "IF OBJECT_ID('dbo.{0}', 'U') IS NULL " +
            "CREATE TABLE [dbo].[{0}]( ", tb_name, db_name);

        foreach (string i in col_names)
        {
            SQL += string.Format("{0},",i);
        }
        SQL+= " CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED ([ID] ASC)" +
            "WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF," +
            " ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]) ON[PRIMARY]";
        RunQuery(SQL);
    }*/
