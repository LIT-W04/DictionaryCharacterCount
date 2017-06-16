using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string text)
        {
            HomePageViewModel vm = new HomePageViewModel();
            if (!String.IsNullOrEmpty(text))
            {
                vm.CharacterCounts = CountCharsDictionary(text.ToUpper());
                vm.Text = text;
            }
            return View(vm);
        }

        private Dictionary<char, int> CountCharsDictionary(string text)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach (char letter in "ABCDEFGHIJKLMNOPQRSTUVWXYZ")
            {
                result.Add(letter, 0);
            }

            foreach (char character in text)
            {
                if (result.ContainsKey(character))
                {
                    result[character]++;
                }
            }

            return result;

        }
    }
}