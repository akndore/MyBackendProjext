using Core.DataAccess;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IUserDal:IEntityRepository<User>
    {
        List<Role> GetRoles(User user);
    }
}
