using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PictureBookCreator
{
    /// <summary>
    /// Picture Book main Class
    /// <para>Programmer:Sarwan</para>
    /// <para>lab.uyghurdev.net</para>
    /// </summary>
    public class pbk
    {
        #region Properties
        private string _Title;
        /// <summary>
        /// Title of book
        /// </summary>
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
        private string _Author;
        /// <summary>
        /// Author of book
        /// </summary>
        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }
        private string _Category;
        /// <summary>
        /// Category of book
        /// </summary>
        public string Category
        {
            get { return _Category; }
            set { _Category = value; }
        }
        private string _Description;
        /// <summary>
        /// Description
        /// </summary>
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        private List<Page> _Pages;
        /// <summary>
        /// Pages of Book
        /// </summary>
        public List<Page> Pages
        {
            get { return _Pages; }
            set {
                if (_Pages == null)
                {
                    _Pages = new List<Page>();
                }
                _Pages = value;
            }
        }
        private string _Cover;
        /// <summary>
        /// Book Cover
        /// </summary>
        public string Cover
        {
            get { return _Cover; }
            set { _Cover = value; }
        }
        private string _Thumbnail;
        /// <summary>
        /// Thumbnail
        /// </summary>
        public string Thumbnail
        {
            get { return _Thumbnail; }
            set { _Thumbnail = value; }
        }
        #endregion

        public pbk()
        {
            Pages = new List<Page>();
        }

        /// <summary>
        /// build xml file (continer.xml)
        /// </summary>
        public void buildXML()
        {
            (new FileManager()).BuildXML(this);
        }

        public Boolean buildBook()
        {
            return (new FileManager()).BuildPbk(this);

        }

        /// <summary>
        /// fill settings.currentPbk class load from continer.xml
        /// </summary>
        internal void loadFromXML()
        {
           (new FileManager()).filFromXML(this);
        }
    }
}
