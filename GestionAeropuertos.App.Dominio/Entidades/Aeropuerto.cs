using System;

namespace GestionAeropuertos.App.Dominio
{
    public class Aeropuerto
    {
        public int id{get;set;}
        public string nombre{get;set;}
        public string ciudad{get;set;}
        public string pais{get;set;}
        public int coordenada_x{get;set;}
        public int coordenada_y{get;set;}
    }
}
