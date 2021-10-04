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
    public class EditAeropuertoModel : PageModel
    {
       private readonly RepositorioAeropuertos repositorioaeropuertos;
       [BindProperty]
        public Aeropuerto Aeropuerto{get;set;}

        public EditAeropuertoModel(RepositorioAeropuertos repositorioaeropuertos)
       {
            this.repositorioaeropuertos=repositorioaeropuertos;
       }

        public IActionResult OnGet(int aeropuertoId)
        {
                Aeropuerto=repositorioaeropuertos.GetAeropuertoWithId(aeropuertoId);
                return Page();

        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Aeropuerto.id>0)
            {
            Aeropuerto = repositorioaeropuertos.Update(Aeropuerto);
            }
            return RedirectToPage("./List");
        }




    }
}
