using PortfolioProjectNight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortfolioProjectNight.Controllers
{
    public class ExperienceController : Controller
    {
        DbMyPortfolioNightEntities context = new DbMyPortfolioNightEntities();
        public ActionResult ExperienceList()
        {
            var values = context.Expertience.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateExperience(Expertience expertience)
        {
            context.Expertience.Add(expertience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public ActionResult DeleteExperience(int id)
        {
            var value = context.Expertience.Find(id);
            context.Expertience.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var value = context.Expertience.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateExperience(Expertience expertience)
        {
            var value = context.Expertience.Find(expertience.ExpertienceId);
            value.SubTitle = expertience.SubTitle;
            value.Title = expertience.Title;
            value.Description = expertience.Description;
            context.SaveChanges();
            return RedirectToAction("ExperienceList");

        }
    }

}