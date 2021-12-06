using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using System.Collections;

namespace lab15.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        private SchoolEntities _Contexto;

        public SchoolEntities Contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new SchoolEntities();
                return _conexto;
            }
        }
        public ActionResult Index()
        {
            return View(Contexto.Person.ToList());
        }
        [HttpPost]
        public ActionResult Reporte(string FirstName)
        {
            List<Person> listado = new List<Person>();
            listado = Contexto.Person.ToList();

            var rptviewer = new ReportViewer();
            rptviewer.ProcessingMode = ProcessingMode.Local;
            rptviewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) +
                @"Reporte.rdlc";

            ReportDataSource rptdatasurce = new ReportDataSource("dsPersona", listado);
            rptviewer.LocalReport.DataSources.Add(rptdatasource);
            rptviewer.SizeToReportContent = true;

            ViewBag.ReportViewer = rptviewer;
            return View();
        }
        public  ActionResult Graficos()
        {
            return View();
        }
        public ActionResult GraficoColumnas()
        {
            ArrayList x = new ArrayList();
            ArrayList y = new ArrayList();
            var query = (from c in Contexto.Course select c);
            query.ToList().ForEach(r => x.Add(r.Title));
            query.ToList().ForEach(r => y.Add(r.Credits));
            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
                .AddTitle("Columnas")
                .AddSeries("Default", chartType: "Column", xValue: x, yValues: y)
                .Write("bmp");
            return null;
        }
        public ActionResult GraficoBarras()
        {
            ArrayList x = new ArrayList();
            ArrayList y = new ArrayList();
            var query = (from c in Contexto.Course select c);
            query.ToList().ForEach(r => x.Add(r.Title));
            query.ToList().ForEach(r => y.Add(r.Credits));
            new Chart(width: 600, height: 400, theme: ChartTheme.Vanilla3D)
                .AddTitle("Grafico de Barras")
                .AddSeries("Default", chartType: "Bar", xValue: x, yValues: y)
                .Write("bmp");
            return null;
        }
        public ActionResult GraficoTarta()
        {
            ArrayList x = new ArrayList();
            ArrayList y = new ArrayList();
            var query = (from c in Contexto.Course select c);
            query.ToList().ForEach(r => x.Add(r.Title));
            query.ToList().ForEach(r => y.Add(r.Credits));
            new Chart(width: 600, height: 400, theme: ChartTheme.Blue)
                .AddTitle("Pie")
                .AddSeries("Default", chartType: "Pie", xValue: x, yValues: y)
                .Write("bmp");
            return null;
        }
        public ActionResult GraficoRadar()
        {
            ArrayList x = new ArrayList();
            ArrayList y = new ArrayList();
            var query = (from c in Contexto.Course select c);
            query.ToList().ForEach(r => x.Add(r.Title));
            query.ToList().ForEach(r => y.Add(r.Credits));
            new Chart(width: 600, height: 400, theme: ChartTheme.Yellow)
                .AddTitle("Radar")
                .AddSeries("Default", chartType: "Radar", xValue: x, yValues: y)
                .Write("bmp");
            return null;
        }

    }
}