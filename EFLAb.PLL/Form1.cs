using EFLAb.BLL.Helper;
using EFLAb.BLL.InterFace;
using EFLAb.BLL.ModelVM;
using EFLAb.BLL.Reposoratory;
using EFLAb.DAL.Models;
using System.Windows.Forms;

namespace EFLAb.PLL
{
    public partial class Form1 : Form
    {
        IGetALLTitleRepo addTitleRepo;
        IGetAllPublisher getAllPublisher;
        IAddTitleRep addTitleRep;
        IEditeTitleRep editeTitleRep;
        IDeleteTitleRep deleteTitleRep;
        public Form1()
        {
            InitializeComponent();
            addTitleRepo = new GetALLTitleRepo();
            getAllPublisher = new GetAllPublisher();
            addTitleRep = new   AddTitleRep();
            editeTitleRep = new EditeTitleRep();
            deleteTitleRep = new DeleteTitleRep();
            //this.FormClosed += (sender, e) => pubsContext.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        BindingSource bindingSource;
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource = new BindingSource(addTitleRepo.GetAll(),"");
            this.dataGridView1.DataSource =bindingSource;
            DataGridViewComboBoxColumn dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();

            dataGridViewComboBoxColumn.HeaderText="Publisher";
            dataGridViewComboBoxColumn.DataSource = getAllPublisher.GetALL();
            dataGridViewComboBoxColumn.ValueMember = "publish_ID";
            dataGridViewComboBoxColumn.DisplayMember= "publish_Name";
            dataGridViewComboBoxColumn.DataPropertyName = "Pub_Id";
            this.dataGridView1.Columns.Add(dataGridViewComboBoxColumn);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<TitleVM> TitleVMList = bindingSource.DataSource as List<TitleVM>;
            addTitleRep.Add(TitleVMList.FindAll(titile => titile.State ==EntityState.created));
            editeTitleRep.Edite(TitleVMList.FindAll(titile => titile.State ==EntityState.Modified));
            deleteTitleRep.Delete(TitleVMList.FindAll(titile => titile.State ==EntityState.Deleted));
        }
    }
}
