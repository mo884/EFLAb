using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLAb.BLL.Helper
{
    public class BaseEntity
    {
        public EntityState State { get; set; } = EntityState.created;

    }
}
