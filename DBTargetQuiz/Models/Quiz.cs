using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBTargetQuiz.Models
{
    [Table("quiz")]
    public class Quiz
    {
        [Key]
        [Column("quiz_id")]
        public int QuizId { get; set; }

        [Required]
        [MaxLength(10)]
        [Column("quiz_code")]
        public string Code { get; set; }

        [Column("quiz_date")]
        public DateTime Date { get; set; }

        [MaxLength(50)]
        [Column("quiz_client_ip")]
        public string? ClientIp { get; set; }

        [Column("quiz_status")]
        public short Status { get; set; }

        [Column("candidate1_id")]
        public int? Candidate1Id { get; set; }

        [Column("candidate2_id")]
        public int? Candidate2Id { get; set; }

        [Column("candidate3_id")]
        public int? Candidate3Id { get; set; }

        [Column("candidate4_id")]
        public int? Candidate4Id { get; set; }

        [Column("candidate5_id")]
        public int? Candidate5Id { get; set; }

        [Column("candidate1_percent")]
        public short? Candidate1Percent { get; set; }

        [Column("candidate2_percent")]
        public short? Candidate2Percent { get; set; }

        [Column("candidate3_percent")]
        public short? Candidate3Percent { get; set; }

        [Column("candidate4_percent")]
        public short? Candidate4Percent { get; set; }

        [Column("candidate5_percent")]
        public short? Candidate5Percent { get; set; }

        public ICollection<QuizAnswer> QuizAnswers { get; set; }
    }
}
