using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data.Context;
using Blog.Data.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogContext _blogContext;

            public BlogController(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public IActionResult New()
        {
            List<Data.Models.Category> categories = _blogContext.Categories.Where(a => !a.Deleted).ToList();

            return View(categories);
        }

        public IActionResult Add([FromBody] BlogAddDto blogAdd)
        {
            int UserId = HttpContext.Session.GetInt32("UserId").Value;
            Blog.Data.Models.Blog blog = new Blog.Data.Models.Blog()
            {
                UserId= UserId,
                Title=blogAdd.Title,
                Content=blogAdd.Content,
                CreateDate=DateTime.UtcNow,
                Hit=0,
                Deleted =false,
                CategoryId=0
            };


            _blogContext.Blogs.Add(blog);
            _blogContext.SaveChanges();

            return Ok();
        }
    }

}