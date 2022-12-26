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
    public class TokenServices
    {
        public static List<TokenDTO> Get()
        {
            var data = DataAccessFactory.TokenData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Token, TokenDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<TokenDTO>>(data);
            return converted;
        }
        public static TokenDTO Get(string id)
        {
            var data = DataAccessFactory.TokenData().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Token, TokenDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<TokenDTO>(data);
            return converted;
        }
        public static TokenDTO Add(TokenDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TokenDTO, Token>();
                cfg.CreateMap<Token, TokenDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Token>(obj);
            var rs = DataAccessFactory.TokenData().Add(converted);
            var rtrs = mapper.Map<TokenDTO>(rs);
            return rtrs;
        }
        public static TokenDTO Update(TokenDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TokenDTO, Token>();
                cfg.CreateMap<Token, TokenDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Token>(obj);
            var rs = DataAccessFactory.TokenData().Update(converted);
            var rtrs = mapper.Map<TokenDTO>(rs);
            return rtrs;
        }
    }
}
