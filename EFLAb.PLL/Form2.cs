using _3TierAdo.PLL;
using EFLAb.BLL.Helper;
using EFLAb.BLL.InterFace;
using EFLAb.BLL.ModelVM;
using EFLAb.BLL.Reposoratory;


namespace EFLAb.PLL
{
    public partial class Form2 : Form
    {
        IGetALLTitleRepo GetTitleRepo;
        IGetAllPublisher getAllPublisher;
        IAddTitleRep addTitleRep;
        IEditeTitleRep editeTitleRep;
        IDeleteTitleRep deleteTitleRep;
        public Form2()
        {

            InitializeComponent();
            GetTitleRepo = new GetALLTitleRepo();
            getAllPublisher = new GetAllPublisher();
            addTitleRep = new AddTitleRep();
            editeTitleRep = new EditeTitleRep();
            deleteTitleRep = new DeleteTitleRep();
        }
        BindingSource bindingSource;
        private void Form2_Load(object sender, EventArgs e)
        {
            bindingSource = new BindingSource(GetTitleRepo.GetAll(), "");
            this.listBox1.DataSource = bindingSource;
            this.listBox1.DisplayMember = "Title";
            this.listBox1.ValueMember = "Title_Id";
            this.textBox4.DataBindings.Add("Text", bindingSource, "Price");
            this.textBox7.DataBindings.Add("Text", bindingSource, "Title");
            this.textBox3.DataBindings.Add("Text", bindingSource, "Advance");
            this.textBox2.DataBindings.Add("Text", bindingSource, "Royalty");
            this.textBox1.DataBindings.Add("Text", bindingSource, "Ytd_sales");
            this.comboBox1.DataSource = getAllPublisher.GetALL();
            this.comboBox1.ValueMember ="publish_ID";
            this.comboBox1.DisplayMember ="publish_Name";
            this.comboBox1.DataBindings.Add("SelectedValue", bindingSource, "Pub_Id");
        }

        private void update_Click(object sender, EventArgs e)
        {
            bindingSource.EndEdit();
            List<TitleVM> updatedTitles = bindingSource.DataSource as List<TitleVM>;
            editeTitleRep.Edite(updatedTitles.FindAll(titile => titile.State == EntityState.Modified));


        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<TitleVM> deleteVM = new List<TitleVM>();
            TitleVM title = new TitleVM() { Title_Id =this.listBox1.SelectedValue.ToString() };
            deleteVM.Add(title);
            deleteTitleRep.Delete(deleteVM);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateTitle createTitle = new();
            createTitle.ShowDialog();
        }
    }
}
