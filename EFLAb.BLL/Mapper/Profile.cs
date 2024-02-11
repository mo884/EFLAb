using EFLAb.BLL.Helper;
using EFLAb.BLL.ModelVM;
using EFLAb.DAL.Models;


namespace EFLAb.BLL.Mapper
{
    public static class Profile
    {
        #region MapTitleList To TitleListVM
        public static List<TitleVM> MapListTitle(List<Title> titles)
        {
            List<TitleVM> addTitleVMs = new();

            try
            {
                foreach (Title title in titles)
                {
                    addTitleVMs.Add(MapTitle(title));
                }
            }
            catch (Exception)
            {

            }

            return addTitleVMs;
        }

        public static TitleVM MapTitle(Title title)
        {
            TitleVM titleVM = new TitleVM();
            try
            {

                titleVM.Title_Id =title.TitleId;
                titleVM.Title = title.Title1;
                titleVM.Pub_Id = title.PubId;
                titleVM.Notes =  title.Notes;
                if(decimal.TryParse(title.Price.ToString(),out decimal temp))
                titleVM.Price =temp;
                else
                    titleVM.Price = 0;

                if (decimal.TryParse(title.Advance.ToString(), out temp))
                    titleVM.Advance =temp;
                else
                    titleVM.Advance = 0;


                if (int.TryParse(title.Royalty.ToString(), out int tempInt))
                    titleVM.Royalty =tempInt;
                else
                    titleVM.Royalty = 0;

                if (int.TryParse(title.YtdSales.ToString(), out  tempInt))
                    titleVM.Ytd_sales =tempInt;
                else
                    titleVM.Ytd_sales = 0;

                titleVM.State = EntityState.Unchanged;
                titleVM.Type = title.Type;
            }
            catch (Exception)
            {


            }
            return titleVM;
        }
        #endregion

        #region MapTitleListVM To TitleList
        public static List<Title> MapListTitle(List<TitleVM> titlesVM)
        {
            List<Title>Titles = new();

            try
            {
                foreach (TitleVM title in titlesVM)
                {
                    Titles.Add(MapTitle(title));
                }
            }
            catch (Exception)
            {

            }

            return Titles;
        }

        public static Title MapTitle(TitleVM titleVM)
        {
            Title title = new Title();
            try
            {

                title.TitleId =titleVM.Title_Id;
                title.Title1  =titleVM.Title ;
                title.PubId   = titleVM.Pub_Id ;
                title.Notes   =titleVM.Notes ;
                title.Price =titleVM.Price ;
                title.Advance =titleVM.Advance ;
                title.Royalty=titleVM.Royalty  ;
                title.YtdSales =titleVM.Ytd_sales ;
               
            }
            catch (Exception)
            {


            }
            return title;
        }
        #endregion

        #region MapPublisherList
        public static List<PublisherVM> MapListPublisher(List<Publisher> Publishers)
        {
            List<PublisherVM> addPublishVMs = new();

            try
            {
                foreach (Publisher pub in Publishers)
                {
                    addPublishVMs.Add(MapPublish(pub));
                }
            }
            catch (Exception)
            {

            }

            return addPublishVMs;
        }

        public static PublisherVM MapPublish(Publisher Publisher)
        {
            PublisherVM PublisherVM = new PublisherVM();
            try
            {

                PublisherVM.publish_ID =Publisher.PubId;
                PublisherVM.publish_Name =Publisher.PubName;

            }
            catch (Exception)
            {


            }
            return PublisherVM;
        }
        #endregion
    }
}
