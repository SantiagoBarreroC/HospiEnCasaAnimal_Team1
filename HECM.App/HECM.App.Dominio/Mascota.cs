using System;
namespace HECM.App.Dominio
{
    public class Mascota
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public TipoMascota TipoMascota {get;set;}
        public string FechaNacimiento {get;set;}
        public Sexo Sexo {get;set;}
        public string Direccion {get;set;}
        public string Latitud {get;set;}
        public string Longitud {get;set;}
    }
}