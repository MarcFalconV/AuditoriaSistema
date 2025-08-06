using System.Collections.Generic;
using System.Linq;

public class AuditoriaRepositorio : BaseRepositorio<Auditoria>
{
    private readonly RepositorioDatos accesoDatos = RepositorioDatos.Instancia;

    public override List<Auditoria> Get()
    {
        return accesoDatos.ListaAuditorias.Cast<Auditoria>().ToList();
    }

    public override bool Post(Auditoria entity)
    {
        accesoDatos.ListaAuditorias.Add(entity);
        return true;
    }

    public override bool Put(int id)
    {
        var lista = accesoDatos.ListaAuditorias.Cast<Auditoria>().ToList();
        var encontrado = lista.FirstOrDefault(x => x.IdAuditoria == id);
        if (encontrado != null)
        {
            accesoDatos.ListaAuditorias.Remove(encontrado);
            return true;
        }
        return false;
    }

    public override bool Update(Auditoria entity)
    {
        var lista = accesoDatos.ListaAuditorias.Cast<Auditoria>().ToList();
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].IdAuditoria == entity.IdAuditoria)
            {
                accesoDatos.ListaAuditorias[i] = entity;
                return true;
            }
        }
        return false;
    }
}
