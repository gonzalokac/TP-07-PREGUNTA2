using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_07_PREGUNTA2.Models;

namespace TP_07_PREGUNTA2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Configurarjuego()
    {
        return View();
       
    }
    public IActionResult Jugar()
    {
        return View();
    }
    
public IActionResult Comenzar(string username, int dificultad, int categoria)
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    public IActionResult VerificarRespuesta(int idPregunta, int idRespuesta)
    {
       
        bool esCorrecta = _juego.VerificarRespuesta(idPregunta, idRespuesta);
        
        // Obtén la respuesta correcta para la pregunta (esto depende de cómo esté implementado tu método)
        var respuestaCorrecta = _juego.ObtenerRespuestaCorrecta(idPregunta);
        
        // Usa ViewBag para enviar la información a la vista
        ViewBag.EsCorrecta = esCorrecta;
        ViewBag.RespuestaCorrecta = respuestaCorrecta;

        // Retorna la vista Respuesta
        return View("Respuesta");}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
