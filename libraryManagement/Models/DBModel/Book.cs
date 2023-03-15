using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace libraryManagement.Models.DBModel
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string BookName { get; set; }
    }
}
