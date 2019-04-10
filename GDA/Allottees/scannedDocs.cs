using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GDA.Allottees
{
    public partial class scannedDocs : Form
    {

        int id = 0;
        ImageList myImageList = new ImageList();
        ImageList myImageListSmall = new ImageList();
        ImageList myImageListLarge = new ImageList();
        int count = 0;
        public string ImageNewName = "";
        OpenFileDialog ofd = new OpenFileDialog()
        {
            Multiselect = true,
            ValidateNames = true,
            Filter =
         "JPG|*jpg|JPEG|*.jpeg|PNG|*.png"
        };
        FileInfo fi;

        public scannedDocs(int allottee_id)
        {
            InitializeComponent();

            listViewFile.SmallImageList = myImageListSmall;
            listViewFile.SmallImageList = myImageListLarge;
            this.KeyPreview = true;
            id = allottee_id;
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listViewFile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scannedDocs_load(object sender, EventArgs e)
        {

            getImages();
        }
        public void getImages()
        {
            myImageList.ImageSize = new Size(100, 150);
            myImageListSmall.ImageSize = new Size(32, 32);
            myImageListLarge.ImageSize = new Size(80, 80);

            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\docs\"; // <---

            string[] fileEntries = Directory.GetFiles(appPath);
            foreach (string fileName in fileEntries)
            {
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
            }
        }
        public void uploadToListView()
        {
            myImageList.ImageSize = new Size(50, 50);
            myImageListSmall.ImageSize = new Size(32, 32);
            myImageListLarge.ImageSize = new Size(80, 80);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listViewFile.Items.Clear();
                foreach (string fileName in ofd.FileNames)
                {
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
                }
            }
        }
        private void test(object sender, EventArgs e)
        {

            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\docs\"; // <---
            string fullpath = appPath + listViewFile.SelectedItems[0].Text;
            ProcessStartInfo startInfo = new ProcessStartInfo(fullpath);
            Process.Start(startInfo);
        }
    }
}
