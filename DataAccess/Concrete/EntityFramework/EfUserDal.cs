using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RentACarContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new RentACarContext())
            {
                var result = from operationclaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationclaim.Id equals userOperationClaim.Id
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationclaim.Id, Name = operationclaim.Name };
                return result.ToList();

            }
        }
    }
}
