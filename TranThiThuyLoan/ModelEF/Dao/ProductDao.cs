using ModelEF.Model;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.Dao
{
    public class ProductDao
    {
        private TranThiThuyLoanContext db;
        public ProductDao()
        {
            db = new TranThiThuyLoanContext();
        }
        public List<Product> ListAllPro()
        {
            return db.Products.OrderBy(x => x.Quantity).ThenByDescending(x => x.UnitCost).ToList();
        }
        public Product FindPro(int? id)
        {

            return db.Products.Find(id);
        }
        public IEnumerable<Product> ListWhereAllPro(string keysearch, int page, int pagesize)
        {
            IQueryable<Product> model = db.Products;
            if (!string.IsNullOrEmpty(keysearch))
            { 
                model = model.Where(x => x.Name.Contains(keysearch));
            }
            return model.OrderBy(x => x.Name).ToPagedList(page, pagesize);
        }
        

        public long Insert(Product entityPro)
        {
            db.Products.Add(entityPro);
            db.SaveChanges();
            return entityPro.ID;
        }

    }
}
