using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModNote
{
    public interface IModule
    {
        string Code //String Code for the Module, must be unique to each Module
        {
            get;
            set;
        }
        string Title //String Title for the Module
        {
            get;
            set;
        }
        string Synopsis //String Synopsis for the Module
        {
            get;
            set;
        }
        List<string> LearningObjectives //List of String to contain Modules learningObjectives
        {
            get;
            set;
        }
        List<IAssessment> Assessments //List of Assessment interface, to allow any class that inherits the interface to be stored
        {
            get;
            set;
        }
        string FileName //String Filename to store the modules filename
        {
            get;
            set;
        }
        List<INote> Notes //List of Note interface, to allow any class that inherits the interface to be stored
        {
            get;
            set;
        }
        void editInformation(string code, string title, string synopsis, List<string> learningObjectives, string fileName = "");//Procedure to edit the Module information
        void addAssessment(string title, string module, string text, DateTime dueDate, Boolean dueDateReached, int percentageComplete, List<INote> notes = null);//Procedure to create a assessment note and add it to the module note list
        void addAssessment(string title, string module, string text, DateTime date, string seat, string room, double duration, List<INote> notes = null);//Procedure to create a new assessment and add it to the module note list
        void addAssessment(IAssessment assessment);//Procedure to add an already created assessment to the module list
        void addNote(string title, string text, List<string> images = null, List<string> links = null);//Procedure to create a new note and add it to the module note list
        void addNote(INote note); //Procedure to add an already created note to the assessments note list
    }
    [Serializable()]//Added the Serializable attribute to all the class to be serialized by binaryformatter and saved
    public class Module : IModule, IComparable, IEquatable<IModule>
    {
        private string code;
        private string title;
        private string synopsis;
        private List<string> learningObjectives;
        private string fileName;
        private List<IAssessment> assessments;
        private List<INote> notes;

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

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

        public string Synopsis
        {
            get
            {
                return synopsis;
            }

            set
            {
                synopsis = value;
            }
        }

        public List<string> LearningObjectives
        {
            get
            {
                return learningObjectives;
            }

            set
            {
                learningObjectives = value;
            }
        }

        public string FileName
        {
            get
            {
                return fileName;
            }

            set
            {
                fileName = value;
            }
        }

        public List<IAssessment> Assessments
        {
            get
            {
                return assessments;
            }

            set
            {
                assessments = value;
            }
        }

        public List<INote> Notes
        {
            get
            {
                return notes;
            }

            set
            {
                notes = value;
            }
        }

        public Module(string code, string title, string synopsis, List<string> learningObjectives, string fileName = "", List<IAssessment> assessments = null, List<INote> notes = null)
        {
            this.Code = code;
            this.Title = title;
            this.Synopsis = synopsis;
            this.LearningObjectives = learningObjectives;
            this.FileName = fileName;
            if (assessments != null)
                this.Assessments = new List<IAssessment>(assessments);
            else
                this.Assessments = new List<IAssessment>();
            if (notes != null)
                this.Notes = new List<INote>(notes);
            else
                this.Notes = new List<INote>();
        }
        public void editInformation(string code, string title, string synopsis, List<string> learningObjectives, string fileName = "")
        {
            this.Code = code;
            this.Title = title;
            this.Synopsis = synopsis;
            this.LearningObjectives = learningObjectives;
            this.FileName = fileName;
        }
        public void addAssessment(string title, string module, string text, DateTime dueDate, Boolean dueDateReached, int percentageComplete, List<INote> notes = null)
        {
            Assessments.Add(new Assignment(title, module, text, dueDate, dueDateReached, percentageComplete, notes));
        }
        public void addAssessment(string title, string module, string text, DateTime date, string seat, string room, double duration, List<INote> notes = null)
        {
            Assessments.Add(new Test(title, module, text, date, seat, room, duration, notes));
        }
        public void addAssessment(IAssessment assessment)
        {
            Assessments.Add(assessment);
        }
        public void addNote(string title, string text, List<string> images = null, List<string> links = null)
        {
            Notes.Add(new Note(title, text, images, links));
        }
        public void addNote(INote note)
        {
            Notes.Add(note);
        }
        //functions to enable comparing 2 tests
        public int CompareTo(object obj)
        {
            if (obj is IModule)
                return this.Code.CompareTo((obj as IModule).Code);
            return 0;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            IModule objAsModule = obj as IModule;
            if (objAsModule == null) return false;
            else return Equals(objAsModule);
        }
        
        public bool Equals(IModule other)
        {
            
            if (this.Code == other.Code && this.Title == other.Title)
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
