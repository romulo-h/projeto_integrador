using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Base
{
    public class BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool IsActive { get; set; }
        [StringLength(128)]
        public DateTime DtCreate { get; set; }
        [StringLength(128)]
        public DateTime? DtAlter { get; set; }
        [StringLength(128)]
        public DateTime? DtDeleted { get; set; }
    }
}
