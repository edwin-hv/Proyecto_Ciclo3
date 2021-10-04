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
    public class ListRutaModel : PageModel
    {   
        private readonly RepositorioRutas repositorioRutas;
        public IEnumerable<Ruta> Rutas {get;set;}
        public ListRutaModel(RepositorioRutas repositorioRutas)
    {
        this.repositorioRutas=repositorioRutas;
     }


        public void OnGet()
        {
                Rutas=repositorioRutas.GetAll();
        }
    }
}
