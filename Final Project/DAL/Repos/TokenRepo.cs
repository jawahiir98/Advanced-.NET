using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TokenRepo : IRepo<Token, string, Token>
    {
        Shop_CasketEntities db;
        internal TokenRepo()
        {
            db = new Shop_CasketEntities();
        }
        public Token Add(Token obj)
        {
            db.Tokens.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(Token id)
        {
            db.Tokens.Remove(db.Tokens.Find(id));
            return db.SaveChanges() > 0;
        }

        public Token Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Token> Get()
        {
            return db.Tokens.ToList();
        }

        public Token Get(string id)
        {
            return db.Tokens.FirstOrDefault(t => t.Key.Equals(id));
        }

        public Token Update(Token obj)
        {
            var dbtk = Get(obj.Key);
            db.Entry(dbtk).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
       
    }
}
