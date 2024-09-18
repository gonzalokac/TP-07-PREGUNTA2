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
         List<Respuesta> LRespuestaPregunta=new List<Respuesta>();
        Pregunta pregunta=Juego.ObtenerProximaPregunta();
        if(pregunta!=null){
        ViewBag.Pregunta=pregunta;
        LRespuestaPregunta=Juego.ObtenerProximasRespuestas(pregunta.idPregunta);
        ViewBag.LRespuestaPregunta=LRespuestaPregunta;
        return JUEGO();
    } else{
        return Fin();
    }
    
    
    }
    /* se hace algo en controller juego? */
       public IActionResult JUEGO()
    {
        return View();
    }
    
public IActionResult Comenzar(string username, int dificultad, int categoria)
    { bool check;
        check=Juego.CargarPartida( username,  dificultad,  categoria);
        if(check==true){
            return Jugar();
        }else{
            return Configurarjuego();
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }
       public IActionResult Fin()
    {
        return View();
    }

    [HttpPost]
    public IActionResult VerificarRespuesta(int idPregunta, int idRespuesta)
    {
      Respuesta respuestaCorrecta= new Respuesta();
        bool esCorrecta = Juego.VerificarRespuesta(idPregunta, idRespuesta);
           
        respuestaCorrecta.idRespuesta = Juego.ObtenerRespuestaCorrecta(idPregunta);
        
        ViewBag.EsCorrecta = esCorrecta;
        ViewBag.RespuestaCorrecta = respuestaCorrecta;

        
       
  
        return View("Respuesta");}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
