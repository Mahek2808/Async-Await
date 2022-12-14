using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Async_await_Goals.Model.ViewModel
{
    [Table("CountryTable")]
    public class Country
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCode{ get; set; }
        public string State { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpadteDate { get; set; }
        public string UpdateBy { get; set; }
        public int sss { get; set; }
    }
}
