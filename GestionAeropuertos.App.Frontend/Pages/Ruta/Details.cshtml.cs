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
    public class DetailsRutaModel : PageModel
    {
       private readonly RepositorioRutas repositorioRutas;
              public Ruta Ruta{get;set;}

        public DetailsRutaModel(RepositorioRutas repositorioRutas)
       {
            this.repositorioRutas=repositorioRutas;
       }

        public IActionResult OnGet(int rutaId)
        {
                Ruta=repositorioRutas.GetRutaWithId(rutaId);
                return Page();

        }
    }
}
