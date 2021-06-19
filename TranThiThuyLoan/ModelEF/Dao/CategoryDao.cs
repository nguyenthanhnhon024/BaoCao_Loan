using ModelEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.Dao
{
    public class CategoryDao
    {
        TranThiThuyLoanContext db=null ;
        public CategoryDao()
        {
            db = new TranThiThuyLoanContext();

        }

        public List<Category> ListAllCa()
        {
            return db.Categories.ToList();
        }
    }
}
