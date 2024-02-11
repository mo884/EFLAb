using EFLAb.BLL.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLAb.BLL.InterFace
{
    public interface IDeleteTitleRep
    {
        void Delete(List<TitleVM> title);
    }
}
