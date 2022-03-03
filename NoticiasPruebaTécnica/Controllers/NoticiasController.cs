using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NoticiasPruebaTécnica.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasPruebaTécnica.Controllers
{
    public class NoticiasController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly pruebaTecnicaContext _context;
        public NoticiasController(IWebHostEnvironment env,pruebaTecnicaContext context)
        {

            _env = env;
            _context = context;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Locales()
        {
            return View();
        }


        public IActionResult Remotas()
        {
            return View();
        }


        public IActionResult BackEnd()
        {
            return View();
        }


        public IActionResult Noticias()
        {
            return View();
        }



        public async Task<ActionResult> noticiasLocales()
        {
            try
            {

                List<Noticias> noticia = new List<Noticias>();
                Noticias notObjeto= new Noticias();

                notObjeto.titulo = "How leaders in the workplace can make space for mental health";
                notObjeto.hora = "23:30 pm";
                notObjeto.contenido = "Because employees may feel uncomfortable reaching …s into her job at Toronto-based";
                notObjeto.imagen = "https://www.cheatsheet.com/wp-content/uploads/2022/02/Mrs.-Maisel-3.jpg";
                noticia.Add(notObjeto);

                notObjeto.titulo = "How leaders in the workplace can make space for mental health";
                notObjeto.hora = "23:30 pm";
                notObjeto.contenido = "Because employees may feel uncomfortable reaching …s into her job at Toronto-based";
                notObjeto.imagen = "https://www.cheatsheet.com/wp-content/uploads/2022/02/Mrs.-Maisel-3.jpg";
                noticia.Add(notObjeto);

                notObjeto.titulo = "How leaders in the workplace can make space for mental health";
                notObjeto.hora = "23:30 pm";
                notObjeto.contenido = "Because employees may feel uncomfortable reaching …s into her job at Toronto-based";
                notObjeto.imagen = "https://www.cheatsheet.com/wp-content/uploads/2022/02/Mrs.-Maisel-3.jpg";
                noticia.Add(notObjeto);

                notObjeto.titulo = "How leaders in the workplace can make space for mental health";
                notObjeto.hora = "23:30 pm";
                notObjeto.contenido = "Because employees may feel uncomfortable reaching …s into her job at Toronto-based";
                notObjeto.imagen = "https://www.cheatsheet.com/wp-content/uploads/2022/02/Mrs.-Maisel-3.jpg";
                noticia.Add(notObjeto);

                notObjeto.titulo = "How leaders in the workplace can make space for mental health";
                notObjeto.hora = "23:30 pm";
                notObjeto.contenido = "Because employees may feel uncomfortable reaching …s into her job at Toronto-based";
                notObjeto.imagen = "https://www.cheatsheet.com/wp-content/uploads/2022/02/Mrs.-Maisel-3.jpg";
                noticia.Add(notObjeto);

                notObjeto.titulo = "How leaders in the workplace can make space for mental health";
                notObjeto.hora = "23:30 pm";
                notObjeto.contenido = "Because employees may feel uncomfortable reaching …s into her job at Toronto-based";
                notObjeto.imagen = "https://www.cheatsheet.com/wp-content/uploads/2022/02/Mrs.-Maisel-3.jpg";
                noticia.Add(notObjeto);


                notObjeto.titulo = "How leaders in the workplace can make space for mental health";
                notObjeto.hora = "23:30 pm";
                notObjeto.contenido = "Because employees may feel uncomfortable reaching …s into her job at Toronto-based";
                notObjeto.imagen = "https://www.cheatsheet.com/wp-content/uploads/2022/02/Mrs.-Maisel-3.jpg";
                noticia.Add(notObjeto);


                notObjeto.titulo = "How leaders in the workplace can make space for mental health";
                notObjeto.hora = "23:30 pm";
                notObjeto.contenido = "Because employees may feel uncomfortable reaching …s into her job at Toronto-based";
                notObjeto.imagen = "https://www.cheatsheet.com/wp-content/uploads/2022/02/Mrs.-Maisel-3.jpg";
                noticia.Add(notObjeto);

 
                return Ok(noticia);
            }
            catch (System.Exception)
            {

                throw;
            }



        }


        public async Task<string> registrar(NoticiasEventos noticiasEventos, IFormFile archivo)
        {
            try
            {
                noticiasEventos.Hora = DateTime.Now;
                _context.NoticiasEventos.Add(noticiasEventos);
                _context.SaveChanges();
                var root = _env.WebRootPath;
                var vec = archivo.FileName.Split('.');
                var ext =  vec[vec.Length - 1];
                var nombreFinal = $"{noticiasEventos.IdNoticia}.{ext}";
                var pathParcial = "System/Recursos/Imagenes/";
                var pathDirectory = $@"{root}/{pathParcial}";
                Directory.CreateDirectory(pathParcial);
                var pathFinal = $@"{pathDirectory}{nombreFinal}";
                var pathDb = $"{pathParcial}{nombreFinal}";
                var fs = new FileStream(pathFinal, FileMode.Create);
                await archivo.CopyToAsync(fs);
                noticiasEventos.Imagen = pathDb;
                _context.NoticiasEventos.Update(noticiasEventos);
                _context.SaveChanges();
                return "ok";
            }
            catch (System.Exception)
            {

                throw;
            }

        }

        public async Task<ActionResult> noticiasBackEnd()
        {
            try
            {
                var consulta = await _context.NoticiasEventos.ToListAsync();
                return Ok(consulta);


            }
            catch (System.Exception)
            {

                throw;
            }

        }


        }
}
