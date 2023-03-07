using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ci.Entities.Data;
using ci.Entities.Models;
using ci.Entities;
using CI.Repo.IRepo;

namespace CI.Repo.Repo
{
    public class User : IUser
    {
        public  readonly CiContext _context;
        public User(CiContext ciContext) 
        {
            _context = ciContext;
        }
      

        List<ci.Entities.Models.User> IUser.GetUserData()
        {
            List<ci.Entities.Models.User > users = _context.Users.ToList();
            return users;
        }
    }
}
