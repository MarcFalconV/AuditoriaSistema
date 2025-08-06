using System.Collections.Generic;
using System.Linq;

public class PreguntaRepositorio : BaseRepositorio<Pregunta>
{
    private readonly RepositorioDatos accesoDatos = RepositorioDatos.Instancia;

    public override List<Pregunta> Get()
    {
        return accesoDatos.ListaPreguntas.Cast<Pregunta>().ToList();
    }

    public override bool Post(Pregunta entity)
    {
        accesoDatos.ListaPreguntas.Add(entity);
        return true;
    }

    public override bool Put(int id)
    {
        var lista = accesoDatos.ListaPreguntas.Cast<Pregunta>().ToList();
        var encontrado = lista.FirstOrDefault(x => x.IdPregunta == id);
        if (encontrado != null)
        {
            accesoDatos.ListaPreguntas.Remove(encontrado);
            return true;
        }
        return false;
    }

    public override bool Update(Pregunta entity)
    {
        var lista = accesoDatos.ListaPreguntas.Cast<Pregunta>().ToList();
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].IdPregunta == entity.IdPregunta)
            {
                accesoDatos.ListaPreguntas[i] = entity;
                return true;
            }
        }
        return false;
    }
}