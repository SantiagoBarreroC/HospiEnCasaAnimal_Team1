using System.Collections.Generic;
using HECM.App.Dominio;
using System.Linq;
using System;
using HECM.App.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace HECM.App.Persistencia{
    
    public class RepositorioMascota: IRepositorioMascota
    {
        private readonly AppContext _appContext= new AppContext();

        
        Mascota IRepositorioMascota.AddMascota (Mascota mascota)
        {
           var mascotaAdicionado=_appContext.Mascotas.Add(mascota);
           _appContext.SaveChanges();
           return mascotaAdicionado.Entity;
        }
        Mascota IRepositorioMascota.UpdateMascota (Mascota mascota)
        {
           var mascotaEncontrado=_appContext.Mascotas.FirstOrDefault(p => p.Id ==mascota.Id);
           if(mascotaEncontrado!=null) 
           {
               mascotaEncontrado.Id=mascota.Id;
               mascotaEncontrado.Nombre=mascota.Nombre;
               mascotaEncontrado.TipoMascota=mascota.TipoMascota;
               mascotaEncontrado.FechaNacimiento=mascota.FechaNacimiento;
               mascotaEncontrado.Sexo=mascota.Sexo;
               mascotaEncontrado.Direccion=mascota.Direccion;
               mascotaEncontrado.Latitud=mascota.Latitud;
               mascotaEncontrado.Longitud=mascota.Longitud;
               mascotaEncontrado.Propietario=mascota.Propietario;
               mascotaEncontrado.Veterinario=mascota.Veterinario;
               mascotaEncontrado.Historia=mascota.Historia;

               _appContext.SaveChanges();
           }
           return mascotaEncontrado;
        }
      
        void IRepositorioMascota.DeleteMascota (int IdMascota)
        {
           var mascotaEncontrado=_appContext.Mascotas.FirstOrDefault(p => p.Id ==IdMascota);
           //var mascotaEncontrado=_appContext.Mascotas.Find(IdMascota);
           if(mascotaEncontrado==null)
           return;
           _appContext.Mascotas.Remove(mascotaEncontrado);
           _appContext.SaveChanges();
        }
        Mascota IRepositorioMascota.GetMascota (int IdMascota)
        {
           var mascotaEncontrado=_appContext.Mascotas.FirstOrDefault(p => p.Id ==IdMascota);
           return mascotaEncontrado;
        }
        IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas()
        {
           return _appContext.Mascotas;
        }
    }
}