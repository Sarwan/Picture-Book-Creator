using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PictureBookCreator
{
    public partial class Form1 : Form
    {
        #region events

        private int nCurrentPageIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Finish_Click(object sender, EventArgs e)
        {

        }

        private void mnuCreateProject_Click(object sender, EventArgs e)
        {
            CreateBookDialog frmCBD = new CreateBookDialog();
            frmCBD.ShowDialog();
            enableEdit();
        }

        private void txtBookTitle_Leave(object sender, EventArgs e)
        {
            Settings.CurrentPbk.Title = txtBookTitle.Text.Trim();
        }

        private void txtAuthor_Leave(object sender, EventArgs e)
        {
            Settings.CurrentPbk.Author = txtAuthor.Text.Trim();
        }

        private void txtCatgory_Leave(object sender, EventArgs e)
        {
            Settings.CurrentPbk.Category = txtCatgory.Text.Trim();
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            Settings.CurrentPbk.Description = txtDescription.Text.Trim();
        }

        private void btnImportCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Prtable Network Graphic (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileManager fm = new FileManager();
                txtCover.Text=Settings.CurrentPbk.Cover= fm.importCover(ofd.FileName);

            }
        }

        private void btnImportThumbnail_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Prtable Network Graphic (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileManager fm = new FileManager();
                txtThumbnail.Text =Settings.CurrentPbk.Thumbnail= fm.importThumbnail(ofd.FileName);
            }
        }

        private void tpBookInfo_Leave(object sender, EventArgs e)
        {
            Settings.CurrentPbk.buildXML();
        }

        private void mnuProjectOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "كىتاب ھۆججىتى مۇندەرىجىسىنى ئېچىڭ";
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (!System.IO.File.Exists(fbd.SelectedPath + "\\" + Settings.CONTINER_FILE_NAME))
                {
                    MessageBox.Show("تاللانغان مۇندەرىجىدىن مۇناسىۋەتلىك كىتاب ھۆججىتى تېپىلمىدى.", "كىتاب ھۆججىتى تېپىلمىدى", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Settings.ROOT_PATH_OF_PROJECT = fbd.SelectedPath;
                Settings.CurrentPbk = null;
                Settings.CurrentPbk = new pbk();
                Settings.CurrentPbk.loadFromXML();
                FillInfo();
                fillPageListBox();
                fillPictures();
                fillSounds();
                enableEdit();
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            addPage();
        }

       

        private void lbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            nCurrentPageIndex = lbPages.SelectedIndex;
            Page pg = Settings.CurrentPbk.Pages[nCurrentPageIndex];
            cmbEditPicture.Text = pg.Picture;
            cmbEditSound.Text = pg.Sound;
            txtEditText.Text = pg.Text;
        }

        private void mnuAddPage_Click(object sender, EventArgs e)
        {
            addPage();
        }

        private void mnuDeletePage_Click(object sender, EventArgs e)
        {
            deletePage();
        }
    

        private void cmbEditPicture_Leave(object sender, EventArgs e)
        {
            Settings.CurrentPbk.Pages[nCurrentPageIndex].Picture = cmbEditPicture.Text;
        }

        private void cmbEditSound_Leave(object sender, EventArgs e)
        {
            Settings.CurrentPbk.Pages[nCurrentPageIndex].Sound = cmbEditSound.Text;
        }

        private void txtEditText_Leave(object sender, EventArgs e)
        {
            Settings.CurrentPbk.Pages[nCurrentPageIndex].Text = txtEditText.Text; ;
        }

        private void tpEdit_Leave(object sender, EventArgs e)
        {
            if (Settings.CurrentPbk != null)
            {
                Settings.CurrentPbk.buildXML();
            }
        }

        private void btnEditImportPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Portable Network Graphic file (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if((new FileManager()).PictureExists(ofd.SafeFileName))
                {
                    MessageBox.Show(ofd.SafeFileName+" ناملىق ھۆججەت مەۋجۇت. قايتا ئەكىرگىلى بولمايدۇ. باشقا ھۆججەت ئەكىرىڭ ياكى ئىسمىنى ئۆزگەرتىپ ئەكىرىڭ!", "ھۆججەت مەۋجۇت", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
               string strFileName= (new FileManager()).importPicture(ofd.FileName);
               fillPictures();
               cmbEditPicture.Text = strFileName;
               Settings.CurrentPbk.Pages[nCurrentPageIndex].Picture = cmbEditPicture.Text;
            }
        }

        private void btnEditImportSound_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3 file (*.mp3)|*.mp3";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if ((new FileManager()).SoundExists(ofd.SafeFileName))
                {
                    MessageBox.Show(ofd.SafeFileName + " ناملىق ھۆججەت مەۋجۇت. قايتا ئەكىرگىلى بولمايدۇ. باشقا ھۆججەت ئەكىرىڭ ياكى ئىسمىنى ئۆزگەرتىپ ئەكىرىڭ!", "ھۆججەت مەۋجۇت", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                 string strFileName=(new FileManager()).importSound(ofd.FileName);
                fillSounds();
                cmbEditSound.Text = strFileName;
                Settings.CurrentPbk.Pages[nCurrentPageIndex].Sound = cmbEditSound.Text;
            }
        }

        private void tpEdit_Enter(object sender, EventArgs e)
        {
            //fillPictures();
            //fillSounds();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            desableEdit();
        }

        private void mnuCloseProject_Click(object sender, EventArgs e)
        {
            if (Settings.CurrentPbk != null)
            {
                Settings.CurrentPbk.buildXML();
            }
            Settings.CurrentPbk = null;
            Settings.COVER_FILE = string.Empty;
            Settings.THUMBNAIL_FILE = string.Empty;
            Settings.ROOT_PATH_OF_PROJECT = string.Empty;
            desableEdit();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
           Boolean blnSuccess= Settings.CurrentPbk.buildBook();
           MessageBox.Show(blnSuccess ? "رەسىملىك كىتاب ھۆججىتى ھاسىل قىلىندى" : "رەسىملىك كىتاب ھۆججىتى ھاسىل قىلىشتا خاتالىق كۆرۈلدى!", "تامام", MessageBoxButtons.OK, blnSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }

        private void btnRemovePage_Click(object sender, EventArgs e)
        {
          
           deletePage();
        }
        #endregion
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog ad = new AboutDialog();
            ad.ShowDialog();
        }

        #region methods
        /// <summary>
        /// fill book info to form controls in info tab.
        /// </summary>
        private void FillInfo()
        {
            txtBookTitle.Text = Settings.CurrentPbk.Title;
            txtAuthor.Text = Settings.CurrentPbk.Author;
            txtCatgory.Text = Settings.CurrentPbk.Category;
            txtDescription.Text = Settings.CurrentPbk.Description;
            txtCover.Text = Settings.CurrentPbk.Cover;
            txtThumbnail.Text = Settings.CurrentPbk.Thumbnail;
        }

        /// <summary>
        /// fill pages to listbox
        /// </summary>
        private void fillPageListBox()
        {

            //lbPages.DataSource = Settings.CurrentPbk.Pages;
            //lbPages.DisplayMember = "Text";
            //lbPages.ValueMember = "ID";
            lbPages.Items.Clear();
            foreach (Page pg in Settings.CurrentPbk.Pages)
            {
                lbPages.Items.Add(pg);
            }
            lbPages.FormatString = "0-بەت";
            lbPages.DisplayMember = "ID";
            lbPages.ValueMember = "ID";
        }

        /// <summary>
        /// fill sound file list to combobox
        /// </summary>
        private void fillSounds()
        {
            cmbEditSound.DataSource = (new FileManager()).getSounds();
            cmbEditSound.SelectedItem = Settings.CurrentPbk.Pages[nCurrentPageIndex].Sound;
            //MessageBox.Show(nCurrentPageIndex.ToString());
        }

        /// <summary>
        /// fill picture file list to combobox
        /// </summary>
        private void fillPictures()
        {
            cmbEditPicture.DataSource = (new FileManager()).getPictures();
            cmbEditPicture.SelectedItem = Settings.CurrentPbk.Pages[nCurrentPageIndex].Picture;
            //MessageBox.Show(nCurrentPageIndex.ToString());
        }



        /// <summary>
        /// delete page 
        /// </summary>
        private void deletePage()
        {
            if (lbPages.SelectedIndex < 0)
            { return; }
            Settings.CurrentPbk.Pages.RemoveAt(lbPages.SelectedIndex);
            if (nCurrentPageIndex >= Settings.CurrentPbk.Pages.Count)
            {
                nCurrentPageIndex--;
            }
            fillPageListBox();
            lbPages.SelectedIndex = nCurrentPageIndex;
        }

        /// <summary>
        /// add Page
        /// </summary>
        private void addPage()
        {
            Page pg = new Page();
            pg.ID = Settings.CurrentPbk.Pages.Count + 1;
            Settings.CurrentPbk.Pages.Add(pg);
            fillPageListBox();
        }

        /// <summary>
        /// enable controls 
        /// </summary>
        private void enableEdit()
        {
            tbRight.Enabled = true;
            tbMain.Enabled = true;
            mnuEdit.Enabled = true;
            mnuValidate.Enabled = true; 
            mnuBuild.Enabled = true;
            mnuPreview.Enabled = true;
        }

        /// <summary>
        /// desable controls
        /// </summary>
        private void desableEdit()
        {
            tbRight.Enabled = false;
            tbMain.Enabled = false;
            mnuEdit.Enabled = false;
            mnuValidate.Enabled = false;
            mnuBuild.Enabled = false;
            mnuPreview.Enabled = false;
        }

        #endregion








    }
}
