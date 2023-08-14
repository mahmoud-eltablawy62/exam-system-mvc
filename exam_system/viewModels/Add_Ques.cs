﻿using exam_system.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace exam_system.viewModels
{
    public class Add_Ques
    { 
        public int Id { get; set; }
        public string head { get; set; }
        public string body { get; set; }
        public string answer { get; set; }

        [ForeignKey("Ins")]
        public int ins_id { get; set; } 
        public Instractor Ins { get; set; } 
    }
}