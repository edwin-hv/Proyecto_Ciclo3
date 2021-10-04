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
    public class ListAeropuertoModel : PageModel
    {   
        private readonly RepositorioAeropuertos repositorioaeropuertos;
        public IEnumerable<Aeropuerto> Aeropuertos {get;set;}
        public ListAeropuertoModel(RepositorioAeropuertos repositorioaeropuertos)
    {
        this.repositorioaeropuertos=repositorioaeropuertos;
     }


        public void OnGet()
        {
                Aeropuertos=repositorioaeropuertos.GetAll();
        }
    }
}
