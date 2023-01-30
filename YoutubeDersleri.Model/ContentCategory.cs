using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ContentCategory : Core.ModelBase
    {

        public ContentCategory(int contentId, int categoryId)
        {
            CategoryId = categoryId;
            ContentId = contentId;
        }

        public int CategoryId { get; set; }
        public int ContentId { get; set; }



    }
}
