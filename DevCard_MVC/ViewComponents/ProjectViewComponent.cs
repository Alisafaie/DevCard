using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1, 
                    "پروژه شبکه دفتر مهندسی 1630",
                    "پیاده سازی شبکه آقای مهندس ایروانی زاده به همراه پیاده سازی ذخیره ساز تحت شبکه دکاس و همچنین پیاده سازی بستر اکتیو دایرکتوری برای مدیریت کاربران و سطوح دسترسی در شبکه",
                    "project-1.jpg",
                    "دفتر مهندسی 1630"),
                new Project(2, 
                    "پیاده سازی اکتیو دایرکتوری شرکت پلشیر",
                    "پیاده سازی اکتیو دایکتوری برای کاربران برای بیش از 40 کامپیوتر", 
                    "project-2.jpg", 
                    "مهندس قانعی"),

                new Project(3, 
                    "پروژه VoIP نمایندگی پرشیا خودرو", 
                    "کابل کشی، عیب یابی و رفع مشکلات شبکه",
                    "project-3.jpg",
                    "وحید روفیگری اصفهان")
            };
            return View("_Projects", projects);
        }
    }
}