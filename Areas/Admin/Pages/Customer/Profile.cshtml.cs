using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Markatooo.Data;
using System.Threading.Tasks;

namespace Markatooo.Areas.Admin.Pages.Customer
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private readonly MarkatoooContext _context;

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _HttpContext;
        //private readonly HttpContext httpContext;
        [BindProperty]
        public ApplicationUser user { get; set; }

        public string email { get; set; }


        public ProfileModel(MarkatoooContext context,
                            UserManager<ApplicationUser> userManager, IHttpContextAccessor HttpContext
)
        {
            _HttpContext = HttpContext;
            _context = context;
            _userManager = userManager;
            //httpContext = HttpContex;
        }
        public void OnGet()
        {
            user= _userManager.GetUserAsync(_HttpContext.HttpContext.User).Result;
        }

        public async Task<IActionResult>  OnPost()
        {
            //var oldUser = _userManager.FindByEmailAsync(user.Email).Result;
            var oldUser = await _userManager.FindByIdAsync(user.Id);



            oldUser.Email = user.UserName;
            oldUser.UserName = user.UserName;
            oldUser.PhoneNumber = user.PhoneNumber;

            await _userManager.UpdateAsync(oldUser);

            await _context.SaveChangesAsync();

            return Page();

        }
    }
}
