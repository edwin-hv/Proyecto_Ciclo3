using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GestionAeropuertos.App.Persistencia.AppRepositorios;
using GestionAeropuertos.App.Dominio;

namespace GestionAeropuertos.App.Frontend.Pages
{
    public class EditAvionModel : PageModel
    {
       private readonly RepositorioAviones repositorioaviones;
       [BindProperty]
        public Avion Avion{get;set;}

        public EditAvionModel(RepositorioAviones repositorioaviones)
       {
            this.repositorioaviones=repositorioaviones;
       }

        public IActionResult OnGet(int avionId)
        {
                Avion=repositorioaviones.GetAvionWithId(avionId);
                return Page();

        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Avion.id>0)
            {
            Avion = repositorioaviones.Update(Avion);
            }
            return RedirectToPage("./List");
        }




    }
}
