using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.ViewModel;

namespace WebApplication3.Access
{
    public interface IGame_StoryViewComment
    {
        public List<Game_mallCommentViewModel> Details(int? id);
    }
}
