using Microsoft.AspNetCore.Mvc;
using MVCConnect.Models;
using MVCConnect.ViewModels;

namespace MVCConnect.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            Work work1 = new Work()
            {
                Name = "UI/UX design",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing",
                ImgUrl = "services-01.jpg"
            };

            Work work2 = new Work()
            {
                Name = "Social Media",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing",
                ImgUrl = "services-02.jpg"
            };


            Work work3 = new Work()
            {
                Name = "Marketing",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing",
                ImgUrl = "services-03.jpg"
            };


            Work work4 = new Work()
            {
                Name = "Graphic",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing",
                ImgUrl = "services-04.jpg"
            };


            Work work5 = new Work()
            {
                Name = "Digtal Marketing",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing",
                ImgUrl = "services-05.jpg"
            };


            Work work6 = new Work()
            {
                Name = "Market Research6",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing",
                ImgUrl = "services-06.jpg"
            };

            Work work7 = new Work()
            {
                Name = "Business",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing",
                ImgUrl = "services-07.jpg"
            };

            Work work8 = new Work()
            {
                Name = "Branding",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing",
                ImgUrl = "services-08.jpg"
            };

            List<Work> works = new List<Work>();

            works.Add(work1);
            works.Add(work2);
            works.Add(work3);
            works.Add(work4);
            works.Add(work5);
            works.Add(work6);
            works.Add(work7);
            works.Add(work8);

            RecentWork recentWork1 = new RecentWork()
            {
                Name = "Social Media",
                Description = "Ullamco laboris nisi ut aliquip ex",
                ImgUrl = "recent-work-01.jpg"
            };

            RecentWork recentWork2 = new RecentWork()
            {
                Name = "Web Marketing",
                Description = "Ullamco laboris nisi ut aliquip ex",
                ImgUrl = "recent-work-02.jpg"
            };

            RecentWork recentWork3 = new RecentWork()
            {
                Name = "R & D",
                Description = "Ullamco laboris nisi ut aliquip ex",
                ImgUrl = "recent-work-03.jpg"
            };

            RecentWork recentWork4 = new RecentWork()
            {
                Name = "Public Relation",
                Description = "Ullamco laboris nisi ut aliquip ex",
                ImgUrl = "recent-work-04.jpg"
            };

            RecentWork recentWork5 = new RecentWork()
            {
                Name = "Branding",
                Description = "Ullamco laboris nisi ut aliquip ex",
                ImgUrl = "recent-work-05.jpg"
            };

            RecentWork recentWork6 = new RecentWork()
            {
                Name = ">Creative Design06",
                Description = "Ullamco laboris nisi ut aliquip ex",
                ImgUrl = "recent-work-06.jpg"
            };

            List<RecentWork> recentWorks = new List<RecentWork>();
            recentWorks.Add(recentWork1);
            recentWorks.Add(recentWork2);
            recentWorks.Add(recentWork3);
            recentWorks.Add(recentWork4);
            recentWorks.Add(recentWork5);
            recentWorks.Add(recentWork6);
           

            HomeVM homeVM = new HomeVM()
            {
                Works = works,
                RecentWorks = recentWorks
            };

            return View(homeVM);
        }
    }
}
