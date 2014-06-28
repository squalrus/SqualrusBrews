using Microsoft.WindowsAzure.Storage.Table;

namespace SqualrusBrews.Models
{
    public class BeerEntity : TableEntity
    {
        public BeerEntity(string name)
        {
            this.Name = name;
        }

        public BeerEntity() { }

        public string Name { get; set; }
    }
}