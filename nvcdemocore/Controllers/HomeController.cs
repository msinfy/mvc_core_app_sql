using Microsoft.AspNetCore.Mvc;
using nvcdemocore.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace nvcdemocore.Controllers
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

            using (SqlConnection con = new SqlConnection())
            {
                //  String sql = @"select * from publisher";

                String sql = @"insert into publisher values('sssssssss','mmmmmmmmm')";
                // con.ConnectionString = @"Server=comp1630.database.windows.net;Database=pubs;User Id=readonlylogin;Password=;";
                // con.ConnectionString = @"Data Source = 20.85.189.169; Initial Catalog = shafi; User ID = sa; Password = @Aa123456";
                con.ConnectionString = @"Server=tcp:shafiserver.database.windows.net,1433;Initial Catalog=shafi;Persist Security Info=False;User ID=shafi;Password=afi@1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
               // da.SelectCommand = new SqlCommand(sql, con);
              // da.InsertCommand = new SqlCommand(sql, con);
               //da.AcceptChangesDuringFill = true;
               
             //   da.Fill(dt);

                //foreach (DataRow row in dt.Rows)
                //{
                //    var pub = new Models.Publisher();
                //    pub.Name = row["name"].ToString();
                //    pub.City = row["city"].ToString();

                //    List.Add(pub);
                //}
            }




            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}