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
    public class GetAllPublisher : IGetAllPublisher
    {
        private readonly pubsContext pubsContext;
        public GetAllPublisher()
        {
            pubsContext = new ();
        }
        public List<PublisherVM> GetALL()
        {
            try
            {
                return Profile.MapListPublisher(pubsContext.Publishers.ToList());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
