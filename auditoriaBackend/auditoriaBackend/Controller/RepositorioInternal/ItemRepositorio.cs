using System.Collections.Generic;
using System.Linq;

public class ItemRepositorio : BaseRepositorio<Item>
{
    private readonly RepositorioDatos accesoDatos = RepositorioDatos.Instancia;

    public override List<Item> Get()
    {
        // Convertimos de ArrayList a List<Item>
        return accesoDatos.ListaItems.Cast<Item>().ToList();
    }

    public override bool Post(Item entity)
    {
        accesoDatos.ListaItems.Add(entity);
        return true;
    }

    public override bool Put(int id)
    {
        // Borrado analógico (simulando eliminación)
        var lista = accesoDatos.ListaItems.Cast<Item>().ToList();
        var item = lista.FirstOrDefault(x => x.IdItem == id);
        if (item != null)
        {
            accesoDatos.ListaItems.Remove(item);
            return true;
        }
        return false;
    }

    public override bool Update(Item entity)
    {
        var lista = accesoDatos.ListaItems.Cast<Item>().ToList();
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].IdItem == entity.IdItem)
            {
                accesoDatos.ListaItems[i] = entity;
                return true;
            }
        }
        return false;
    }
}
