using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.IO.Compression;
using Ionic.Zip;

namespace PictureBookCreator
{
    public class FileManager
    {

        #region Methods
        /// <summary>
        /// Create Project Folder
        /// <para>Programmer:Sarwan</para>
        /// <para>lab.uyghurdev.net</para>
        /// </summary>
        /// <param name="strRootPath"></param>
        public void createProjectFolder(string strRootPath)
        {
            DirectoryInfo di = new DirectoryInfo(strRootPath);
            if (!di.Exists)
            {
                di.Create();
            }
            di.CreateSubdirectory( Settings.PICTURE_FOLDER);//Create Picture folder in root folder
            di.CreateSubdirectory( Settings.SOUND_FOLER);//Create Sound folder in root folder.
        }

        public System.IO.DirectoryInfo FolderPath()
        {
          
            return null;
        }

        /// <summary>
        /// import picture into picture folder if not exists
        /// </summary>
        /// <param name="strFilePath">full path of file</param>
        /// <returns>short file name</returns>
        public string importPicture(string strFilePath)
        {
            FileInfo fi = new FileInfo(strFilePath);
            if (!PictureExists(fi.Name))
            {
                fi.CopyTo(Settings.ROOT_PATH_OF_PROJECT + "\\" + Settings.PICTURE_FOLDER + "\\" + fi.Name,false);
            }
            return fi.Name;
        }

        /// <summary>
        /// import sound file into sound folder
        /// </summary>
        /// <param name="strFilePath">full path</param>
        /// <returns></returns>
        public string importSound(string strFilePath)
        {
            FileInfo fi = new FileInfo(strFilePath);
            if (!SoundExists(fi.Name))
            {
                fi.CopyTo(Settings.ROOT_PATH_OF_PROJECT + "\\" + Settings.SOUND_FOLER + "\\" + fi.Name, false);
            }
            return fi.Name;
        }

        /// <summary>
        /// check sound file in sound folder exists
        /// </summary>
        /// <param name="SoundFileName"></param>
        /// <returns></returns>
        public Boolean SoundExists(string SoundFileName)
        {
            return File.Exists(Settings.ROOT_PATH_OF_PROJECT + "\\" + Settings.SOUND_FOLER + "\\" + SoundFileName);
        }

        /// <summary>
        /// check picture file exists in picture folder
        /// </summary>
        /// <param name="PicFileName">file name</param>
        /// <returns></returns>
        public Boolean PictureExists(string PicFileName)
        {
            return File.Exists(Settings.ROOT_PATH_OF_PROJECT + "\\" + Settings.PICTURE_FOLDER + "\\" + PicFileName);
        }

        /// <summary>
        /// check subfolder exists
        /// </summary>
        /// <param name="SubPath"></param>
        /// <returns>ture is exists</returns>
        public Boolean isFolderExists(string SubPath)
        {
            return File.Exists(Settings.ROOT_PATH_OF_PROJECT + "\\" + SubPath);
        }

        /// <summary>
        /// check continer file exists
        /// </summary>
        /// <returns>true is exists</returns>
        public Boolean isContinerExists()
        {
            return File.Exists(Settings.ROOT_PATH_OF_PROJECT + "\\" + Settings.CONTINER_FILE_NAME);
        }

        /// <summary>
        /// check cover file
        /// </summary>
        /// <returns></returns>
        public Boolean isCoverExists()
        {
            return File.Exists(Settings.ROOT_PATH_OF_PROJECT + "\\" + Settings.COVER_FILE);
        }

        /// <summary>
        /// check cover file
        /// </summary>
        /// <returns></returns>
        public Boolean isThumbnailExists()
        {
            return File.Exists(Settings.ROOT_PATH_OF_PROJECT + "\\" + Settings.COVER_FILE);
        }

        /// <summary>
        /// import cover picture file
        /// </summary>
        /// <param name="strFile">source file</param>
        /// <returns>file name</returns>
        public string importCover(string strFile)
        {
            FileInfo fiCover = new FileInfo(strFile);
            fiCover.CopyTo(Settings.ROOT_PATH_OF_PROJECT + "\\cover.png", true);
            return fiCover.Name;
        }

