using Common;
using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class CategoryDao
    {
        OnlineShopDbContext db = null;
        public CategoryDao()
        {
            db = new OnlineShopDbContext();
        }
        public long Insert(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return category.ID;
        }
        public List<Category> ListAll()
        {
            return db.Categories.Where(x => x.Status == true).ToList();
        }
        public ProductCategory ViewDetail(long id)
        {
            return db.ProductCategories.Find(id);
        }
        public IEnumerable<Category> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<Category> model = db.Categories;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.Name.Contains(searchString) || x.Name.Contains(searchString));
            }

            return model.OrderByDescending(x => x.CreatedDate).ToPagedList(page, pageSize);
        }
        public bool Delete(int id)
        {
            try
            {
                var category = db.Categories.Find(id);
                db.Categories.Remove(category);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Category GetByID(long id)
        {
            return db.Categories.Find(id);
        }

        public bool Update(Category model)
        {
            if (string.IsNullOrEmpty(model.MetaTitle))
            {
                model.MetaTitle = StringHelper.ToUnsignString(model.Name);
            }
            try
            {
                var category = db.Categories.Find(model.ID);
                category.Name = model.Name;
                category.CreatedBy = model.CreatedBy;
                category.CreatedDate = model.CreatedDate;
                category.MetaTitle = model.MetaTitle;
                category.ModifiedBy= model.ModifiedBy;
                category.Status = model.Status;
                category.MetaKeywords = model.MetaKeywords;
                category.Language = model.Language;
                category.ModifiedDate = model.ModifiedDate;
                category.ShowOnHome = model.ShowOnHome;
                category.SeoTitle = model.SeoTitle;
                category.ParentID = model.ParentID;
                category.ModifiedBy = model.ModifiedBy;
                category.MetaDescriptions = model.MetaDescriptions;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //logging
                return false;
            }
        }
    }
}
