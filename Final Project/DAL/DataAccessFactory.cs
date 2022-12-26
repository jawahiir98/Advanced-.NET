using DAL.EF;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<ShopUser, int, bool> ShopData()
        {
            return new ShopRepo();
        }

        public static IRepo<Product, int, bool> ProductData()
        {
            return new ProductRepo();
        }
        public static IRepo<Order, int, bool> OrderData()
        {
            return new OrderRepo();
        }
        public static IRepo<Order_Items,int, bool> OrderItemData()
        {
            return new OrderItemsRepo();
        }
        public static IRepo<User, int, bool> UserData()
        {
            return new UserRepo();
        }
        public static IRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }
        public static IAuth<User, ShopUser> AuthData()
        {
            return new UserRepo();
        }
    }
}
