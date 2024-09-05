namespace TP_07_PREGUNTA2.Models;

using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;


public static class BD{
 private static string _connectionString = @"Server=localhost; DataBase=PreguntadOrt; Trusted_Connection=True;";
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
 public static void ObtenerPreguntas(int dificultad, int categoria ){
   List<Pregunta>LPregunta=new List<Pregunta>();
   string sql="";
    using(SqlConnection db= new SqlConnection(_connectionString)){
        if(dificultad==-1){sql= "SELECT * FROM  Preguntas  WHERE idCategoria=" + categoria;}
        else if (categoria==-1){sql= "SELECT * FROM  Preguntas WHERE idDificultad= " + dificultad;}
        else {sql= "SELECT * FROM  Preguntas WHERE idDificultad= " + dificultad + "AND idCategoria=" + categoria;}
        LPregunta=db.Query<Pregunta>(sql).ToList();





 }
 }
 public static List<Respuesta> ObtenerRespuestas(List<Pregunta> LPregunta){
 List<Respuesta>LRespuesta=new List<Respuesta>();
  string sql="";
  using(SqlConnection db= new SqlConnection(_connectionString)){
    foreach(var pregunta in LPregunta){
        sql= "SELECT * FROM Respuestas WHERE idPregunta= " + pregunta.idPregunta;
        // hay que ejecurar el sql y hacer el to list a la lista de RESPUESTAS
        LRespuesta=db.Query<Respuesta>(sql).ToList();
        LRespuesta.AddRange(sql);

    }
              LRespuesta=db.Query<Respuesta>(sql).ToList();
  }
  return LRespuesta;
 }
 }