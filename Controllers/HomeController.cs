using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_07_PREGUNTA2.Models;

namespace TP_07_PREGUNTA2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) => _logger = logger;
    public IActionResult Index() => View();
    public IActionResult ConfigurarJuego() => View();

    public IActionResult Jugar()
    {
        ViewBag.Pregunta=Juego.ObtenerProximaPregunta();

        if(ViewBag.Pregunta != null){
            ViewBag.LRespuestaPregunta=BD.ObtenerRespuestaXId(ViewBag.Pregunta.idPregunta);
            return View("ViewJuego");
        } else{
            return RedirectToAction("Fin");
        }    
    }
    
    public IActionResult Comenzar(string username, int dificultad, int categoria){
        bool check = Juego.CargarPartida(username, dificultad, categoria);
        ViewBag.username=username;
      
        return RedirectToAction(check ? "Jugar" : "ConfigurarJuego");
    }

    public IActionResult Privacy() => View();

    public IActionResult Fin(){
        ViewBag.puntaje = Juego.puntajeActual;
        return View();
    }
      public IActionResult Creditos(){
        return View();
    }

    [HttpPost]
    public IActionResult VerificarRespuesta(int idPregunta, int idRespuesta)
    {
       
        bool esCorrecta = Juego.VerificarRespuesta(idPregunta, idRespuesta);
        Respuesta? respuestaCorrecta = Juego.ObtenerRespuestaCorrecta(idPregunta);
      
     
        ViewBag.EsCorrecta = esCorrecta;
        ViewBag.RespuestaCorrecta = respuestaCorrecta;
  
        return View("ViewRespuesta");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}
