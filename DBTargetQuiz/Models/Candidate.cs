using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBTargetQuiz.Models
{
    [Table("candidate")]
    public class Candidate
    {
        [Key]
        [Column("candidate_id")]
        public int CandidateId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("candidate_name")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("candidate_group")]
        public string Group { get; set; }

        [Column("candidate_age")]
        public int Age { get; set; }

        [Column("candidate_profession")]
        [MaxLength(100)]
        public string Profession { get; set; }

        [Column("candidate_position")]
        [MaxLength(100)]
        public string Position { get; set; }

        [Column("candidate_gov_plan")]
        [MaxLength(200)]
        public string GovPlan { get; set; }

        [Column("candidate_proposal")]
        [MaxLength(200)]
        public string Proposal { get; set; }

        [Column("candidate_picture")]
        [MaxLength(50)]
        public string Picture { get; set; }
    }
}
