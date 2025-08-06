using System.Collections.Generic;
using System.Linq;

public class SeguimientoRepositorio : BaseRepositorio<Seguimiento>
{
    private readonly RepositorioDatos accesoDatos = RepositorioDatos.Instancia;

    public override List<Seguimiento> Get()
    {
        return accesoDatos.ListaSeguimientos.Cast<Seguimiento>().ToList();
    }

    public override bool Post(Seguimiento entity)
    {
        accesoDatos.ListaSeguimientos.Add(entity);
        return true;
    }

    public override bool Put(int id)
    {
        var lista = accesoDatos.ListaSeguimientos.Cast<Seguimiento>().ToList();
        var encontrado = lista.FirstOrDefault(x => x.IdSeguimiento == id);
        if (encontrado != null)
        {
            accesoDatos.ListaSeguimientos.Remove(encontrado);
            return true;
        }
        return false;
    }

    public override bool Update(Seguimiento entity)
    {
        var lista = accesoDatos.ListaSeguimientos.Cast<Seguimiento>().ToList();
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].IdSeguimiento == entity.IdSeguimiento)
            {
                accesoDatos.ListaSeguimientos[i] = entity;
                return true;
            }
        }
        return false;
    }
}