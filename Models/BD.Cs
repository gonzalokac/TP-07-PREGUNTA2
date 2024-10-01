namespace TP_07_PREGUNTA2.Models;

using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;


public static class BD{
 private static string _connectionString = @"Server=DESKTOP-QL7CVVP\SQLEXPRESS; DataBase=PreguntadOrt; Trusted_Connection=True;";
 public static void ObtenerCategorias(){
    List<Categoria> Lcategoria=new List<Categoria>();
    using(SqlConnection db= new SqlConnection(_connectionString)){
        string sql= "SELECT * FROM Categorias ";
        Lcategoria=db.Query<Categoria>(sql).ToList();

    }
 }
 public static void ObtenerDificultades(){
	List<Dificultad>LDificultad=new List<Dificultad>();
	using(SqlConnection db= new SqlConnection(_connectionString)){
		string sql= "SELECT * FROM Dificultades ";
		LDificultad=db.Query<Dificultad>(sql).ToList();

	}
}

public static List<Pregunta> ObtenerPreguntas(int dificultad, int categoria ){
    using SqlConnection db = new SqlConnection(_connectionString);
    List<Pregunta> LPregunta = new List<Pregunta>();

    if(dificultad == -1 && categoria == -1) LPregunta=db.Query<Pregunta>("SELECT * FROM Preguntas").ToList();
    else if(dificultad == -1) LPregunta=db.Query<Pregunta>("SELECT * FROM Preguntas WHERE idCategoria=@pcategoria", new{pcategoria=categoria}).ToList();
    else if (categoria == -1) LPregunta=db.Query<Pregunta>("SELECT * FROM Preguntas WHERE idDificultad=@pdificultad", new{pdificultad=dificultad}).ToList();
    else LPregunta=db.Query<Pregunta>("SELECT * FROM Preguntas WHERE idDificultad=@pdificultad AND idCategoria=@pcategoria", new{pdificultad=dificultad,pcategoria=categoria}).ToList();


    return LPregunta;
}

 public static List<Respuesta> ObtenerRespuestas(List<Pregunta> LPregunta){
 List<Respuesta>LRespuesta=new List<Respuesta>();
 List<Respuesta>LRespuestaFinal=new List<Respuesta>();
  string sql="";
  using(SqlConnection db= new SqlConnection(_connectionString)){
    foreach(var pregunta in LPregunta){
        sql= "SELECT * FROM Respuestas WHERE idPregunta= " + pregunta.idPregunta;
        // hay que ejecurar el sql y hacer el to list a la lista de RESPUESTAS
        LRespuesta=db.Query<Respuesta>(sql).ToList();

        LRespuestaFinal.AddRange(LRespuesta);

    }
  }
  return LRespuesta;
 }

	public static List<Respuesta> ObtenerRespuestaXId(int idPregunta){
		using SqlConnection db= new SqlConnection(_connectionString);
		var a = db.Query<Respuesta>("SELECT * FROM Respuestas WHERE IdPregunta=@pidPregunta", new{pidPregunta=idPregunta}).ToList();
		return a;
	}
}