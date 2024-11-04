using Microsoft.AspNetCore.Mvc;
using OdontoGendaC.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdontoGendaC.Controllers
{
    public class ConsultaController : Controller
    {
        private static List<Consulta> consultas = new List<Consulta>(); // Lista temporária para simular um banco de dados

        public IActionResult Index()
        {
            return View(consultas); // Exibe todas as consultas
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Consulta consulta)
        {
            consultas.Add(consulta);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var consulta = consultas.FirstOrDefault(c => c.Id == id);
            if (consulta == null)
                return NotFound();
            return View(consulta);
        }

        [HttpPost]
        public IActionResult Edit(Consulta consulta)
        {
            var consultaExistente = consultas.FirstOrDefault(c => c.Id == consulta.Id);
            if (consultaExistente != null)
            {
                consultaExistente.NomePaciente = consulta.NomePaciente;
                consultaExistente.Dentista = consulta.Dentista;
                consultaExistente.DataConsulta = consulta.DataConsulta;
                consultaExistente.Horario = consulta.Horario;
                consultaExistente.Observacoes = consulta.Observacoes;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var consulta = consultas.FirstOrDefault(c => c.Id == id);
            if (consulta == null)
                return NotFound();
            return View(consulta);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var consulta = consultas.FirstOrDefault(c => c.Id == id);
            if (consulta != null)
                consultas.Remove(consulta);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var consulta = consultas.FirstOrDefault(c => c.Id == id);
            if (consulta == null)
                return NotFound();
            return View(consulta);
        }
    }
}
