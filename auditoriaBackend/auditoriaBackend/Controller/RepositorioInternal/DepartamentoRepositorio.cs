using System.Collections.Generic;
using System.Linq;

public class DepartamentoRepositorio : BaseRepositorio<Departamento>
{
    private readonly RepositorioDatos accesoDatos = RepositorioDatos.Instancia;

    public override List<Departamento> Get()
    {
        return accesoDatos.ListaDepartamentos.Cast<Departamento>().ToList();
    }

    public override bool Post(Departamento entity)
    {
        accesoDatos.ListaDepartamentos.Add(entity);
        return true;
    }

    public override bool Put(int id)
    {
        var lista = accesoDatos.ListaDepartamentos.Cast<Departamento>().ToList();
        var item = lista.FirstOrDefault(x => x.IdDepartamento == id);
        if (item != null)
        {
            accesoDatos.ListaDepartamentos.Remove(item);
            return true;
        }
        return false;
    }

    public override bool Update(Departamento entity)
    {
        var lista = accesoDatos.ListaDepartamentos.Cast<Departamento>().ToList();
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].IdDepartamento == entity.IdDepartamento)
            {
                accesoDatos.ListaDepartamentos[i] = entity;
                return true;
            }
        }
        return false;
    }
}
