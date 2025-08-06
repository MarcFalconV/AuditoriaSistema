using System.Collections.Generic;
using System.Linq;

public class PersonaRepositorio : BaseRepositorio<Persona>
{
    private readonly RepositorioDatos accesoDatos = RepositorioDatos.Instancia;

    public override List<Persona> Get()
    {
        return accesoDatos.ListaPersonas.Cast<Persona>().ToList();
    }

    public override bool Post(Persona entity)
    {
        accesoDatos.ListaPersonas.Add(entity);
        return true;
    }

    public override bool Put(int id)
    {
        var lista = accesoDatos.ListaPersonas.Cast<Persona>().ToList();
        var encontrado = lista.FirstOrDefault(x => x.IdPersona == id);
        if (encontrado != null)
        {
            accesoDatos.ListaPersonas.Remove(encontrado);
            return true;
        }
        return false;
    }

    public override bool Update(Persona entity)
    {
        var lista = accesoDatos.ListaPersonas.Cast<Persona>().ToList();
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].IdPersona == entity.IdPersona)
            {
                accesoDatos.ListaPersonas[i] = entity;
                return true;
            }
        }
        return false;
    }
}
