using System.Collections.Generic;
using System.Linq;

public class RespuestaRepositorio : BaseRepositorio<Respuesta>
{
    private readonly RepositorioDatos accesoDatos = RepositorioDatos.Instancia;

    public override List<Respuesta> Get()
    {
        return accesoDatos.ListaRespuestas.Cast<Respuesta>().ToList();
    }

    public override bool Post(Respuesta entity)
    {
        accesoDatos.ListaRespuestas.Add(entity);
        return true;
    }

    public override bool Put(int id)
    {
        var lista = accesoDatos.ListaRespuestas.Cast<Respuesta>().ToList();
        var encontrado = lista.FirstOrDefault(x => x.IdRespuesta == id);
        if (encontrado != null)
        {
            accesoDatos.ListaRespuestas.Remove(encontrado);
            return true;
        }
        return false;
    }

    public override bool Update(Respuesta entity)
    {
        var lista = accesoDatos.ListaRespuestas.Cast<Respuesta>().ToList();
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].IdRespuesta == entity.IdRespuesta)
            {
                accesoDatos.ListaRespuestas[i] = entity;
                return true;
            }
        }
        return false;
    }
}
