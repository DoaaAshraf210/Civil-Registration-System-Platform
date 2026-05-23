namespace Civil_Registration_System_Platform.Models
{
    public class Application
    {
        [Key]
        public int ApplicationId { get; set; }
        [StringLength(20, MinimumLength = 4)]
        public string ApplicationNumber { get; set; }    
        public int ServiceType { get; set; }   
        public int? ApplicationType { get; set; }    
        public int Status { get; set; }  
        [MaxLength(300)]
        public string? Note { get; set; }  
        public DateTime CreatedAt { get; set; }  
        public DateTime? UpdatedAt { get; set; }  
        public DateTime? ReviewedAt { get; set; }  


        // Foreign keys

        public int OfficeId { get; set; }
        public Office Office { get; set; } 


        public string UserAccountId { get; set; } 
        public UserAccount UserAccount { get; set; } 

        public string? ReviewedById { get; set; } 
        public UserAccount? ReviewedUserAccount { get; set; } 


        public List<ApplicationDocuments>? ApplicationDocuments { get; set; } 
        public List<Appointment>? Appointments { get; set; } 
        public List<TimelineEntry>? TimelineEntries { get; set; } 


        public bool IsDeleted { get; set; } 

    }
}
