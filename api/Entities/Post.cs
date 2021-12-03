
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.Entities
{
    public class Post : EntityBase
    {   
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        
        [MaxLength(1024)]
        public string Description { get; set; }
        
        [Required]
        public string Content { get; set; }
        
        public Guid? HeaderImageId { get; set; }
        
        [Required]
        public uint Viewed { get; set; } = 0;

        [Required]
        public DateTimeOffset CreatedAt { get; set; }
        
        [Required]
        public DateTimeOffset ModifiedAt { get; set; }
        
        public ICollection<Media> Medias { get; set; }
        
        public ICollection<Comment> Comments { get; set; }

        [Obsolete]
        public Post(){ }

        public Post(string title, string description, string content, ICollection<Media> medias, Guid? headerImageId = null)
        {
            Title = title;
            Description = description;
            Content = content;
            Medias = medias;
            HeaderImageId = headerImageId;

            CreatedAt = DateTimeOffset.UtcNow;
            ModifiedAt = DateTimeOffset.UtcNow;
        }
            
    }

}