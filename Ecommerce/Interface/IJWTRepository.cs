using Ecommerce.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Interface
{
   public interface IJWTRepository
    {
        Tokan Authenticate(User user);
    }
}
