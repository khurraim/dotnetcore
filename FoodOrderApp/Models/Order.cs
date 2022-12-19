using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodOrderApp.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [DisplayName("Orderer Name")]
        public string OrderName { get; set; }

        [DisplayName("Orderer Address")]
        public string OrderAdress { get; set; }

        [DisplayName("Orderer Phone")]
        public int OrderPhone { get; set; }

        [DisplayName("Orderer Item")]
        public string OrderItem { get; set; }


    }
}
