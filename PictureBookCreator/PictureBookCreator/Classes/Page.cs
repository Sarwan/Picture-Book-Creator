using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PictureBookCreator
{
    /// <summary>
    /// Page- one page of book
    /// <para>Programmer:Sarwan</para>
    /// <para>lab.uyghurdev.net</para>
    /// </summary>
    public class Page
    {
        private int _ID;
        /// <summary>
        /// page id
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _Picture;
        /// <summary>
        /// picture
        /// </summary>
        public string Picture
        {
            get { return _Picture; }
            set { _Picture = value; }
        }
        private string _Sound;
        /// <summary>
        /// sound
        /// </summary>
        public string Sound
        {
            get { return _Sound; }
            set { _Sound = value; }
        }
        private string _Text;
        /// <summary>
        /// text
        /// </summary>
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }

        public override string ToString()
        {
            return this.ID.ToString()+"-بەت";
        }
    }
}
