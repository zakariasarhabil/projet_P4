using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnvironnementNewsApi.Models
{
    public class FooterArticleModel
    {
        public List<ArticleViewModel> listes { get; set; }
        public string Img { get; set; }
    }
}