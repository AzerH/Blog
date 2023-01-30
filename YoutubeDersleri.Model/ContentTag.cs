using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ContentTag : Core.ModelBase
    {
       
        public ContentTag(int contentId, int tagId)
        {
            TagId= tagId;
            ContentId= contentId;
        }

        public int TagId { get; set; }
        public int ContentId { get; set; }     



    }
}
