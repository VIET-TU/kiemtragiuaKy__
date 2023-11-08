using Microsoft.AspNetCore.Mvc;
using NguyenVietTu_211200970.Models;

namespace NguyenVietTu_211200970.ViewComponents
{
	public class NavViewComponent : ViewComponent
	{
		QLHangHoaContext db;
        List<LoaiHang> majors;
        public NavViewComponent(QLHangHoaContext _context)
        {
            db = _context;
            majors = db.LoaiHangs.ToList();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderNav", majors);
        }
	}
}
