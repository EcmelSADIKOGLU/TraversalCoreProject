using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDAL _testimonialDAL;

        public TestimonialManager(ITestimonialDAL testimonialDAL)
        {
            _testimonialDAL = testimonialDAL;
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialDAL.Delete(entity);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDAL.GetList();
        }

        public Testimonial TGetListByID(int id)
        {
            return _testimonialDAL.GetListByID(id);
        }

        public void TInsert(Testimonial entity)
        {
            _testimonialDAL.Insert(entity);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDAL.Update(entity);
        }
    }
}
