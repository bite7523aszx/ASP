using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Asscss
{
    public class Game_Story : IGame_Story
    {
        public List<Game_mall> game_mall_StoryList { get; set; }
        public string connectionStr { get; set; }
        public IConfiguration _configuration { get;}


        public Game_Story(IConfiguration configuration)
        {
            _configuration = configuration;

            string path = Directory.GetCurrentDirectory(); // 在這個資料裡下
            connectionStr = _configuration.GetConnectionString("GameVIewContext")
                                .Replace("[DataDirectory]", path);
        }

        public void OnGet()
        {
            game_mall_StoryList = GetGame_Story();
        }

        public List<Game_mall> GetGame_Story()
        {
            List<Game_mall> game_mall_StoryList = new List<Game_mall>();
            using (SqlConnection sqlconn = new SqlConnection(connectionStr))
            {
                string sqlStr = "Select * from Game_mall";
                using (SqlCommand sqlCommand = new SqlCommand(sqlStr, sqlconn))
                {
                    sqlconn.Open();
                    using (SqlDataReader sdr = sqlCommand.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            Game_mall mv = new Game_mall();
                            mv.Game_number = Convert.ToInt32(sdr["Game_number"]);
                            mv.Game_name = sdr["Game_name"].ToString();
                            mv.Game_category = sdr["Game_category"].ToString();
                            mv.Unit_price = Convert.ToInt32(sdr["Unit_price"]);
                            mv.Listing_date = DateTime.Parse(sdr["Listing_date"].ToString());
                            game_mall_StoryList.Add(mv);
                        }
                    }
                }
            }
            return game_mall_StoryList;
        }

        public List<Game_Story_Comment> GetGame_Story2()
        {
            List<Game_Story_Comment> game_Story_CommentList = new List<Game_Story_Comment>();
            using (SqlConnection sqlconn = new SqlConnection(connectionStr))
            {
                string sqlStr = "Select * from Game_mall";
                using (SqlCommand sqlCommand = new SqlCommand(sqlStr, sqlconn))
                {
                    sqlconn.Open();
                    using (SqlDataReader sdr = sqlCommand.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            Game_Story_Comment mv = new Game_Story_Comment();
                            mv.Game_number = Convert.ToInt32(sdr["Game_number"]);
                            mv.Game_name = sdr["Game_name"].ToString();
                            mv.Game_category = sdr["Game_category"].ToString();
                            mv.Unit_price = Convert.ToInt32(sdr["Unit_price"]);
                            mv.Listing_date = DateTime.Parse(sdr["Listing_date"].ToString());
                            game_Story_CommentList.Add(mv);
                        }
                    }
                }
            }
            return game_Story_CommentList;
        }
    }
}
