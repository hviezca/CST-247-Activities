using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class ButtonController : Controller
    {
        private static List<ButtonModel> buttons; 

        // GET: Button
        public ActionResult Index()
        {
            buttons = new List<ButtonModel>();
            buttons.Add(new ButtonModel(true));
            buttons.Add(new ButtonModel(false));

            return View("Button", buttons);
        }

        public ActionResult OnButtonClick(string mine)
        {
            if (mine == "1")
            {
                if (buttons[0].State)
                {
                    buttons[0].State = false;
                    return View("Button", buttons);
                }
                else
                {
                    buttons[0].State = true;
                    return View("Button", buttons);
                }
            }
            else if (mine == "2")
            {
                if (buttons[1].State)
                {
                    buttons[1].State = false;
                    return View("Button", buttons);
                }
                else
                {
                    buttons[1].State = true;
                    return View("Button", buttons);
                }
            }
            else
            {
                return View("Button", buttons);
            }
        }
    }
}