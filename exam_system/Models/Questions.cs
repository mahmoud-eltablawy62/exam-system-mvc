﻿using System.ComponentModel.DataAnnotations.Schema;

namespace exam_system.Models
{
    public class Questions
    {
        public int Id { get; set; }
        public string head { get; set; }
        public string body { get; set; }
        public string answer { get; set; }
        public string? answer_stud { get; set; }

        [ForeignKey("Ins")]
        public int? ins_id { get; set; }
        public Instractor? Ins { get; set; }

    }
}
