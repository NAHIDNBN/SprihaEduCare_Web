using System.ComponentModel.DataAnnotations;

namespace SprihaEduCare_Web.Models
{
    public class QuickTest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string QuestionText { get; set; }

        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }

        public string CorrectAnswer { get; set; }

        public string Part { get; set; }
    }
}
