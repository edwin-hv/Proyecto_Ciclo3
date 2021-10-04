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
    public class DetailsAeropuertoModel : PageModel
    {
       private readonly RepositorioAeropuertos repositorioaeropuertos;
              public Aeropuerto Aeropuerto{get;set;}

        public DetailsAeropuertoModel(RepositorioAeropuertos repositorioaeropuertos)
       {
            this.repositorioaeropuertos=repositorioaeropuertos;
       }

        public IActionResult OnGet(int aeropuertoId)
        {
                Aeropuerto=repositorioaeropuertos.GetAeropuertoWithId(aeropuertoId);
                return Page();

        }
    }
}
