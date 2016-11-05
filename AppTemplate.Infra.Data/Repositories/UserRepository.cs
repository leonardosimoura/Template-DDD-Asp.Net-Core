using AppTemplate.Domain.Entities;
using AppTemplate.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTemplate.Infra.Data.Repositories
{
    public class UserRepository : RepositoryBase<Usuario>, IUserRepository
    {
    }
}
