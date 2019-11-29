using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Margille.Models;

namespace Margille.Services
{
    public class ClientService
    {
        private readonly MargilleContext _context;

        public ClientService(MargilleContext context)
        {
            _context = context;
        }

    }
}
