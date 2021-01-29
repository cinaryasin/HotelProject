using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace HotelBusiness
{
    public class GenericManager<T> where T:class
    {

        HotelDal.ConCrete.GenericRepository<T> _db;
        
        public GenericManager()
        {
            _db = new HotelDal.ConCrete.GenericRepository<T>();
        }
        public bool Insert(T entity)
        {

            Type type = typeof(T);
            var results = new List<ValidationResult>();
            var context = new ValidationContext(entity, serviceProvider: null, items: null);
            var isValid = Validator.TryValidateObject(entity, context, results,true);
            if (!isValid)
            {
                foreach (var validationResult in results)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }

                return false;
            }
            _db.Insert(entity);

            return isValid;
        }

        public bool Update(T entity)
        {
            _db.Update(entity);
            return true;

        }

        public bool Delete(T entity)
        {

            _db.Delete(entity);
            return true;


        }
        public void Save()
        {
            _db.Save();
            
        }
    }
}
