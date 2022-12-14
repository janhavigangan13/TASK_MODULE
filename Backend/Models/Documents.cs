using System.ComponentModel.DataAnnotations;
using System;

namespace backend.Models
{
    public class Documents
    {
        [Key]
        public int DocumentId { get; set; }

        public string DocumentName { get; set; }

        public string Extension { get; set; }

        public string ContentType { get; set; }

        public byte[] FileData { get; set; }

        public int FileSize { get; set; }

        public DateTime UploadDate { get; set; }

        public string DocumentType { get; set; }
    }
}
