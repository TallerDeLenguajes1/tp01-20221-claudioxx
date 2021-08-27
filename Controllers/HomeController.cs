using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
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

		public IActionResult Problema3()
		{
			var url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
			var request = (HttpWebRequest)WebRequest.Create(url);
			request.Method = "GET";
			request.ContentType = "application/json";
			request.Accept = "application/json";
			List<Provincia> ListProvincias;

			try
			{
				using (WebResponse response = request.GetResponse())
				{
					using (Stream strReader = response.GetResponseStream())
					{
						//if (strReader == null) return "";
						using (StreamReader objReader = new StreamReader(strReader))
						{
							string responseBody = objReader.ReadToEnd();
							ListProvincias = JsonSerializer.Deserialize<ProvinciasArgentinas>(responseBody).Provincias;
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				ListProvincias = null;
			}
			return View(ListProvincias);
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
/*var url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
			var request = (HttpWebRequest)WebRequest.Create(url);
			request.Method = "GET";
			request.ContentType = "application/json";
			request.Accept = "application/json";

			try
			{
				using (WebResponse response = request.GetResponse())
				{
					using (Stream strReader = response.GetResponseStream())
					{
						if (strReader == null) return "";
						using(StreamReader objReader = new StreamReader(strReader))
						{
							string responseBody = objReader.ReadToEnd();
							ProvinciasArgentinas ListProvincias = JsonSerializer.Deserialize<ProvinciasArgentinas>(responseBody);
							foreach (Provincia prov in ListProvincias.Provincias)
							{
								return prov.Nombre;
							}
						}
					}
				}
			}
			catch
			{

			}
*/	