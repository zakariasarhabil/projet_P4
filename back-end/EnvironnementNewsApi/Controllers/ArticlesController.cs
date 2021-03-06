﻿using EnvironnementNewsApi.Data;
using EnvironnementNewsApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
namespace EnvironnementNewsApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [RoutePrefix("api/Article")]
    public class ArticlesController : ApiController
    {
        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        [Route("Article")]
        public IHttpActionResult GetArticle()
        {
            //ELA SLAMTEK
            var articles = new List<ViewArticleJournalistModel>();

            //ViewModelJournalist jr = new ViewModelJournalist();

            using (var context = new NEWSEntities())
            {
                //var article = context.Article.ToList();
                var status = "posted";
                var article = context.Article.Where(f => f.Status == status).ToList();
                if (article == null)
                {
                    return NotFound();
                }

                foreach (var n in article)
                {
                    ViewArticleJournalistModel vm = new ViewArticleJournalistModel();
                    vm.Img = n.Img;
                    vm.Titre = n.Titre;
                    vm.Body = n.Body;
                    vm.Date = n.Date;
                    vm.Journaliste = n.Journalistes.Nom;
                    articles.Add(vm);
                }

            }
            return Ok(articles);
        }
        [Route("ToutArticles")]
        public IHttpActionResult GetArticles(string status = "")
        {

            var articles = new List<ViewArticleJournalistModel>();


            //ViewModelJournalist jr = new ViewModelJournalist();

            using (var context = new NEWSEntities())
            {
                //var article = context.Article.ToList();

                var article = context.Article.Where(f => f.Status == status).ToList();
                if (article == null)
                {
                    return NotFound();
                }

                foreach (var n in article)
                {
                    ViewArticleJournalistModel vm = new ViewArticleJournalistModel();
                    vm.Img = n.Img;
                    vm.Titre = n.Titre;
                    vm.Body = n.Body;
                    vm.Date = n.Date;
                    vm.Journaliste = n.Journalistes.Nom;
                    articles.Add(vm);
                }
            }
            return Ok(articles);
        }
        [Route("Articleslide")]
        public IHttpActionResult GetSlideArticle()
        {

            var articles = new List<ViewArticleJournalistModel>();

            //ViewModelJournalist jr = new ViewModelJournalist();

            using (var context = new NEWSEntities())
            {
                //var article = context.Article.ToList();
                var status = "posted";
                var article = context.Article.Where(f => f.Status == status).OrderBy(a => a.Date).Take(4).ToList();
                if (article == null)
                {
                    return NotFound();
                }

                foreach (var n in article)
                {
                    ViewArticleJournalistModel vm = new ViewArticleJournalistModel();
                    vm.Img = n.Img;
                    vm.Titre = n.Titre;
                    vm.Body = n.Body;
                    vm.Date = n.Date;
                    vm.Journaliste = n.Journalistes.Nom;
                    articles.Add(vm);
                }

            }
            return Ok(articles);
        }
        [Route("DetaileArticle")]
        public IHttpActionResult GetArticle(int id)
        {
            ViewArticleJournalistModel article;
            using (var context = new NEWSEntities())
            {
                var A = context.Article.Where(f => f.ID == id).FirstOrDefault();
                if (A == null)
                {
                    return NotFound();
                }
                article = new ViewArticleJournalistModel();
                article.ID = id;
                article.Titre = A.Titre;
                article.Body = A.Body;
                article.Img = A.Img;
                article.Video = A.video;
                article.Date = A.Date;
                article.Journaliste = A.Journalistes.Nom;
            }
            return Ok(article);
        }
        [Route("commentEnPost")]
        [ResponseType(typeof(Commentaire))]
        public IHttpActionResult PostArticle(Commentaire commentaire)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (var context = new NEWSEntities())
            {
                context.Commentaire.Add(commentaire);
                context.SaveChanges();

            }



            return CreatedAtRoute("DefaultApi", new { id = commentaire.ID }, commentaire);
        }


        [Route("comment")]
        public IHttpActionResult GetCommentaire(int id)
        {
            CommentaireModel commentair;
            using (var context = new NEWSEntities())
            {
                var A = context.Commentaire.Where(f => f.ArticleID == id).FirstOrDefault();
                if (A == null)
                {
                    return NotFound();
                }
                commentair = new CommentaireModel();
                commentair.ArticleID = id;
                commentair.Contenu = A.Contenu;
                commentair.User_mail = A.User_mail;
                commentair.User_name = A.User_name;
                commentair.CommentaireDate = A.CommentaireDate;

            }
            return Ok(commentair);
        }

        [Route("DaysArticle")]
        public IHttpActionResult GetArticleByDate()
        {

            FooterArticle Footer = new FooterArticle();
            FooterArticleModel fa1, fa2, fa3;
            using (var context = new NEWSEntities())
            {
                var today = DateTime.Now;
                List<ArticleViewModel> x = new List<ArticleViewModel>();
                fa1 = new FooterArticleModel();
                var yesterday1 = today.AddDays(-1);
                List<Article> articles = context.Article.Where(f => f.Date.Value.Day == yesterday1.Day).OrderBy(a => a.Date).Take(2).ToList();
                foreach (var A in articles)
                {
                    var article = new ArticleViewModel();
                    article.ID = A.ID;
                    article.Titre = A.Titre;
                    article.Body = A.Body;
                    article.Img = A.Img;
                    article.Video = A.video;
                    article.Date = A.Date.ToString();

                    x.Add(article);

                }
                fa1.listes = x;
                fa1.Img = context.Article.FirstOrDefault().Img;
                Footer.fam1 = fa1;

                fa2 = new FooterArticleModel();
                List<ArticleViewModel> y = new List<ArticleViewModel>();
                var yesterday2 = today.AddDays(-2);
                List<Article> articles1 = context.Article.Where(f => f.Date.Value.Day == yesterday2.Day).OrderBy(a => a.Date).Take(2).ToList();
                foreach (var A in articles1)
                {
                    var article = new ArticleViewModel();
                    article.ID = A.ID;
                    article.Titre = A.Titre;
                    article.Body = A.Body;
                    article.Img = A.Img;
                    article.Video = A.video;
                    article.Date = A.Date.ToString();
                    y.Add(article);

                    //fa2.listes.Add(article);
                }
                fa2.listes = y;
                fa2.Img = context.Article.FirstOrDefault().Img;
                Footer.fam2 = fa2;

                fa3 = new FooterArticleModel();
                List<ArticleViewModel> z = new List<ArticleViewModel>();
                var yesterday3 = today.AddDays(-3);
                List<Article> articles2 = context.Article.Where(f => f.Date.Value.Day == yesterday3.Day).OrderBy(a => a.Date).Take(2).ToList();
                foreach (var A in articles2)
                {
                    var article = new ArticleViewModel();
                    article.ID = A.ID;
                    article.Titre = A.Titre;
                    article.Body = A.Body;
                    article.Img = A.Img;
                    article.Video = A.video;
                    article.Date = A.Date.ToString();
                    z.Add(article);
                    //fa3.listes.Add(article);
                }
                fa3.listes = z;
                fa3.Img = context.Article.FirstOrDefault().Img;
                Footer.fam3 = fa3;





            }

            return Ok(Footer);
        }
        [Route("ArticleEnPost")]
        [ResponseType(typeof(Article))]
        public IHttpActionResult PostArticle(Article article)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (var context = new NEWSEntities())
            {
                context.Article.Add(article);
                context.SaveChanges();

            }



            return CreatedAtRoute("DefaultApi", new { id = article.ID }, article);
        }
        private NEWSEntities db = new NEWSEntities();
        [Route("ArticleEnPut")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutArticle(int id, Article article)

        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != article.ID)
            {
                return BadRequest();
            }

            db.Entry(article).State = EntityState.Modified;
            db.SaveChanges();


            return StatusCode(HttpStatusCode.NoContent);
        }








    }
}