        /// <summary>
        /// import thumbnail picture file
        /// </summary>
        /// <param name="strFile">source file</param>
        /// <returns>file name</returns>
        public string importThumbnail(string strFile)
        {
            FileInfo fiThumbnail= new FileInfo(strFile);
            fiThumbnail.CopyTo(Settings.ROOT_PATH_OF_PROJECT + "\\thumbnail.png", true);
            return fiThumbnail.Name;
        }

        /// <summary>
        /// Build xml continer file
        /// </summary>
        /// <param name="objPbk">pbk book object</param>
        public void BuildXML(pbk objPbk)
        {
            XmlDocument xDoc = new XmlDocument();
            XmlDeclaration xDec = xDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xDoc.AppendChild(xDec);

            XmlElement xeBook = xDoc.CreateElement("book");
            xDoc.AppendChild(xeBook);

            XmlElement xeTitle = xDoc.CreateElement("title");
            xeTitle.InnerText = objPbk.Title;
            xeBook.AppendChild(xeTitle);
            XmlElement xeAuthor = xDoc.CreateElement("author");
            xeAuthor.InnerText = objPbk.Author;
            xeBook.AppendChild(xeAuthor);
            XmlElement xeCategory = xDoc.CreateElement("category");
            xeCategory.InnerText = objPbk.Category;
            xeBook.AppendChild(xeCategory);
            XmlElement xeDescription = xDoc.CreateElement("description");
            xeDescription.InnerText = objPbk.Description;
            xeBook.AppendChild(xeDescription);

            XmlElement xePages = xDoc.CreateElement("pages");
            xeBook.AppendChild(xePages);
            foreach (Page pg in objPbk.Pages)
            {
                XmlElement xePage = xDoc.CreateElement("page");
                xePages.AppendChild(xePage);

                XmlElement xeID = xDoc.CreateElement("id");
                xeID.InnerText = pg.ID.ToString();
                xePage.AppendChild(xeID);

                XmlElement xePicture = xDoc.CreateElement("picture");
                xePicture.InnerText = pg.Picture;
                xePage.AppendChild(xePicture);
                XmlElement xeSound = xDoc.CreateElement("sound");
                xeSound.InnerText = pg.Sound;
                xePage.AppendChild(xeSound);
                XmlElement xeText = xDoc.CreateElement("text");
                xeText.InnerText = pg.Text;
                xePage.AppendChild(xeText);
                xePages.AppendChild(xePage);
            }

            xDoc.Save(Settings.ROOT_PATH_OF_PROJECT + "\\" + Settings.CONTINER_FILE_NAME);
        }
      
        /// <summary>
        /// fill pbk object from xml file
        /// </summary>
        /// <param name="Pbk"></param>
        internal void filFromXML(pbk Pbk)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Settings.ROOT_PATH_OF_PROJECT + "\\" + Settings.CONTINER_FILE_NAME);

            XmlNode xnTitle = xDoc.SelectSingleNode("//book//title//text()");
            Pbk.Title = xnTitle.InnerText;

            XmlNode xnAuthor = xDoc.SelectSingleNode("//book//author//text()");
            Pbk.Author = xnAuthor.InnerText;

            XmlNode xnCategory = xDoc.SelectSingleNode("//book//category//text()");
            Pbk.Category = xnCategory.InnerText;

            XmlNode xnDescription = xDoc.SelectSingleNode("//book//description//text()");
            Pbk.Description = xnDescription.InnerText;

            XmlNodeList xnPages = xDoc.SelectNodes("//book//pages//page");
            foreach (XmlNode xn in xnPages)
            {
                Page pg = new Page();

                //XmlNode xnID = xn.SelectSingleNode("//id//text()");
                pg.ID = Convert.ToInt16(xn.ChildNodes[0].InnerText);

                //XmlNode xnPic = xn.SelectSingleNode("//picture//text()");
                pg.Picture = xn.ChildNodes[1].InnerText;// xnPic.InnerText;

                //XmlNode xnSound = xn.SelectSingleNode("//sound//text()");
                pg.Sound = xn.ChildNodes[2].InnerText;// xnSound.InnerText;

                //XmlNode xnText = xn.SelectSingleNode("//text//text()");
                pg.Text = xn.ChildNodes[3].InnerText;// xnText.InnerText;

                Pbk.Pages.Add(pg);
            }

