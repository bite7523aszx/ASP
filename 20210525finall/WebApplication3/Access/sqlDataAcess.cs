using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Access;

namespace WebApplication3.Access
{
    public  class sqlDataAcess:IsqlDataAcess
    {
        public  string connectionStr { get; set; }
        public  string connectionStr1 { get; set; }
        public IConfiguration _configuration { get; }

        public  sqlDataAcess(IConfiguration configuration)
        {
            _configuration = configuration;

            string path = Directory.GetCurrentDirectory(); // 在這個資料裡下
            connectionStr = _configuration.GetConnectionString("GameVIewContext")
                                .Replace("[DataDirectory]", path);
            connectionStr1 = _configuration.GetConnectionString("UserContextConnection")
                                .Replace("[DataDirectory]", path);
        }



        //public static string GetConnectionString()
        //{
        //    //string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\Desktop\\0422Enter Systeam\\0421lee\\0422\\0421lee\\0420-1\\0416\\WebApplication3\\APP_Data\\GameDb456.mdf;Integrated Security=True";
        //    string ConnectionString1 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\Desktop\\0423Benson\\WebApplication3\\APP_Data\\GameDb456.mdf;Integrated Security=True";
        //    return ConnectionString1;


        //}
        public  List<T> LoadData<T>(string sql)
        {
          
            using (IDbConnection cnn = new SqlConnection(connectionStr))
            {
                return cnn.Query<T>(sql).ToList();
            }

        }
        public  int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(connectionStr))
            {
                return cnn.Execute(sql, data);
            }
         
        }
        public List<T> LoadData1<T>(string sql)
        {

            using (IDbConnection cnn = new SqlConnection(connectionStr1))
            {
                return cnn.Query<T>(sql).ToList();
            }

        }
        public int SaveData1<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(connectionStr1))
            {
                return cnn.Execute(sql, data);
            }

        }
    }
}
