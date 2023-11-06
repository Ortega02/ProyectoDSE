using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using System.Data;
using System.Net;
using System.Security;
using MySql.Data.MySqlClient;
using System.Configuration;
using ObservatorioBodega.Models;


public class AutenticacionController : Controller
{
    private IDbConnection Connection
    {
        get
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return new MySqlConnection(connectionString);
        }
    }

    public ActionResult IniciarSesion()
    {
        return View();
    }

    [HttpPost]
    public ActionResult IniciarSesion(UsuarioModel usuario)
    {
        if (ModelState.IsValid)
        {
            if (ValidarUsuario(usuario.Usuario, usuario.Contrasena))
            {
                Session["Usuario"] = usuario.Usuario;
                return RedirectToAction("Index", "Documentos");
            }
            else
            {
                ModelState.AddModelError("", "Nombre de usuario o contraseña incorrectos");
            }
        }
        return View(usuario);
    }

    private bool ValidarUsuario(string Usuario, string contrasena)
    {
        using (IDbConnection dbConnection = Connection)
        {
            Connection.Open();
            var query = "SELECT * FROM Colaboradores WHERE Usuario = @NombreUsuario AND Contrasena = @Contrasena";
            var colaborador = Connection.QueryFirstOrDefault<UsuarioModel>(query, new { Usuario = Usuario, Contrasena = contrasena });

            if (colaborador != null)
            {
                return true;
            }
            else
            {
                // Intenta buscar en la tabla de administradores
                query = "SELECT * FROM Administradores WHERE Usuario = @NombreUsuario AND Contrasena = @Contrasena";
                var administrador = Connection.QueryFirstOrDefault<UsuarioModel>(query, new { Usuario = Usuario, Contrasena = contrasena });

                return administrador != null;
            }
        }
    }
}
