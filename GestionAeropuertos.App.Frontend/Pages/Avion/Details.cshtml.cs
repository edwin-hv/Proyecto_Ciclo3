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
    public class DetailsAvionModel : PageModel
    {
       private readonly RepositorioAviones repositorioaviones;
              public Avion Avion{get;set;}

        public DetailsAvionModel(RepositorioAviones repositorioaviones)
       {
            this.repositorioaviones=repositorioaviones;
       }

        public IActionResult OnGet(int avionId)
        {
                Avion=repositorioaviones.GetAvionWithId(avionId);
                return Page();

        }
    }
}
