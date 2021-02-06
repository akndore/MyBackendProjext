using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<Role> GetRoles(User user)
        {
            using (var context = new NorthwindContext())
            {

                var result = from r in context.Roles
                             join ur in context.UserRoles
                             on r.Id equals ur.RoleId
                             where ur.UserId == user.Id
                             select new Role { Id = r.Id, Name = r.Name };
                return result.ToList();
            }
        }
    }
}
