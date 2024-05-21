namespace OnDemandTutorApi.DataAccessLayer.Entity
{
    public class Student
    {
        public string StudentId { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
