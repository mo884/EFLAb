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
    public class EditeTitleRep : IEditeTitleRep
    {
        private readonly pubsContext pubsContext;
        public EditeTitleRep()
        {
            pubsContext= new();
        }
        public void Edite(List<TitleVM> titleVM)
        {
            try
            {
                foreach (var title in Profile.MapListTitle(titleVM))
                {
                    var Title = pubsContext.Titles.Where(t => t.TitleId ==title.TitleId).FirstOrDefault();

                    Title.TitleId =title.TitleId;
                    Title.Title1  =title.Title1;
                    Title.PubId   = title.PubId;
                    Title.Notes   =title.Notes;
                    Title.Price =title.Price;
                    Title.Advance =title.Advance;
                    Title.Royalty=title.Royalty;
                    Title.YtdSales =title.YtdSales;
                    pubsContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
           
           
        }
    }
}
