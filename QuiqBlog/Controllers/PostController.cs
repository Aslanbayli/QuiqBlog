using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuiqBlog.Repositories;

namespace QuiqBlog.Controllers
{
    public class PostController : Controller
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;

        public PostController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        // GET: Post
        public async Task<IActionResult> Index()
        {
            var post = _unitOfWork.Posts.GetAll();
            return View(await post);
        }

        // GET: Posts/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
