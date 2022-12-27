using AutoMapper;
using BLL.DTOs;
using DAL.EF;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BLL.Services
{
    public class ProductServices
    {
        public static List<ProductDTO> Get()
        {
            var data = DataAccessFactory.ProductData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<ProductDTO>>(data);
            return converted;
        }
        public static ProductDTO Get(int id)
        {
            var data = DataAccessFactory.ProductData().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<ProductDTO>(data);
            return converted;
        }
        public static ProductDTO Add(ProductDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ProductDTO, Product>();
                cfg.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Product>(obj);
            var rs = DataAccessFactory.ProductData().Add(converted);
            var rtrs = mapper.Map<ProductDTO>(rs);
            return rtrs;
        }
        public static ProductDTO Update(ProductDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ProductDTO, Product>();
                cfg.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Product>(obj);
            var rs = DataAccessFactory.ProductData().Update(converted);
            var rtrs = mapper.Map<ProductDTO>(rs);
            return rtrs;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.ProductData().Delete(id);
        }
        public static List<ProductDTO> SortByPrice()
        {
            List<ProductDTO> converted = Get();
            List<ProductDTO> productlist = converted.OrderBy(x => x.Price).ToList();
            return productlist;
        }
    }
}
