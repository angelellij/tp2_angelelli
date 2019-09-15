using System;

public class Marca
{
    public int id { get; set; }
    public string descripcion { get; set; }

    public Marca()
	{
        
    }

    public override string ToString()
    {
        return descripcion;
    }
}
