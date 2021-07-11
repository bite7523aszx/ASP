using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.Models.Data;
using WebApplication3.ViewModel;

namespace WebApplication3.Access
{
    public class Game_StoryViewComment : IGame_StoryViewComment
    {
        private readonly GameDbContext _context;

        public Game_StoryViewComment(GameDbContext context)
        {
            _context = context;
        }

        public List<Game_mallCommentViewModel> Details(int? id)
        {
            List<Game_mallCommentViewModel> game_mallCommentViewModelList= new List<Game_mallCommentViewModel>();

            Game_mall game_mall = _context.Game_mall.Find(id);
            Game_mallCommentViewModel game_mallCommentViewModel = new Game_mallCommentViewModel();

            game_mallCommentViewModel.Comment_Game_number = id.Value;
            game_mallCommentViewModel.Game_name = game_mall.Game_name;
            var Comments = _context.Game_mallComments.Where(d => d.Comment_Game_number.Equals(id.Value)).ToList();
            game_mallCommentViewModel.ListOfComments = Comments;

            


            game_mallCommentViewModelList.Add(game_mallCommentViewModel);
            return game_mallCommentViewModelList;

        }
    }
}
