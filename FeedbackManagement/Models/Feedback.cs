using System.ComponentModel.DataAnnotations;

namespace FeedbackManagemant.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string EnrollmentNo { get; set; }
        public string StudentName { get; set; }
        public string Subject { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
    }
}