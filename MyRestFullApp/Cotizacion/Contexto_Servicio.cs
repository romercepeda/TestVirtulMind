﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Contexto_Servicio
{
    public string Uri { get; set; }
    public ICotizacion ICotizacion { get; set; }


    public void SetCotizacion(ICotizacion _cotizacion)
    {
        ICotizacion = _cotizacion;
    }

    public ICotizacion GetCotizacion()
	{
		return ICotizacion;
	}

	public string Cotizacion()
	{
        return ICotizacion.CotizarMoneda(Uri);
	}

}

