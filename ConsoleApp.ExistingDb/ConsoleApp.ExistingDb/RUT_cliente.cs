using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.ExistingDb
{
    [Table("RUT_cliente")]
    public class RUT_cliente
    {
        public int ID { get; set; }

        public string rut_dv { get; set; }

        public decimal rut_sdv { get; set; }
    }
}
