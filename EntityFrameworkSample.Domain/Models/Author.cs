using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSample.Domain.Models
{
    public class Author : BaseModel
    {
        public string FullName { get; set; }

        #region Relations
        public virtual ICollection<Book> Books { get; set; }
        #endregion
    }
}
