﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDesarrollo.Controllers
{
    public class AgregarController : Controller
    {
        //
        // GET: /Agregar/

        public ActionResult Index(int idVideo, string titulo, int reproducciones, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("INSERT INTO video " + "VALUES(@idVideo,@titulo," + "@reproducciones,@url)", CommandType.Text, parametros);
            return View("VideSubido"); 
            */
            return View();
        }

    }
}
