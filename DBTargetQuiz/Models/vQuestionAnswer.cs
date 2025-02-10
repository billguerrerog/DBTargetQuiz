using System.ComponentModel.DataAnnotations.Schema;

namespace DBTargetQuiz.Models
{
    [Table("vQuestionAnswer")]
    public class QuestionAnswerView
    {
        [Column("question_id")]
        public int QuestionId { get; set; }

        [Column("question_desc")]
        public string QuestionDescription { get; set; }

        [Column("question_picture")]
        public string QuestionPicture { get; set; }

        [Column("answer_id")]
        public int AnswerId { get; set; }

        [Column("answer_desc")]
        public string AnswerDescription { get; set; }
    }
}
