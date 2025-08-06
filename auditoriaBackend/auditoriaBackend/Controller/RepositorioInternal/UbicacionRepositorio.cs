using System.Collections.Generic;
using System.Linq;

public class UbicacionRepositorio : BaseRepositorio<Ubicacion>
{
    private readonly RepositorioDatos accesoDatos = RepositorioDatos.Instancia;

    public override List<Ubicacion> Get()
    {
        return accesoDatos.ListaUbicacions.Cast<Ubicacion>().ToList();
    }

    public override bool Post(Ubicacion entity)
    {
        accesoDatos.ListaUbicacions.Add(entity);
        return true;
    }

    public override bool Put(int id)
    {
        var lista = accesoDatos.ListaUbicacions.Cast<Ubicacion>().ToList();
        var item = lista.FirstOrDefault(x => x.IdUbicacion == id);
        if (item != null)
        {
            accesoDatos.ListaUbicacions.Remove(item);
            return true;
        }
        return false;
    }

    public override bool Update(Ubicacion entity)
    {
        var lista = accesoDatos.ListaUbicacions.Cast<Ubicacion>().ToList();
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].IdUbicacion == entity.IdUbicacion)
            {
                accesoDatos.ListaUbicacions[i] = entity;
                return true;
            }
        }
        return false;
    }
}
