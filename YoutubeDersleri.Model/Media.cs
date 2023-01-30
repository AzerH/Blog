using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Media : Core.IngnoredAttribute
    {
        public string Filename { get; set; }
        public string FileSlug { get; set; }
        public string Title { get; set; }
        public string Alt    { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string MediaUrl { get; set; }
    }
}
