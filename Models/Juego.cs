using TP_07_PREGUNTA2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class Juego
{
    static string NombreUsuario { get; set; }
    static int PuntajeActual { get; set; }
    static int CantidadPreguntasCorrectas { get; set; }
    static List<Pregunta> Preguntas { get; set; }
    static List<Respuesta> Respuestas { get; set; }

    public Juego()
    { InicializarJuego();
    }

    public void InicializarJuego()
    {
        NombreUsuario = "";
        PuntajeActual = 0;
        CantidadPreguntasCorrectas = 0;
        Preguntas = new List<Pregunta>();
        Respuestas = new List<Respuesta>();
    }

    public static string ObtenerCategorias(string categoria)
    {
        // Aquí puedes tener lógica para procesar categorías si es necesario
        return categoria;
    }

    public static string ObtenerDificultades(string dificultad)
    {
        // Aquí puedes tener lógica para procesar dificultades si es necesario
        return dificultad;
    }

    public static string CargarPartida(string nombreUsuario, int dificultad, int categoria)
    {
        NombreUsuario = nombreUsuario;
        // Aquí debes implementar la lógica para cargar la partida con dificultad y categoría
        // Por ejemplo: recuperar preguntas y respuestas de una base de datos según dificultad y categoría
        return NombreUsuario;
    }

    public Pregunta ObtenerProximaPregunta()
    {
        // Implementa la lógica para obtener la siguiente pregunta. Ejemplo: devolver la primera pregunta y luego eliminarla.
        if (Preguntas.Count > 0)
        {
            return Preguntas.First();
        }
        return null;
    }

    public List<Respuesta> ObtenerProximasRespuestas(int idPregunta)
    {
        // Asegúrate de que BD.ObtenerRespuestas esté implementado correctamente
        // y devuelva respuestas relacionadas con el idPregunta
        return BD.ObtenerRespuestas(idPregunta);
    }

    public bool VerificarRespuesta(int idPregunta, int idRespuesta)
    {
        Respuesta respuestaCorrecta = ObtenerRespuestaCorrecta(idPregunta);
        if (respuestaCorrecta != null && respuestaCorrecta.Id == idRespuesta)
        {
            PuntajeActual += 1;
            CantidadPreguntasCorrectas += 1;
            Preguntas.RemoveAll(p => p.Id == idPregunta); // Remover la pregunta correctamente
            return true;
        }
        return false;
    }

    public Respuesta ObtenerRespuestaCorrecta(int idPregunta)
    {
        // Asegúrate de que BD.ObtenerRespuestas esté implementado y devuelva respuestas correctas
        List<Respuesta> respuestas = BD.ObtenerRespuestas(idPregunta);
        return respuestas.FirstOrDefault(r => r.Correcta);
    }
}
