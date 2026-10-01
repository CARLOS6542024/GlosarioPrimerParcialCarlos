using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using GlosarioPrimerParcialCarlos.Models;

namespace GlosarioPrimerParcialCarlos.Pages
{
    public class CSharpModel : PageModel
    {
        public static List<Termino> GlosarioCSharp { get; set; } = new List<Termino>();

        public void OnGet()
        {
            if (GlosarioCSharp.Count == 0)
            {
                GlosarioCSharp.Add(new Termino { Palabra = "Clase", Definicion = "Plantilla que define la estructura y el comportamiento de un objeto." });
                GlosarioCSharp.Add(new Termino { Palabra = "Encapsulamiento", Definicion = "Principio de la POO que oculta los detalles de implementación interna de una clase." });
                GlosarioCSharp.Add(new Termino { Palabra = "PageModel", Definicion = "Clase en Razor Pages que separa la lógica del backend de la vista HTML." });
            }
        }

        public IActionResult OnPost(string nuevaPalabra, string nuevaDefinicion)
        {
            if (!string.IsNullOrEmpty(nuevaPalabra) && !string.IsNullOrEmpty(nuevaDefinicion))
            {
                GlosarioCSharp.Add(new Termino
                {
                    Palabra = nuevaPalabra,
                    Definicion = nuevaDefinicion
                });
            }

            return RedirectToPage("/CSharp");
        }
    }
}
