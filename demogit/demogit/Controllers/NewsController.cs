using demogit.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using demogit.Models;

namespace YourProjectName.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            // Gán dữ liệu cứng
            var newsList = new List<News>()
            {
                new News
                {
                    Id = 1,
                    Title = "Công nghệ .NET 9 chính thức ra mắt",
                    Description = "Microsoft vừa phát hành .NET 9 với nhiều cải tiến về hiệu năng và bảo mật.",
                    ImageUrl = "https://via.placeholder.com/300x200",
                    Date = "16/10/2025"
                },
                new News
                {
                    Id = 2,
                    Title = "ASP.NET Core MVC vẫn là lựa chọn hàng đầu cho lập trình web",
                    Description = "Nhiều công ty vẫn tin tưởng sử dụng ASP.NET Core cho các ứng dụng doanh nghiệp.",
                    ImageUrl = "https://via.placeholder.com/300x200",
                    Date = "14/10/2025"
                },
                new News
                {
                    Id = 3,
                    Title = "Cao Thắng Tech College đẩy mạnh đào tạo lập trình web",
                    Description = "Sinh viên được học ASP.NET, Node.js và React để đáp ứng nhu cầu thị trường.",
                    ImageUrl = "https://via.placeholder.com/300x200",
                    Date = "12/10/2025"
                }
            };

            return View(newsList);
        }
    }
}
