using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBTargetQuiz.Models
{
    [Table("question")]
    public class Question
    {
        [Key]
        [Column("question_id")]
        public int QuestionId { get; set; }

        [Required]
        [MaxLength(500)]
        [Column("question_desc")]
        public string Description { get; set; }

        [Column("question_order")]
        public int Order { get; set; }

        [Column("question_picture")]
        [MaxLength(50)]
        public string Picture { get; set; }

        [Column("question_points")]
        public int Points { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}