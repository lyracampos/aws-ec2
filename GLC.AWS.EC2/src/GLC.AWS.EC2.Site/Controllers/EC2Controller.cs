using System.Threading.Tasks;
using GLC.AWS.EC2.Services.Services;
using GLC.AWS.EC2.Site.Models.EC2;
using Microsoft.AspNetCore.Mvc;

namespace GLC.AWS.EC2.Site.Controllers
{
    public class EC2Controller : Controller
    {
        private readonly IEC2Service _ec2Service;

        public EC2Controller(IEC2Service ec2Service)
        {
            _ec2Service = ec2Service;
        }

        public async Task<IActionResult> Index()
        {
            var model = new EC2InstanceListModel(await _ec2Service.Get());
            return View(model);
        }

        public async Task<IActionResult> Detail(string id)
        {
            var model = new EC2InstanceModel(await _ec2Service.Get(id));
            return View(model);
        }

        public async Task<IActionResult> Start(string id)
        {
            await _ec2Service.Start(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Stop(string id)
        {
            await _ec2Service.Stop(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Restart(string id)
        {
            await _ec2Service.Restart(id);
            return RedirectToAction("Index");
        }
    }
}
