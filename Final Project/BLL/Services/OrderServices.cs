using AutoMapper;
using BLL.DTOs;
using DAL.EF;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class OrderServices
    {
        public static List<OrderDTO> Get()
        {
            var data = DataAccessFactory.OrderData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<OrderDTO>>(data);
            return converted;
        }
        public static OrderDTO Get(int id)
        {
            var data = DataAccessFactory.OrderData().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<OrderDTO>(data);
            return converted;
        }
        public static OrderDTO Add(OrderDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<OrderDTO, Order>();
                cfg.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Order>(obj);
            var rs = DataAccessFactory.OrderData().Add(converted);
            var rtrs = mapper.Map<OrderDTO>(rs);
            return rtrs;
        }
        public static OrderDTO Update(OrderDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<OrderDTO, Order>();
                cfg.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Order>(obj);
            var rs = DataAccessFactory.OrderData().Update(converted);
            var rtrs = mapper.Map<OrderDTO>(rs);
            return rtrs;
        }
        public static bool Detele(int id)
        {
            return DataAccessFactory.OrderData().Delete(id);
        }
    }
}
