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
    public class AddTitleRep : IAddTitleRep
    {
        private readonly pubsContext pubsContext;
        public AddTitleRep()
        {
            pubsContext= new();
        }
        public void Add(List<TitleVM> titleVMs)
        {
           foreach (var title in Profile.MapListTitle(titleVMs))
           {
                if(title.TitleId!=null)
                {
                    title.Pubdate = DateTime.Now;
                    pubsContext.Titles.Add(title);
                }    
              
           }
            pubsContext.SaveChanges();
        }
    }
}
