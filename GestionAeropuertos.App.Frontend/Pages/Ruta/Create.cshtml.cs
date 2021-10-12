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
    public class FormRutaModel : PageModel
    {
       private readonly RepositorioRutas repositorioRutas;
       private readonly RepositorioAeropuertos repositorioAeropuertos;
       public IEnumerable<Aeropuerto> aeropuertos{get;set;}

       [BindProperty]
        public Ruta Ruta{get;set;}

        public FormRutaModel(RepositorioRutas repositorioRutas, RepositorioAeropuertos repositorioAeropuertos)
       {
            this.repositorioRutas=repositorioRutas;
            this.repositorioAeropuertos=repositorioAeropuertos;
       }

        public void OnGet()
        {
        aeropuertos=repositorioAeropuertos.GetAll();    
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
            Ruta = repositorioRutas.Create(Ruta);
            return RedirectToPage("./List");
        }




    }
}

