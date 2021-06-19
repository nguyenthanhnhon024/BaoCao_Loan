using ModelEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.Dao
{
    public class ProcustomDao
    {
        TranThiThuyLoanContext db = null;
        public ProcustomDao()
        {
            db = new TranThiThuyLoanContext();

        }
        public List<Product> ListProKhai()
        {
            return db.Products.Where(x => x.IDCate == 1).ToList();
        }
        public List<Product> ListProBo()
        {
            return db.Products.Where(x => x.IDCate == 3).ToList();
        }
        public List<Product> ListProChuc()
        {
            return db.Products.Where(x => x.IDCate == 4).ToList();
        }
        public List<Product> ListProLe()
        {
            return db.Products.Where(x => x.IDCate == 5).ToList();
        }
    }
}
