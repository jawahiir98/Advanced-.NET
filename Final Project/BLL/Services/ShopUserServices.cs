using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ShopUserServices
    {
        public static List<ShopUserDTO> Get()
        {
            var data = DataAccessFactory.ShopData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ShopUser, ShopUserDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<ShopUserDTO>>(data);
            return converted;
        }
        public static ShopUserDTO Get(int id)
        {
            var data = DataAccessFactory.ShopData().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ShopUser, ShopUserDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<ShopUserDTO>(data);
            return converted;
        }
        public static ShopUserDTO Add(ShopUserDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ShopUserDTO, ShopUser>();
                cfg.CreateMap<ShopUser, ShopUserDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<ShopUser>(obj);
            var rs = DataAccessFactory.ShopData().Add(converted);
            var rtrs = mapper.Map<ShopUserDTO>(rs);
            return rtrs;
        }
        public static ShopUserDTO Update(ShopUserDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ShopUserDTO, ShopUser>();
                cfg.CreateMap<ShopUser, ShopUserDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<ShopUser>(obj);
            var rs = DataAccessFactory.ShopData().Update(converted);
            var rtrs = mapper.Map<ShopUserDTO>(rs);
            return rtrs;
        }
        public static bool Detele(int id)
        {
            return DataAccessFactory.ShopData().Delete(id);
        }
    }
}
