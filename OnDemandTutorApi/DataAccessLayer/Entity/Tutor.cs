namespace OnDemandTutorApi.DataAccessLayer.Entity
{
    public class Tutor
    {
        public string TutorId { get; set; }
        public string AcademicLevel { get; set; } = null!;
        public string WorkPlace { get; set; } = null!;
        public string OnlineStatus { get; set; } = null!;
        public double AverageStar { get; set; }
        public string Degree { get; set; } = null!;
        public string CreditCard { get; set; } = null!;
        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
