using EFLAb.BLL.InterFace;
using EFLAb.BLL.ModelVM;
using EFLAb.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLAb.BLL.Reposoratory
{
    public class DeleteTitleRep : IDeleteTitleRep
    {
        private readonly pubsContext pubsContext;
        public DeleteTitleRep()
        {
            pubsContext= new();
        }
        public void Delete(List<TitleVM> titles)
        {
			try
			{
                foreach (var item in titles)
                {
                    Title title = pubsContext.Titles.Where(t => t.TitleId== item.Title_Id).FirstOrDefault();
                    pubsContext.Titles.Remove(title);
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
