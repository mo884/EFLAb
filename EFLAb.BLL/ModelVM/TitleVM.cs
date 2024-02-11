using EFLAb.BLL.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace EFLAb.BLL.ModelVM
{
    public class TitleVM: BaseEntity
    {
        private string title_id;
        private string title;
        private string? publish_id;
        private decimal price;
        private string notes;
        private decimal advance;
        private int royalty;
        private int ytd_sales;
        public string Type { get; set; }
        public string Title_Id
        {
            get => title_id;
            set
            {
                if (title_id != value)
                {
                    title_id = value;
                    if (this.State != EntityState.created)
                    {
                        this.State = EntityState.Modified;

                    }
                }
            }
        }

        public string Title
        {
            get => title;
            set
            {
                if (title != value)
                {
                    title = value;
                    if (this.State != EntityState.created)
                    {
                        this.State = EntityState.Modified;

                    }
                }
            }
        }
        public string? Pub_Id
        {
            get => publish_id; set
            {
                if (publish_id != value)
                {
                    publish_id = value;
                    if (this.State != EntityState.created)
                    {
                        this.State = EntityState.Modified;

                    }
                }
            }
        }


        public decimal Price
        {
            get => price; set
            {
                if (price != value)
                {
                    price = value;
                    if (this.State != EntityState.created)
                    {
                        this.State = EntityState.Modified;

                    }
                }
            }
        }
        public decimal Advance
        {
            get => advance; set
            {
                if (advance != value)
                {
                    advance = value;
                    if (this.State != EntityState.created)
                    {
                        this.State = EntityState.Modified;

                    }
                }
            }
        }
        public int Royalty
        {

            get => royalty; set
            {
                if (royalty != value)
                {
                    royalty = value;
                    if (this.State != EntityState.created)
                    {
                        this.State = EntityState.Modified;

                    }
                }
            }
        }
        public int Ytd_sales
        {
            get => ytd_sales; set
            {
                if (ytd_sales != value)
                {
                    ytd_sales = value;
                    if (this.State != EntityState.created)
                    {
                        this.State = EntityState.Modified;

                    }
                }
            }
        }
        public string? Notes
        {
            get => notes; set
            {
                if (notes != value)
                {
                    notes = value;
                    if (this.State != EntityState.created)
                    {
                        this.State = EntityState.Modified;

                    }
                }
            }
        }
    }
}
