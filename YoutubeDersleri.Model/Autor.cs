using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Autor : Core.ModelBase
    { 

    public int ContentId { get; set; }
    public string FullName { get; set; }
    public string Mail { get; set; }
    public string Username { get; set; }
    [NotMapped]
    public string Password { get; set; }
    public bool IsActive { get; set; }
    public bool IsDelete { get; set; }
}
}
