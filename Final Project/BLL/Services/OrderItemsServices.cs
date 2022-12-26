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
    public class OrderItemItemsServices
    {
        public static List<OrderItemDTO> Get()
        {
            var data = DataAccessFactory.OrderItemData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Order_Items, OrderItemDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<OrderItemDTO>>(data);
            return converted;
        }
        public static OrderItemDTO Get(int id)
        {
            var data = DataAccessFactory.OrderItemData().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Order_Items, OrderItemDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<OrderItemDTO>(data);
            return converted;
        }
        public static OrderItemDTO Add(OrderItemDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<OrderItemDTO, Order_Items>();
                cfg.CreateMap<Order_Items, OrderItemDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Order_Items>(obj);
            var rs = DataAccessFactory.OrderItemData().Add(converted);
            var rtrs = mapper.Map<OrderItemDTO>(rs);
            return rtrs;
        }
        public static OrderItemDTO Update(OrderItemDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<OrderItemDTO, Order_Items>();
                cfg.CreateMap<Order_Items, OrderItemDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Order_Items>(obj);
            var rs = DataAccessFactory.OrderItemData().Update(converted);
            var rtrs = mapper.Map<OrderItemDTO>(rs);
            return rtrs;
        }
        public static bool Detele(int id)
        {
            return DataAccessFactory.OrderItemData().Delete(id);
        }
    }
}
