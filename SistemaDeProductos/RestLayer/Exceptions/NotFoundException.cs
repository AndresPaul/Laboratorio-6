using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeProductos.Exceptions
{
    public class NotFoundException:Exception {
        public NotFoundException(string ex):base(ex)
        {

        }
    }
}
