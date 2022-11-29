using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSample.Domain.Models
{
    public class Book : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }

        #region Relations
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        #endregion
    }
}
