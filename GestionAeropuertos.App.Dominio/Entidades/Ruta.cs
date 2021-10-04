using System;

namespace GestionAeropuertos.App.Dominio
{
    public class Ruta
    {
        public int id{get;set;}
        public string origen{get;set;}
        public string destino{get;set;}
        public int tiempo_estimado{get;set;}
       
    }
}