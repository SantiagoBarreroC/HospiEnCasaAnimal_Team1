using System;
using System.Collections.Generic;
namespace HECM.App.Dominio
{
    public class Veterinario:Persona
    {
        public string TarjetaProfesional {get;set;}
        public string Especialidad {get;set;}
        public List<Mascota> Mascotas {get;set;}
    }
}
