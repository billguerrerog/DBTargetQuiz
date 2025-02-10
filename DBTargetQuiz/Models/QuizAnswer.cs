using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBTargetQuiz.Models
{
    [Table("quiz_answer")]
    public class QuizAnswer
    {
        [Key]
        [Column("quiz_id")]
        public int QuizId { get; set; }

        [Key]
        [Column("question_id")]
        public int QuestionId { get; set; }

        [Column("answer_id")]
        public int AnswerId { get; set; }

        [ForeignKey("QuizId")]
        public Quiz Quiz { get; set; }

        [ForeignKey("QuestionId")]
        public Question Question { get; set; }

        [ForeignKey("AnswerId")]
        public Answer Answer { get; set; }
    }
}
