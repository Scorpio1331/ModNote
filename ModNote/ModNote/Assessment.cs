using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModNote
{
    public interface IAssessment
    {
        string Title //String Title for the Assessment, must be unique to each List
        {
            get;
            set;
        }
        string Module //String Module to store the Module Code
        {
            get;
            set;
        }
        string Text //String Text for the note
        {
            get;
            set;
        }
        DateTime Date //DateTime for the Assessments due date
        {
            get;
            set;
        }
        List<INote> Notes //List of Note interface, to allow any class that inherits the interface to be stored
        {
            get;
            set;
        }
        void addNote(string title, string text, List<string> images = null, List<string> links = null); //Procedure to create a new note and add it to the assessments note list
        void addNote(INote note); //Procedure to add an already created note to the assessments note list
    }

    public interface IAssignment : IAssessment
    {
        
        Boolean DueDateReached //Boolean DueDateReached to store whether the due date has been reached or not
        {
            get;
            set;
        }
        int PercentageComplete //Integer PercentageComplete to store how much of the program is complete
        {
            get;
            set;
        }
        void editInformation(string title, string module, string text, DateTime dueDate, Boolean dueDateReached, int percentageComplete); //Procedure to edit the Assignsments information
    }

    public interface ITest : IAssessment
    {
        string Seat //String Seat for where the user will sit in the test
        {
            get;
            set;
        }
        string Room //String Room for where the test will be
        {
            get;
            set;
        }
        double Duration //Double Duration to store how long the test will last
        {
            get;
            set;
        }
        void editInformation(string title, string module, string text, DateTime date, string seat, string room, double duration);//Procedure to edit the tests information
    }

    [Serializable()] //Added the Serializable attribute to all the class to be serialized by binaryformatter and saved
    public class Assignment : IAssignment, IComparable, IEquatable<IAssignment>
    {
        private string title;
        private string module;
        private string text;
        private List<INote> notes;
        private DateTime date;
        private Boolean dueDateReached;
        private int percentageComplete;

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

        public string Module
        {
            get
            {
                return module;
            }

            set
            {
                module = value;
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

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public bool DueDateReached
        {
            get
            {
                return dueDateReached;
            }

            set
            {
                dueDateReached = value;
            }
        }

        public int PercentageComplete
        {
            get
            {
                return percentageComplete;
            }

            set
            {
                percentageComplete = value;
            }
        }

        public Assignment(string title, string module, string text, DateTime dueDate, Boolean dueDateReached, int percentageComplete, List<INote> notes = null)
        {            
            this.Title = title;
            this.Module = module;
            this.Text = text;
            this.Date = dueDate;
            this.DueDateReached = dueDateReached;
            this.PercentageComplete = percentageComplete;
            if (notes != null)
                this.Notes = new List<INote>(notes);
            else
                this.Notes = new List<INote>();
        }

        public void addNote(string title, string text, List<string> images = null, List<string> links = null)
        {
            Notes.Add(new Note(title, text, images, links));
        }
        public void addNote(INote note)
        {
            Notes.Add(note);
        }

        public void editInformation(string title, string module, string text, DateTime dueDate, Boolean dueDateReached, int percentageComplete)
        {
            this.Title = title;
            this.Module = module;
            this.Text = text;
            this.Date = dueDate;
            this.DueDateReached = dueDateReached;
            this.PercentageComplete = percentageComplete;
            this.Notes = notes;
        }
        //functions to enable comparing 2 assignments
        public int CompareTo(object obj)
        {
            if (obj is IAssignment)
                return this.Title.CompareTo((obj as IAssignment).Title) + this.Module.CompareTo((obj as IAssignment).Module);
            return 0;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            IAssignment objAsAssignment = obj as IAssignment;
            if (objAsAssignment == null) return false;
            else return Equals(objAsAssignment);
        }
        public bool Equals(IAssignment other)
        {
            if (this.Module == other.Module && this.Title == other.Title)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    [Serializable()]//Added the Serializable attribute to all the class to be serialized by binaryformatter and saved
    public class Test : ITest, IComparable, IEquatable<ITest>
    {
        private string title;
        private string module;
        private string text;
        private List<INote> notes;
        private DateTime date;
        private string seat;
        private string room;
        private double duration;

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

        public string Module
        {
            get
            {
                return module;
            }

            set
            {
                module = value;
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

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Seat
        {
            get
            {
                return seat;
            }

            set
            {
                seat = value;
            }
        }

        public string Room
        {
            get
            {
                return room;
            }

            set
            {
                room = value;
            }
        }

        public double Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }

        public Test(string title, string module, string text, DateTime date, string seat, string room, double duration, List<INote> notes = null)
        {
            this.Title = title;
            this.Module = module;
            this.Text = text;
            this.Date = date;
            this.Seat = seat;
            this.Room = room;
            this.Duration = duration;
            if (notes != null)
                this.Notes = new List<INote>(notes);
            else
                this.Notes = new List<INote>();
        }

        public void editInformation(string title, string module, string text, DateTime date, string seat, string room, double duration)
        {
            this.Title = title;
            this.Module = module;
            this.Text = text;
            this.Date = date;
            this.Seat = seat;
            this.Room = room;
            this.Duration = duration;
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
            if (obj is ITest)
                return this.Title.CompareTo((obj as ITest).Title) + this.Module.CompareTo((obj as ITest).Module);
            return 0;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            ITest objAsTest = obj as ITest;
            if (objAsTest == null) return false;
            else return Equals(objAsTest);
        }
        public bool Equals(ITest other)
        {
            if (this.Module == other.Module && this.Title == other.Title)
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
