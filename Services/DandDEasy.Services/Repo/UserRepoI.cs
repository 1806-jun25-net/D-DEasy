using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DandDEasy.Services.Repo
{
    interface UserRepoI
    {
        IEnumerable<User> GetUsertable();

        void InsertUser(User credentials);
    }
}
