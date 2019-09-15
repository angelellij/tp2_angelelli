using System;

public class Categoria
{
    public int id { get; set; }
    public string descripcion { get; set; }

    public Categoria()
	{
	}

    public override string ToString()
    {
        return descripcion;
    }
}
