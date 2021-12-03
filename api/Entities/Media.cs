using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace api.Entities
{
    public class Media : EntityBase
    {
        public string AltText { get; set; }
    
        public byte[] Data { get; set; }
        
        public string ContentType { get; set; }

        public Guid? PostId { get; set; }
        public Post Post { get; set; }
        
        
        public Media(string altText, byte[] data, string contentType)
        {
            AltText = altText;
            Data = data;
            ContentType = contentType;
        }
        
        
    }
}