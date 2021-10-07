using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var latestArticles = new List<Article>()
            {
                new Article(1,
                    "آموزش سیتریکس XenDesktop معماری MCS",
                    "در ادامه مجموعه دوره های آموزش سیتریکس XenDesktop با آموزش معماری MCS در بخش Machine Creation Services در خدمت شما کارشناسان حوزه مجازی سازی هستیم. در بخش ها قبلی ابتدا به طور کامل با نرم افزار سیتریکس XenDesktop آشنا شده و به بحثی کامل در خصوص Delivery Controller پرداختیم. اکنون در ادامه وارد جلسات آموزش سرویس های ساخت ماشین یا Machine Creation Services در زیرساخت Citrix XenDesktop خواهیم پرداخت. اولین جلسه به معماری MCS ها پرداخته است.",
                    "blog-post-thumb-card-1.jpg"),
                new Article(2,
                    "آموزش DNS ویندوز سرور 2019", "از جمله سرویس های مهم در شبکه سازمان ها، سرویس DNS است. از DNS استفاده های زیادی می شود مهم ترین این استفاده ها، ترجمه آدرس IP به نام ها و بالعکس  دیگر استفاده که از DNS می شود پیدا کردن سرویس های مختلف در شبکه است. به عنوان مثال با ساخت رکورد MX شما عملاً آدرس سرویس ایمیل را در DNS تعریف خواهید کرد.",
                    "blog-post-thumb-card-2.jpg"),
                new Article(3,
                    "آموزش DHCP ویندوز سرور 2019", "یکی از سرویس های مهم اما ساده در شبکه سرویس DHCP است. در این دوره آموزشی به بررسی و پوشش کامل پیاده سازی و نگهداری DHCP Server  پرداخته می شود. این دوره در چهار جلسه ارائه شده است. که در ادامه به هر یک از آن ها خواهیم پرداخت.",
                    "blog-post-thumb-card-3.jpg"),
                new Article(4,
                    "ترفند های استفاده از لایسنس سیتریکس", "هنگام خرید لایسنس سیتریکس نسخه های سیتریکس XenDesktop and XenApp و یا Citrix Virtual Desktops and Virtual Apps شما می توانید دو مدل مختلف را انتخاب کنید. یکی ConCurrent Users و دیگری User/Device که هرکدام از این مدل لایسنس ها شرایط خاص خود را دارند. ",
                    "blog-post-thumb-card-4.jpg"),
            };

            return View("LatestArticles", latestArticles);
        }
    }
}
