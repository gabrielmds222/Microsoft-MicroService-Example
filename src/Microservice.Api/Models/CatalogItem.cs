using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft_MicroService_Example.src.Microservice.Api.Models
{
    public class CatalogItem
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public decimal Price {get; set;}
        public string PictureFileName {get; set;}
        public string PictureUri {get; set;}
        public int CatalogTypeId {get; set;}
        public CatalogType CatalogType {get; set;}
        public int CatalogBrandIt {get; set;}
        public int AvaibleStock {get; set;}
        public int RestockThreshould {get; set;}
        public int MaxStockThreshould {get; set;}

        public bool OnReorder {get; set;}
        public CatalogItem() {
            
        }
    }
}