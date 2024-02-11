using EFLAb.BLL.InterFace;
using EFLAb.BLL.Mapper;
using EFLAb.BLL.ModelVM;
using EFLAb.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLAb.BLL.Reposoratory
{
    public class GetALLTitleRepo : IGetALLTitleRepo
    {
        private readonly pubsContext pubsContext;
        public GetALLTitleRepo()
        {
            pubsContext = new();
        }
        public List<TitleVM> GetAll()
        {
            try
            {
               return Profile.MapListTitle(pubsContext.Titles.ToList());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
