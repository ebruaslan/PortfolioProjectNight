using PortfolioProjectNight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioProjectNight.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        DbMyPortfolioNightEntities context = new DbMyPortfolioNightEntities();
        public ActionResult SkillList()
        {
            var values = context.Skill.ToList();
            return View(values);
        }
    }
}