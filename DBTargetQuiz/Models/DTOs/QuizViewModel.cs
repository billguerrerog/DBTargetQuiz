namespace DBTargetQuiz.Models.DTOs
{
    public class QuizViewModel
    {
        public int QuestionId { get; set; }
        public string QuestionDescription { get; set; }
        public string? QuestionPicture { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();
    }
}
