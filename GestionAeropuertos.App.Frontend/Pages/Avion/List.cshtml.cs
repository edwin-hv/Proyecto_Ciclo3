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
    public class ListAvionModel : PageModel
    {   
        private readonly RepositorioAviones repositorioaviones;
        public IEnumerable<Avion> Aviones {get;set;}
        [BindProperty]
        public Avion Avion  {get;set;}
        public ListAvionModel(RepositorioAviones repositorioaviones)
    {
        this.repositorioaviones=repositorioaviones;
     }


        public void OnGet()
        {
                Aviones=repositorioaviones.GetAll();

       
        }
        
        public IActionResult OnPost()
    {
        if(Avion.id>0)
        {
        repositorioaviones.Delete(Avion.id);
        }
        return RedirectToPage("./List");
    }


        
    }
}
