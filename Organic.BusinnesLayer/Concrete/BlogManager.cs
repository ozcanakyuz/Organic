using Organic.BusinnesLayer.Abstract;
using Organic.DataAccessLayer.Abstract;
using Organic.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organic.BusinnesLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void TDelete(int id)
        {
            _blogDal.Delete(id);
        }

        public List<Blog> TGetAll()
        {
            return _blogDal.GetAll();
        }

        public Blog TGetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public void TInsert(Blog entity)
        {
            _blogDal.Insert(entity);
        }

        public void TUpdate(Blog entity)
        {
            _blogDal.Update(entity);
        }
    }
}
