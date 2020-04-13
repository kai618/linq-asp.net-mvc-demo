//using System.Linq;
//using System.Web.Mvc;
//using LinqDemoApp.Models;

//namespace LinqDemoApp.Controllers
//{
//    public class ShoeController : Controller
//    {
//        private readonly eshopEntities _db = new eshopEntities();


//        // select : GET
//        [HttpGet]
//        public ActionResult Index()
//        {
//            var typeListLambda = _db.LoaiSanPhams.ToList();

//            return View(typeListLambda);
//        }

//        // insert : POST
//        [HttpPost]
//        public void Add(string type)
//        {
//            _db.LoaiSanPhams.Add(new LoaiSanPham
//                {
//                    TenLoaiSP = type
//                }
//            );

//            _db.SaveChanges();
//        }


//        // update : POST
//        [HttpPost]
//        public void Update(int id, string value)
//        {
//            var type = _db.LoaiSanPhams.SingleOrDefault(t => t.MaLoaiSP == id);
//            if (type == null) return;

//            type.TenLoaiSP = value;

//            _db.SaveChanges();
//        }


//        // delete : POST
//        [HttpPost]
//        public void Delete(int id)
//        {
//            var type = _db.LoaiSanPhams.SingleOrDefault(t => t.MaLoaiSP == id);
//            if (type == null) return;

//            _db.LoaiSanPhams.Remove(type);
//            _db.SaveChanges();
//        }
//    }
//}