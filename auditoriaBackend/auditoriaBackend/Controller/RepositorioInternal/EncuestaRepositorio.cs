using System.Collections.Generic;
using System.Linq;

public class EncuestaRepositorio : BaseRepositorio<Encuesta>
{
    private readonly RepositorioDatos accesoDatos = RepositorioDatos.Instancia;

    public override List<Encuesta> Get()
    {
        return accesoDatos.ListaEncuestas.Cast<Encuesta>().ToList();
    }

    public override bool Post(Encuesta entity)
    {
        accesoDatos.ListaEncuestas.Add(entity);
        return true;
    }

    public override bool Put(int id)
    {
        var lista = accesoDatos.ListaEncuestas.Cast<Encuesta>().ToList();
        var encontrado = lista.FirstOrDefault(x => x.IdEncuesta == id);
        if (encontrado != null)
        {
            accesoDatos.ListaEncuestas.Remove(encontrado);
            return true;
        }
        return false;
    }

    public override bool Update(Encuesta entity)
    {
        var lista = accesoDatos.ListaEncuestas.Cast<Encuesta>().ToList();
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].IdEncuesta == entity.IdEncuesta)
            {
                accesoDatos.ListaEncuestas[i] = entity;
                return true;
            }
        }
        return false;
    }
}
