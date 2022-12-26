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
    public class UserServices
    {
        public static List<UserDTO> Get()
        {
            var data = DataAccessFactory.UserData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<UserDTO>>(data);
            return converted;
        }
        public static UserDTO Get(int id)
        {
            var data = DataAccessFactory.UserData().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<UserDTO>(data);
            return converted;
        }
        public static UserDTO Add(UserDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<User>(obj);
            var rs = DataAccessFactory.UserData().Add(converted);
            var rtrs = mapper.Map<UserDTO>(rs);
            return rtrs;
        }
        public static UserDTO Update(UserDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<User>(obj);
            var rs = DataAccessFactory.UserData().Update(converted);
            var rtrs = mapper.Map<UserDTO>(rs);
            return rtrs;
        }
        public static bool Detele(int id)
        {
            return DataAccessFactory.UserData().Delete(id);
        }
        public static ShopUserDTO Okay(UserDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<ShopUserDTO, ShopUser>();
                cfg.CreateMap<ShopUser, ShopUserDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<User>(obj);
            var res = DataAccessFactory.AuthData().Okay(converted);
            if(res == null) return null;
            else
            {
                var convertshop = mapper.Map<ShopUserDTO>(res);
                return convertshop;
            }
        }
    }
}
