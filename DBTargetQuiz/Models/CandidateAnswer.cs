using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBTargetQuiz.Models
{
    [Table("candidate_answer")]
    [PrimaryKey(nameof(CandidateId), nameof(QuestionId))]
    public class CandidateAnswer
    {
        [Key]
        [Column("candidate_id")]
        public int CandidateId { get; set; }

        [Key]
        [Column("question_id")]
        public int QuestionId { get; set; }

        [Column("answer_id")]
        public int AnswerId { get; set; }

        [ForeignKey("CandidateId")]
        public Candidate Candidate { get; set; }

        [ForeignKey("QuestionId")]
        public Question Question { get; set; }

        [ForeignKey("AnswerId")]
        public Answer Answer { get; set; }
    }
}
