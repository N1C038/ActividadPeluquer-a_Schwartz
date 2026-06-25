namespace TurnosPeluqueria_EJ06.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using TurnosPeluqueria_EJ06.Models;


public static class BD
{
    private static string _connectionString =  @"Server=localhost; DataBase=TurnosDB; Integrated Security=true; TrustServerCertificate=true;";

    public static List<Turno> ObtenerTurnos()
    {
         List<Turno> Turnos = new List<Turno>();
     using(SqlConnection conection = new SqlConnection(_connectionString))
        {
        string Query1 = "SELECT * FROM Turnos ORDER BY FechaHora";
         Turnos = conection.Query<Turno>(Query1).ToList();
        }
    return Turnos;
     } 



     public static void AgregarTurno(Turno t)
    {
    using (SqlConnection BD = new SqlConnection(_connectionString))
    {   
        string Query2 = @"INSERT INTO Turnos (NombreCliente, Servicio, FechaHora, Estado) VALUES(@NombreCliente, @Servicio, @FechaHora, @Estado)";
                
    } 
    }


    

   public static void CambiarEstado(int id, string nuevoEstado)  
{
      using (SqlConnection bd = new SqlConnection(_connectionString))
    {
        string sql = @"UPDATE Turnos
                       SET Estado = @Estado
                       WHERE Id = @Id";

       
    }
}
 
 
}