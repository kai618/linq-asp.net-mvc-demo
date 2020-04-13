using System.Web.Mvc;
using System.Linq;
using LinqDemoApp.Models;

namespace LinqDemoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly eshopEntities _context = new eshopEntities();

        // select : GET
        public ActionResult Index()
        {
            var types = (from loai in _context.LoaiSanPhams where loai.MaLoaiSP < 3 select loai).ToList();

            var typesL = _context.LoaiSanPhams.ToList();

            return View(typesL);
        }

        // insert : POST
        public void Insert(string value)
        {
            _context.LoaiSanPhams.Add(new LoaiSanPham
            {
                TenLoaiSP = value
            });

            _context.SaveChanges();
        }


        // update : POST
        public void Update(int id, string value)
        {
            var type = _context.LoaiSanPhams.SingleOrDefault(t => t.MaLoaiSP == id);
            if (type == null) return;

            type.TenLoaiSP = value;
            _context.SaveChanges();
        }

        // delete : POST

        public void Delete(int id)
        {
            var type = _context.LoaiSanPhams.SingleOrDefault(t => t.MaLoaiSP == id);
            if (type == null) return;

            _context.LoaiSanPhams.Remove(type);
            _context.SaveChanges();
        }

    }
}