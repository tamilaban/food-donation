using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonation.Controllers
{
    public class RolesController : Controller
    {
        RoleManager<IdentityRole> roleManager;

        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var roles = roleManager.Roles.ToList();
            return View(roles);
        }

        public IActionResult Create()
        {
            return View(new IdentityRole());
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            await roleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roles = roleManager.Roles.Where(r=> r.Id == id).FirstOrDefault();
            if (roles == null)
            {
                return NotFound();
            }
            return View(roles);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, IdentityRole role)
        {
            if (id != role.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await roleManager.UpdateAsync(role);
                return RedirectToAction(nameof(Index));
           
            }
            return View(role);
        }
        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roles = roleManager.Roles.Where(r=> r.Id == id).FirstOrDefault();
            if (roles == null)
            {
                return NotFound();
            }
            return View(roles);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id, IdentityRole role)
        {
            await roleManager.DeleteAsync(role);
            return RedirectToAction(nameof(Index));
        }
    }
}