using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Udaan.Model
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string options { get; set; }
        public int Correct_option { get; set; }
        public int Quiz_Id { get; set; }
        public int Points { get; set; }
       
    }
}