                if(isCoverExists())
                {
                   Pbk.Cover=Settings.COVER_FILE;
                }
                if (isThumbnailExists())
                {
                    Pbk.Thumbnail = Settings.THUMBNAIL_FILE;
                }

        }

        /// <summary>
        /// get files in picture folders
        /// </summary>
        /// <returns>files in picture folders</returns>
        public List<string> getPictures()
        {
            return getFiles(Settings.PICTURE_FOLDER);
        }

        /// <summary>
        /// get files in sound folder
        /// </summary>
        /// <returns>files in sound folders</returns>
        public List<string> getSounds()
        {
            return getFiles(Settings.SOUND_FOLER);
        }

        /// <summary>
        /// get files in folder
        /// </summary>
        /// <param name="strSubFolder">sub folder</param>
        /// <returns>files list</returns>
        private List<string> getFiles(string strSubFolder)
        {
            List<string> lstFiles = new List<string>();
            DirectoryInfo di=new DirectoryInfo(Settings.ROOT_PATH_OF_PROJECT + "\\" + strSubFolder);
            foreach (FileInfo fi in di.GetFiles())
            {
                lstFiles.Add(fi.Name);
            }
            return lstFiles;
        }
        #endregion

        internal bool BuildPbk(pbk pbk)
        {
            //ZipStorer zs ;
            //zs= ZipStorer.Create(Settings.ROOT_PATH_OF_PROJECT+"\\"+Settings.CurrentPbk.Title+".zip","Generated by Picture Book Creator. lab.UyghurDev.net.");
            //zs.EncodeUTF8 = true;
            //zs.AddFile(ZipStorer.Compression.Store, Settings.ROOT_PATH_OF_PROJECT +"\\"+ Settings.CONTINER_FILE_NAME, Settings.CONTINER_FILE_NAME, "");
            
            //zs.Close();

            try
            {
                ZipFile zf = new ZipFile();
                //zf.AddDirectory(Settings.PICTURE_FOLDER);
                //zf.AddDirectory(Settings.SOUND_FOLER);
                zf.AddFile(Settings.ROOT_PATH_OF_PROJECT + "\\" + Settings.CONTINER_FILE_NAME,"\\");
                if (!String.IsNullOrEmpty(Settings.CurrentPbk.Cover))
                {
                    zf.AddFile(Settings.ROOT_PATH_OF_PROJECT + "\\" + Settings.CurrentPbk.Cover, "\\");
                }
                if (!String.IsNullOrEmpty(Settings.CurrentPbk.Thumbnail))
                {
                    zf.AddFile(Settings.ROOT_PATH_OF_PROJECT + "\\" + Settings.CurrentPbk.Thumbnail, "\\");
                }
                foreach (Page pg in Settings.CurrentPbk.Pages)
                {
                  
                        if (!string.IsNullOrEmpty(pg.Picture) && !isContines(zf.Entries, Settings.PICTURE_FOLDER + "/" + pg.Picture))
                        {
                            zf.AddFile(Settings.ROOT_PATH_OF_PROJECT + "\\" + Settings.PICTURE_FOLDER + "\\" + pg.Picture, Settings.PICTURE_FOLDER);
                        }
                  

                        if (!string.IsNullOrEmpty(pg.Sound) && !isContines(zf.Entries, Settings.SOUND_FOLER + "/" + pg.Sound))
                        {
                            zf.AddFile(Settings.ROOT_PATH_OF_PROJECT + "\\" + Settings.SOUND_FOLER + "\\" + pg.Sound, Settings.SOUND_FOLER);
                        }
                  
                }

                string strFileName = Settings.ROOT_PATH_OF_PROJECT + "\\" + Settings.CurrentPbk.Title + ".pbk";
                if (File.Exists(strFileName))
                {
                    File.Delete(strFileName);
                }
                zf.Save(strFileName);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// is contines 
        /// </summary>
        /// <param name="zes"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private bool isContines(ICollection<ZipEntry> zes,string fileName)
        {

            foreach (ZipEntry ze in zes)
            {
                if (ze.FileName == fileName)
                    return true;
            }
            return false;
        }
    }
}
