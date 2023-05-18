using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using amorphie.core.Base;

using amorphie.contract.core.Entity.Common;
using Microsoft.EntityFrameworkCore;
namespace amorphie.contract.core.Entity.Definition
{
    [Index(nameof(Code))]
    [Table("Document", Schema = "Definition")]
    public class DocumentDefinition : EntityBase
    {
        [MaxLength(500)]
        [Description("Kode")]
        [Required]
        public string Code { get; set; }

        [ForeignKey("LanguageId")]
        public virtual Language Language { get; set; }
        public virtual Document Document { get; set; }
        public virtual ICollection<DocumentGroup> DocumentGroups {get;set;}
        public virtual ICollection<DocumentGroupDetail> DocumentGroupDetails {get;set;}
        public virtual ICollection<DocumentType> DocumentTypes { get; set; }
        public virtual ICollection<DocumentTemplate> DocumentTemplates { get; set; }
    }
}