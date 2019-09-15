﻿using System;

public class Articulo
{
    public int id { get; set; }
    public string codigo { get; set; }
    public string nombre { get; set; }
    public string descripcion { get; set; }
    public Marca marca { get; set; }
    public Categoria categoria { get; set; }
    public string imagen { get; set; }
    public decimal precio { get; set; }

    public Articulo() { }

}
