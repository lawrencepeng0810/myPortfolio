using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myPortfolio.Models;

namespace myPortfolio.Controllers
{
    public class ChartsController : Controller
    {
        public ActionResult PersonalData()
        {
            // 個人特質表
            string[] PersonalLabel = { "富創意性", "團隊合作", "學習能力", "問題解決", "人際互動", "適應能力" };
            int[] PersonalData = { 72, 81, 75, 65, 70, 70 };
            ViewBag.PersonalLabel = PersonalLabel;
            ViewBag.PersonalData = PersonalData;

            // 各項技能熟悉度
            string[] SkillLabels = { "OOP Design", "Design Pattern", "ASP.net MVC", "C#", "HTML/CSS/JS", "MS DataBase", "Reporting Service Tools", "Android OS", "Kotlin", "IntelliJ 開發工具", "MongoDB", "ChartJS", "Office 應用" };
            int[] SkillData = { 60, 45, 70, 75, 60, 72, 50, 10, 32, 30, 10, 65, 78 };
            ViewBag.SkillLabels = SkillLabels;
            ViewBag.SkillData = SkillData;

            return View();
        }
        public ActionResult SkillData()
        {
            string[] SkillLabels = { "OOP Design", "Design Pattern", "ASP.net MVC", "C#", "HTML/CSS/JS","MS DataBase", "Android OS", "Kotlin", "IntelliJ 開發工具", "Reporting Service Tools", "MongoDB", "ChartJS", "Office 應用" };
            int[] SkillData = { 60, 45, 70, 75, 60, 72, 50, 45, 45, 80, 20, 65, 78 };
            ViewBag.SkillLabels = SkillLabels;
            ViewBag.SkillData = SkillData;

            return View();
        }
    }
}