namespace Civil_Registration_System_Platform.Models
{
    public class ApplicationDocuments
    {
        [Key]
        public int ApplicationDocumentsId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string DocumentPath { get; set; } 
        public DateTime UploadedAt { get; set; } 

        [MaxLength(300)]
        public string? Description { get; set; } 
        public int ApplicationId { get; set; } 
        public Application Application { get; set; } 


        public string UserAccountId { get; set; }

        public bool IsDeleted { get; set; } 
    }
}
