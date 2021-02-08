using _Parcial1_ap1__20180616.DAL;
using _Parcial1_ap1__20180616.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Parcial1_ap1__20180616.BLL
{
    public class CiudadesBLL
    {
        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Ciudades.Any(e => e.CiudadId == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static bool Insertar(Ciudades ciudades)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Ciudades.Add(ciudades);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Ciudades ciudades)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(ciudades).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Guardar(Ciudades ciudades)
        {
            if (!Existe(ciudades.CiudadId))
                return Insertar(ciudades);
            else
                return Modificar(ciudades);
        }

        public static Ciudades Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Ciudades ciudades;

            try
            {
                ciudades = contexto.Ciudades.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return ciudades;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var ciudades = contexto.Ciudades.Find(id);
                
                if(ciudades != null)
                {
                    contexto.Ciudades.Remove(ciudades);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
    }
}
