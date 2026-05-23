namespace Civil_Registration_System_Platform.Models
{
    public class TimelineEntry
    {
        [Key]
        public int TimelineEntryId { get; set; }
        
        public int Status { get; set; }   
        public DateTime Timestamp { get; set; } 

        [MaxLength(300)]
        public string? Description { get; set; } 
        public int ApplicationId { get; set; }
        
        public Application Application { get; set; } 

        public string PerformedById { get; set; }        
        public UserAccount PerformedBy { get; set; } 

        public string UserAccountId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
