using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bstLesson06.Models;

namespace bstLesson06.Controllers
{
    public class bstSongController : Controller
    {
        private static List<bstSong> bstSongs = new List<bstSong>()
        {
            new bstSong {Id=00020,bstTitle="bui son tung",bstAuthor="K22CNT3",bstArtist="NTU",bstYearRelease=2020 },
            new bstSong {Id=1,bstTitle=bui son tung ",bstAuthor="K22CNT3",bstArtist="NTU",bstYearRelease=2020 }
        };
        
        // GET: bstSong
        /// <summary>
        /// Hien Thi danh sach bai hat
        /// Author: Le Tran Khanh Duy
        /// </summary>
        /// <returns></returns>
        public ActionResult bstIndex()
        {
            return View();
        }
    }
}