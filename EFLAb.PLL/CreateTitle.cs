
using EFLAb.BLL.InterFace;
using EFLAb.BLL.ModelVM;
using EFLAb.BLL.Reposoratory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3TierAdo.PLL
{
    public partial class CreateTitle : Form
    {
        IGetAllPublisher getAllPublisher;
        IAddTitleRep addTitleRep;
        public CreateTitle()
        {
            InitializeComponent();
            getAllPublisher = new GetAllPublisher();
            addTitleRep = new AddTitleRep();
        }

        private void CreateTitle_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = getAllPublisher.GetALL();
            this.comboBox1.ValueMember ="publish_ID";
            this.comboBox1.DisplayMember ="publish_Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titleId = textBox3.Text;
            string titleName = textBox7.Text;
            string publisherId = comboBox1.SelectedValue.ToString();
            decimal price = decimal.Parse(textBox2.Text);
            decimal advance = decimal.Parse(textBox5.Text);
            int royalty = int.Parse(textBox6.Text);
            int ytdSales = int.Parse(textBox1.Text);
            string notes = textBox8.Text;
            List<TitleVM> updateVM = new List<TitleVM>();
            TitleVM updatedTitle = new TitleVM
            {
                Title_Id = titleId,
                Title = titleName,
                Pub_Id = publisherId,
                Price = price,
                Advance = advance,
                Royalty = royalty,
                Ytd_sales = ytdSales,
                Notes = notes
            };
            updateVM.Add(updatedTitle);
            addTitleRep.Add(updateVM);
                this.Close();
        
        }
    }
}
