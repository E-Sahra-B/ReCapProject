using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : ICarDal
    {
        List<Car> _carProducts;
        public InMemoryProductDal()
        {
            _carProducts = new List<Car> { 
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=5,Description="araba",ModelYear=2008},
                new Car{CarId=2,BrandId=1,ColorId=2,DailyPrice=3,Description="taksi",ModelYear=2018},
                new Car{CarId=3,BrandId=2,ColorId=2,DailyPrice=10,Description="kamyon",ModelYear=2021},
                new Car{CarId=4,BrandId=2,ColorId=2,DailyPrice=9,Description="jeap",ModelYear=2020},
                new Car{CarId=5,BrandId=3,ColorId=3,DailyPrice=1,Description="bip bip",ModelYear=1989}
            };
        }
        public void Add(Car product)
        {
            _carProducts.Add(product);
        }

        public void Delete(Car product)
        {
            Car productToDelete = _carProducts.SingleOrDefault(p => p.CarId == product.CarId);
            _carProducts.Remove(productToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carProducts;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrandsId(int brandsId)
        {
            return _carProducts.Where(p => p.BrandId == brandsId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car product)
        {
            Car productToUpdate = _carProducts.SingleOrDefault(p => p.CarId == product.CarId);
            if (productToUpdate!=null)
            {
                productToUpdate.CarId = product.CarId;
                productToUpdate.BrandId = product.BrandId;
                productToUpdate.ColorId = product.ColorId;
                productToUpdate.DailyPrice = product.DailyPrice;
                productToUpdate.Description = product.Description;
                productToUpdate.ModelYear = product.ModelYear;

            }
            
        }
    }
}
