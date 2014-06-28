using System.Web.Mvc;
using System.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

using SqualrusBrews.Models;
using System.Collections.Generic;

namespace SqualrusBrews.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new List<BeerViewModel>();
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ConfigurationManager.ConnectionStrings["StorageConnection"].ConnectionString);
            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();
            CloudTable table = tableClient.GetTableReference("brews");

            TableQuery<BeerEntity> query = new TableQuery<BeerEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, "brew"));

            foreach (BeerEntity entity in table.ExecuteQuery(query)) {
                viewModel.Add(new BeerViewModel
                {
                    Name = entity.Name
                });
            }

            return View(viewModel);
        }
    }
}