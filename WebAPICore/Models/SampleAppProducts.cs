using System;

namespace WebAPI.Models
{
    public class SampleAppProducts
    {
        public int ID { get; set; }
        public string ProdName { get; set; }
        public string ProdDescription { get; set; }
        public decimal Price { get; set; }
        public DateTime RecordDatetime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
