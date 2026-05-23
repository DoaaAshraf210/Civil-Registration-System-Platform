namespace Civil_Registration_System_Platform.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int Status { get; set; }
        [MaxLength(300)]
        public string? Note { get; set; }   

        public int ApplicationId { get; set; } 
        public Application Application { get; set; } 

        public string ScheduledById { get; set; } 
        public UserAccount ScheduledBy { get; set; } 

        public string UserAccountId { get; set; }
        public bool IsDeleted { get; set; } 

    }
}
