using System.Collections.Generic;
using System.Linq;

public class SeccionRepositorio : BaseRepositorio<Seccion>
{
    private readonly RepositorioDatos accesoDatos = RepositorioDatos.Instancia;

    public override List<Seccion> Get()
    {
        return accesoDatos.ListaSeccions.Cast<Seccion>().ToList();
    }

    public override bool Post(Seccion entity)
    {
        accesoDatos.ListaSeccions.Add(entity);
        return true;
    }

    public override bool Put(int id)
    {
        var lista = accesoDatos.ListaSeccions.Cast<Seccion>().ToList();
        var encontrado = lista.FirstOrDefault(x => x.IdSeccion == id);
        if (encontrado != null)
        {
            accesoDatos.ListaSeccions.Remove(encontrado);
            return true;
        }
        return false;
    }

    public override bool Update(Seccion entity)
    {
        var lista = accesoDatos.ListaSeccions.Cast<Seccion>().ToList();
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].IdSeccion == entity.IdSeccion)
            {
                accesoDatos.ListaSeccions[i] = entity;
                return true;
            }
        }
        return false;
    }
}
