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
    public class EditRutaModel : PageModel
    {
       private readonly RepositorioRutas repositorioRutas;
       [BindProperty]
        public Ruta Ruta{get;set;}

        public EditRutaModel (RepositorioRutas repositorioRutas)
       {
            this.repositorioRutas=repositorioRutas;
       }

        public IActionResult OnGet(int rutaId)
        {
                Ruta=repositorioRutas.GetRutaWithId(rutaId);
                return Page();

        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Ruta.id>0)
            {
            Ruta = repositorioRutas.Update(Ruta);
            }
            return RedirectToPage("./List");
        }




    }
}
