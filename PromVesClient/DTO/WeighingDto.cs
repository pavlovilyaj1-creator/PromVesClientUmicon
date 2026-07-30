using System;
using System.Collections.Generic;
using System.Text;

namespace PromVesClient.DTO
{
    public class WeighingDto
    {
        
        public decimal Platform1Left { get; set; }

        public decimal Platform1Right { get; set; } 
        public decimal Platform2Left { get; set; }
        public decimal Platform2Right { get; set; }
        public string VagonNumber { get; set; }
        public decimal TareWeight { get; set; }
        public decimal GrossWeight { get; set; }

        public string TypeWeighing { get; set; }
        public Guid IdReceipt { get; set; }
    }
}
