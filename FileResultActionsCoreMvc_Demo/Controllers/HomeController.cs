using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.IO;
using System.Text;

namespace FileResultActionsCoreMvc_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public FileResult DownloadFile()
        {
            return File("/Files/File Result.pdf", "text/plain", "File Result.pdf");
        }

        public FileContentResult DownloadContent()
        {
            var myfile = System.IO.File.ReadAllBytes("wwwroot/Files/FileContentResult.pdf");
            return new FileContentResult(myfile, "application/pdf");
        }

        public FileStreamResult CreateFile()
        {
            var stream = new MemoryStream(Encoding.ASCII.GetBytes("Hello World"));
            return new FileStreamResult(stream, new MediaTypeHeaderValue("text/plain"))
            {
                FileDownloadName = "HelloWorldText.txt"
            };
        }
        public VirtualFileResult VirtualFileResult()
        {
            return new VirtualFileResult("/Files/PhysicalFileResult.pdf", "application/pdf");
        }

        public PhysicalFileResult PhysicalFileResult()
        {
            return new PhysicalFileResult(_environment.ContentRootPath + "/wwwroot/Files/PhysicalFileResult.pdf", "application/pdf");
        }

    }
}
