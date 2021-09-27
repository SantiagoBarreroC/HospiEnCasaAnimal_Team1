using System.Collections.Generic;
namespace HECM.App.Dominio

{
    public class Historia
    {
        public int Id {get;set;}
        public string Entorno {get;set;}
        public string Diagnostico {get;set;}
        public List<SugerenciaCuidado> Sugerencias {get;set;}
    }
}
