using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SecondExercise.Models;

namespace SecondExercise.Pages.Enrollment
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public PersonModel Person { get; set; }

        public void OnGet(string name, string age, string address)
        {

        }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return Redirect("/Index");

        }
    }
}