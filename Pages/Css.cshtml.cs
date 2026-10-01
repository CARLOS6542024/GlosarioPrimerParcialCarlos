
using GlosarioPrimerParcialCarlos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace GlosarioPrimerParcialCarlos.Pages
{
    public class CssModel : PageModel
    {
        public static List<Termino> GlosarioCss { get; set; } = new List<Termino>();

        public void OnGet()
        {
            if (GlosarioCss.Count == 0)
            {
                GlosarioCss.Add(new Termino { Palabra = "flexbox", Definicion = "Modelo de diseño unidimensional para distribuir espacio entre elementos en una interfaz." });
                GlosarioCss.Add(new Termino { Palabra = "grid", Definicion = "Sistema de diseño bidimensional basado en filas y columnas para crear maquetas complejas." });
                GlosarioCss.Add(new Termino { Palabra = "color", Definicion = "Propiedad utilizada para establecer el color de primer plano del texto de un elemento." });
            }
        }

        public IActionResult OnPost(string nuevaPalabra, string nuevaDefinicion)
        {
            if (!string.IsNullOrEmpty(nuevaPalabra) && !string.IsNullOrEmpty(nuevaDefinicion))
            {
                GlosarioCss.Add(new Termino
                {
                    Palabra = nuevaPalabra,
                    Definicion = nuevaDefinicion
                });
            }

            return RedirectToPage("/Css");
        }
    }
}
