using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDA.Allottees
{
    public partial class addDocuments : Form
    {
        Logic.connection con = new Logic.connection();
        ImageList myImageList = new ImageList();
        ImageList myImageListSmall = new ImageList();
        ImageList myImageListLarge = new ImageList();
        int count = 0;
        public string ImageNewName = "";
        string[] file_names = new string[0];
        string[] file_paths = new string[0];
        OpenFileDialog ofd = new OpenFileDialog()
        {
            Multiselect = true,
            ValidateNames = true,
            Filter =
         "JPG|*jpg|JPEG|*.jpeg|PNG|*.png"
        };
        FileInfo fi;
        giedaEntities db;

        public int uid;
        public addDocuments(int userId)
        {
            InitializeComponent();
            listViewFile.SmallImageList = myImageListSmall;
            listViewFile.SmallImageList = myImageListLarge;
            this.KeyPreview = true;
            this.uid = userId;
        }
        public void uploadToListView()
        {
            myImageList.ImageSize = new Size(50, 50);
            myImageListSmall.ImageSize = new Size(32, 32);
            myImageListLarge.ImageSize = new Size(80, 80);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int i = 0;
                file_names = new string[ofd.FileNames.Count()];
                file_paths = new string[ofd.FileNames.Count()];
                listViewFile.Items.Clear();
                foreach (string fileName in ofd.FileNames)
                {
                    file_names[i] = ofd.SafeFileNames[i];
                    file_paths[i] = ofd.FileNames[i];
                    fi = new FileInfo(fileName);
                    FileInfo fileinfo = new FileInfo(fileName);
                    using (FileStream stream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read))
                    {
                        myImageList.Images.Add(Image.FromStream(stream));
                        myImageListSmall.Images.Add(Image.FromStream(stream));
                        myImageListLarge.Images.Add(Image.FromStream(stream));


                    }
                    listViewFile.LargeImageList = myImageList;

                    listViewFile.Items.Add(new ListViewItem
                    {
                        ImageIndex = count,
                        Text = fi.Name,
                        Tag = fi.FullName
                    });
                    count++;
                    i++;
                }
            }
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int user_id = 0;
            if (txtPdsNo.Text == "")
            {

                MessageBox.Show("Kindly Enter a Pds Number");


            }
            else
            {
                con = new Logic.connection();
                con.Select("select id from allottees where pds_number=" + Int32.Parse(txtPdsNo.Text));
                DataTable dt = new DataTable();
                con.sda.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    user_id = Int32.Parse(row["id"].ToString());
                }


                if (user_id == 0)
                {
                    MessageBox.Show("Kindly enter a valid pds Number");
                }
                else
                {

                    try
                    {
                        string pic_name = "";
                        for (int i = 0; i < file_names.Length; i++)
                        {
                            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\docs\";

                            string ext = Path.GetExtension(file_names[i]);
                            pic_name = Guid.NewGuid().ToString() + ext;
                            File.Copy(file_paths[i], appPath + pic_name);
                            string query = "INSERT INTO allottee_documents  (title, [document], allotee_id, created_at,updated_at) VALUES('Allottee Document', '" + pic_name + "'," + user_id + "," + DateTime.Now + "," + DateTime.Now + ")";


                            db = new giedaEntities();
                            allottee_documents allotteeDocuments = new allottee_documents()
                            {
                                title = "Allottee Document",
                                document = pic_name,
                                allotee_id = user_id,
                                created_at = DateTime.Now,
                                updated_at = DateTime.Now
                            };

                            db.allottee_documents.Add(allotteeDocuments);
                            db.SaveChanges();

                        }



                        if (pic_name != "")
                        {
                            MessageBox.Show("Docs Uploaded");
                        }
                        else
                        {
                            MessageBox.Show("No Image Selected");
                        }

                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("Error: " + ee.Message);
                    }
                }
            }
        }

        private void addDocuments_Load(object sender, EventArgs e)
        {
            listViewFile.Enabled = false;
        }

        private void upload_Click(object sender, EventArgs e)
        {
            uploadToListView();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
