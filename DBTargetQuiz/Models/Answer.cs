using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBTargetQuiz.Models
{
    [Table("answer")]
    public class Answer
    {
        [Key]
        [Column("answer_id")]
        public int AnswerId { get; set; }

        [Column("question_id")]
        public int QuestionId { get; set; }

        [Required]
        [MaxLength(250)]
        [Column("answer_desc")]
        public string Description { get; set; }

        [Column("answer_order")]
        public int Order { get; set; }

        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
    }
}