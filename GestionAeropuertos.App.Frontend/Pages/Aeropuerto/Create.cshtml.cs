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
    public class FormAeropuertoModel : PageModel
    {
       private readonly RepositorioAeropuertos repositorioAeropuertos;
       [BindProperty]
        public Aeropuerto Aeropuerto{get;set;}

        public FormAeropuertoModel(RepositorioAeropuertos repositorioAeropuertos)
       {
            this.repositorioAeropuertos=repositorioAeropuertos;
       }

        public void OnGet()
        {
                
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
            Aeropuerto = repositorioAeropuertos.Create(Aeropuerto);
            return RedirectToPage("./List");
        }




    }
}

