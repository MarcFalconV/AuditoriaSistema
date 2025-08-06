using System.Collections.Generic;
using System.Linq;

public class FacultadRepositorio : BaseRepositorio<Facultad>
{
    private readonly RepositorioDatos accesoDatos = RepositorioDatos.Instancia;

    public override List<Facultad> Get()
    {
        return accesoDatos.ListaFacultads.Cast<Facultad>().ToList();
    }

    public override bool Post(Facultad entity)
    {
        accesoDatos.ListaFacultads.Add(entity);
        return true;
    }

    public override bool Put(int id)
    {
        var lista = accesoDatos.ListaFacultads.Cast<Facultad>().ToList();
        var item = lista.FirstOrDefault(x => x.IdFacultad == id);
        if (item != null)
        {
            accesoDatos.ListaFacultads.Remove(item);
            return true;
        }
        return false;
    }

    public override bool Update(Facultad entity)
    {
        var lista = accesoDatos.ListaFacultads.Cast<Facultad>().ToList();
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].IdFacultad == entity.IdFacultad)
            {
                accesoDatos.ListaFacultads[i] = entity;
                return true;
            }
        }
        return false;
    }
}
