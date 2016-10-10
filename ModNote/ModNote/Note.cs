using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModNote
{
    public interface INote
    {
        
        string Title //String Title for the Note, must be unique to each List
        {
            get;
            set;
        }
        string Text //String Text for the note
        {
            get;
            set;
        }
        List<string> Images //List of String to contain Notes Images Filepath and Caption
        {
            get;
            set;
        }
        List<string> Links //List of String to contain Notes Links URL and Name
        {
            get;
            set;
        }
        void addImage(string fileName, string caption = ""); //Procedure to add an image to the notes list
        void addLink(string linkName, string link);//Procedure to add a link to the notes list
        void editInformation(string title, string text, List<string> images = null, List<string> links = null); //Procedure to edit the Notes information
    }
    [Serializable()]//Added the Serializable attribute to all the class to be serialized by binaryformatter and saved
    public class Note : INote, IComparable, IEquatable<INote>
    {
        private string title;
        private string text;
        private List<string> images;
        private List<string> links;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }

        public List<string> Images
        {
            get
            {
                return images;
            }

            set
            {
                images = value;
            }
        }

        public List<string> Links
        {
            get
            {
                return links;
            }

            set
            {
                links = value;
            }
        }

        public Note(string title, string text, List<string> images = null, List<string> links = null)
        {
            this.Title = title;
            this.text = text;
            if (images != null)
                this.Images = new List<string>(images);
            else
                this.Images = new List<string>();
            if (links != null)
                this.Links = new List<string>(links);
            else
                this.Links = new List<string>();
        }

        public void editInformation(string title, string text, List<string> images = null, List<string> links = null)
        {
            this.Title = title;
            this.text = text;
            this.Images = images;
            this.Links = links;
        }

        public void addImage(string fileName, string caption = "")
        {
            images.Add(fileName + "..." + caption);
        }

        public void addLink(string linkName, string link)
        {
            Links.Add(link + "..." + linkName);
        }

        //functions to enable comparing 2 notes
        public int CompareTo(object obj)
        {
            if (obj is INote)
                return this.Title.CompareTo((obj as INote).Title);
            return 0;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            INote objAsNote = obj as INote;
            if (objAsNote == null) return false;
            else return Equals(objAsNote);
        }
        public bool Equals(INote other)
        {
            if (this.Title == other.Title)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
