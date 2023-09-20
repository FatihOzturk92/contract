using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using amorphie.contract.core.Entity.Common;
using amorphie.core.Base;

namespace amorphie.contract.core.Entity.Document.DocumentTypes
{
    [Table("DocumentRender", Schema = "DocTp")]
    public class DocumentRender : EntityBase
    {
        // public bool Required { get; set; }//
        public virtual ICollection<DocumentAllowedDetail> DocumentAllowedDetails { get; set; } = new List<DocumentAllowedDetail>();
        public virtual ICollection<DocumentTemplateDetail> DocumentTemplateDetails { get; set; } = new List<DocumentTemplateDetail>();
        public virtual ICollection<DocumentFormIODetail> DocumentFormIODetail { get; set; } = new List<DocumentFormIODetail>();//olmamalı bence bakıcam 
        [Required]
        public Guid VersionsId { get; set; }
        public Versions Versions { get; set; }
    }
}