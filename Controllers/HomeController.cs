using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TP1_ArmandoClaudio.Models;

namespace TP1_ArmandoClaudio.Controllers
{
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

		public IActionResult Privacy()
		{
			return View();
		}

		public double Problema1(int a)
		{
			int cuadrado;
			try
			{
				cuadrado = a * a;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message + "\n");
				cuadrado = 0;
			}
			
			return cuadrado;
		}

		public double Problema2(int a,int b)
		{
			int division;
			try
			{
				division = a / b;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message + "\n");
				division = 0;
			}

			return division;
		}

		public string Problema3()
		{
			int KMxLitro;
			try
			{
				KMxLitro = a / b;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message + "\n");
				KMxLitro = 0;
			}
			String mensaje = "Se recorre " + KMxLitro + " kilometros por cada litro.";

			return mensaje;
		}


		public string Problema4(int a, int b)
		{
			int KMxLitro;
			try
			{
				KMxLitro = a / b;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message + "\n");
				KMxLitro = 0;
			}
			String mensaje = "Se recorre " + KMxLitro + " kilometros por cada litro.";

			return mensaje;
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
