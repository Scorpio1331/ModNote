using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ModNote
{
    public partial class FrmMain : Form
    {

        /// <summary>
        /// Create variables and properties to store settings and allow access outside the form
        /// </summary>
        private bool autoLoadModules;
        public List<string> savedModules;
        public bool AutoLoadModules
        {
            get
            {
                return autoLoadModules;
            }

            set
            {
                autoLoadModules = value;
            }
        }
        public List<string> SavedModules
        {
            get
            {
                return savedModules;
            }

            set
            {
                savedModules = value;
            }
        }

        /// <summary>
        /// Create Variable and property to store loaded modules and allow access outside the form
        /// </summary>
        private List<IModule> modules;
        public List<IModule> Modules
        {
            get { return modules; }
            set { modules = value; }
        }
        
        private bool viewingAllAssessments;
        private bool sorted;

        /// <summary>
        /// Initialize form and variables
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            Modules = new List<IModule>();
            SavedModules = new List<string>();
            viewingAllAssessments = false;
        }        

        /// <summary>
        /// On form load Call procedure to deserialize settings then check
        /// if user had auto-load modules selected, call deserialize modules procedure
        /// </summary>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            DeserializeSettings();
            if (AutoLoadModules) //If user has chosen to Autoload modules call DeserializeModules procedure
                DeserializeModules();
        }

        /// <summary>
        /// On Add Module click, create form to ask user whether to manually create a module from scratch or import one from a file
        /// then add that module to the list and create nodes for the module and its assessments
        /// </summary>
        private void AddModuleBtn_Click(object sender, EventArgs e)
        {
            FrmModuleAdder addModuleChoice = new FrmModuleAdder();
            FrmModuleDetails addModule; //Create forms to ask for user choice and modules details
            addModuleChoice.ShowDialog();
            if (addModuleChoice.DialogResult == DialogResult.OK) //If user chooses to import a file, initialize ModuleDetails form to open a file dialog
            {
                addModule = new FrmModuleDetails(true,this);

            }
            else if (addModuleChoice.DialogResult == DialogResult.Yes) //or if the user chooses to manually create a module, initialize the form as blank
            {
                addModule = new FrmModuleDetails(false,this);
            }
            else return; //if user cancels then exit out of the procedure

            addModule.ShowDialog();
            if (addModule.DialogResult == DialogResult.OK) //if save button is clicked, add it to the list and create nodes for it and its assessments
            {
                IModule module = addModule.Module;
                Modules.Add(module); //Add new module to list
                TreeNode moduleNode = new TreeNode();
                moduleNode.Name = module.Code;
                moduleNode.Text = module.Title; //Create Node for module
                foreach (IAssessment assessment in module.Assessments)
                {
                    TreeNode assessmentNode = new TreeNode(); //Loop through the modules assessments creating a node for each one
                    assessmentNode.Name = assessment.Module + "..." + assessment.Title; //Add three periods between module code and assessment title to store both
                    assessmentNode.Text = assessment.Title; //in allowing for comparisons later
                    moduleNode.Nodes.Add(assessmentNode); //add the node to the modules node
                }
                TrVwModulesList.Nodes.Add(moduleNode); //Add module node to module treeview and call AddUpcomingAssessments procedure with module as a parameter
                AddUpcomingViewAllAssessments(module); //to check if any of the modules assessments are upcoming and create nodes for them on the upcoming treeview
            }            
        }
               

        /// <summary>
        /// Procedure to check modules assessments for any that has its date in 2 weeks, and create nodes for them and add them to 
        /// the Upcoming Assessments treeview
        /// or if view all assessments clicked then create nodes for each assessment of the module and add them to the treeview
        /// </summary>
        /// <param name="module">Module to check assessments for</param>
        private void AddUpcomingViewAllAssessments(IModule module)
        {
            foreach (IAssessment assessment in module.Assessments) //Loop through each of the modules assessments
            {                
                if (!viewingAllAssessments && assessment.Date.Date.CompareTo(DateTime.Now.Date) >= 0 && assessment.Date.Date.CompareTo(DateTime.Now.Date.AddDays(14)) <= 0)
                    TrVwUpcomingAssessments.Nodes.Add(AddAssessmentNode(assessment)); //If assessments date is between the current date and the current date + 14 days (2 weeks) then create node    
                else if (viewingAllAssessments)
                    TrVwUpcomingAssessments.Nodes.Add(AddAssessmentNode(assessment)); //or if viewing all assessments then add all create nodes for each assessment
            }
        }

        /// <summary>
        ///  Procedure to check assessment if its date is in 2 weeks, and create nodes for it and add it 
        /// the Upcoming Assessments treeview
        /// </summary>
        /// <param name="assessment">Assessment to add</param>
        private void AddUpcomingViewAllAssessments(IAssessment assessment)
        {
            if (assessment.Date.CompareTo(DateTime.Now) >= 0 && assessment.Date.CompareTo(DateTime.Now.AddDays(14)) <= 0)
            { //If assessments date is between the current date and the current date + 14 days (2 weeks) then create node  
                TrVwUpcomingAssessments.Nodes.Add(AddAssessmentNode(assessment)); //Call AddAssessmentNodeProcedure and pass assessment as parameter and add resulting node to treeview
            }
        }
        /// <summary>
        /// Function to create a Tree node for an assessment and return it
        /// </summary>
        /// <param name="assessment">Assessment to create a tree node for</param>
        /// <returns>Assessment Tree node</returns>
        private TreeNode AddAssessmentNode(IAssessment assessment)
        {
            TreeNode assessmentNode = new TreeNode(); 
            assessmentNode.Name = assessment.Module + "..." + assessment.Title;
            assessmentNode.Text = assessment.Title; //Create node
            if (!viewingAllAssessments) //If not viewing all assessments add due in days to text
            {
                assessmentNode.Text += "  Due in: " + (assessment.Date - DateTime.Now.Date).Days + " Days";
            }
            assessmentNode.Tag = (assessment.Date - DateTime.Now.Date).Days; //Add due in days to tag for sorting later
            return assessmentNode; //Return new node
        }
        /// <summary>
        /// On double clicking on a node in the module tree view check what level the node is
        /// and then open a details form for clicked node
        /// </summary>
        private void ModulesListTrVw_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            IModule module; //Create variable to store module
            
            switch (e.Node.Level) //Switch to check nodes level
            {
                case 0: //If level is 0 a module node is clicked, find corrosponding module by searching module list with Module code
                    module = modules.Find(item => item.Code == e.Node.Name);
                    if (module == null) //If module is null break out of switch
                        break;
                    module = EditModule(module); //Call function to edit module
                    if (module == null) //If module is null break out of switch
                        break;
                    e.Node.Nodes.Clear(); //Clear modules assessment nodes
                    e.Node.Name = module.Code;
                    e.Node.Text = module.Title; //Ensure code and title are up to date
                    foreach (IAssessment moduleAssessment in module.Assessments)
                    {
                        e.Node.Nodes.Add(AddAssessmentNode(moduleAssessment)); //Call function to create node for each assessment
                        removeAssessmentNodes(moduleAssessment.Module, moduleAssessment.Title); //Call procedure to check if assessment was on upcoming assessment treeview
                    }                                                               //and remove it 
                    AddUpcomingViewAllAssessments(module); //Call procedure to readd assessments if they had changed
                    break;
                case 1:
                    module = modules.Find(item => item.Code == e.Node.Parent.Name); //If level is 1 then assessment node is clicked, find its owning module
                    IAssessment assessment = module.Assessments.Find(item => item.Title == e.Node.Text); //use owning module to find corrosponding assessment
                    if (assessment == null)
                        break; 
                    removeAssessmentNodes(assessment.Module, assessment.Title);
                    assessment = EditAssessment(module, assessment); //Call function to edit assessment
                    if (assessment == null)
                        break;
                    e.Node.Name = assessment.Module + "..." + assessment.Title;
                    e.Node.Text = assessment.Title; //ensure nodes details are up to date
                    AddUpcomingViewAllAssessments(assessment);
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// On double clicking on a node in the upcoming assessments tree view open details form for clicked node
        /// </summary>
        private void TrVwUpcomingAssessments_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            IModule module = modules.Find(item => item.Code == e.Node.Name.Split(new string[] { "..." }, StringSplitOptions.RemoveEmptyEntries)[0]); //Find owning module by splitting the module code from node name
            IAssessment assessment = module.Assessments.Find(item => item.Title == e.Node.Text.Split(new string[] { "  Due in:" }, StringSplitOptions.RemoveEmptyEntries)[0]); //Find corrosponding assessment by splitting title from node text
            TreeNode moduleNode = TrVwModulesList.Nodes[TrVwModulesList.Nodes.IndexOfKey(module.Code)]; //Get Owning modules node on module treeview
            TreeNode assessmentNode = moduleNode.Nodes[moduleNode.Nodes.IndexOfKey(assessment.Module + "..." + assessment.Title)]; //Get assessments node on module treeview
            assessment = EditAssessment(module, assessment); //Call function to edit assessment
            if (assessment == null)
                return;
            assessmentNode.Name = assessment.Module + "..." + assessment.Title;
            assessmentNode.Text = assessment.Title; //Update information on all nodes
            e.Node.Name = assessment.Module + "..." + assessment.Title;
            e.Node.Text = assessment.Title;
        }
        /// <summary>
        /// Function to open form to edit assessments details and return the new assessment
        /// </summary>
        /// <param name="module">Module the assessment belongs to</param>
        /// <param name="assessment">Assessment to be edited</param>
        /// <returns>edited assessment or null if canceled</returns>
        private IAssessment EditAssessment(IModule module, IAssessment assessment)
        {
            FrmAssessmentDetails assessmentDetailsFrm = new FrmAssessmentDetails(assessment); //Initialize assesment details form with assessment to edit
            assessmentDetailsFrm.ShowDialog();
            if (assessmentDetailsFrm.DialogResult == DialogResult.Cancel) //if canceled return null
                return null;
            module.Assessments.Remove(assessment);
            assessment = assessmentDetailsFrm.Assessment;
            module.Assessments.Add(assessment);
            return assessment; //return assesment
        }
        /// <summary>
        /// Procedure used to search whether upcoming assessments treeview contains an assessment and delete its node
        /// </summary>
        /// <param name="moduleCode">Modules code to use to search for node</param>
        /// <param name="assessmentTitle">Assessments title to use to search for node</param>
        private void removeAssessmentNodes(string moduleCode, string assessmentTitle)
        {
            if (TrVwUpcomingAssessments.Nodes.ContainsKey(moduleCode + "..." + assessmentTitle))
                TrVwUpcomingAssessments.Nodes.RemoveByKey(moduleCode + "..." + assessmentTitle); //If treeview contains node with that name then remove it
        }
        /// <summary>
        /// Function to open form to edit modules details and return the new module
        /// </summary>
        /// <param name="module">Module to be edited</param>
        /// <returns>Edited module or null if canceled</returns>
        private IModule EditModule(IModule module)
        {
            FrmModuleDetails moduleDetailsFrm = new FrmModuleDetails(module); //Initialize module details form with module to edit
            moduleDetailsFrm.ShowDialog();
            if (moduleDetailsFrm.DialogResult == DialogResult.Cancel) //If canceled return null
                return null;

            return moduleDetailsFrm.Module; //Return edited module
        }

        /// <summary>
        /// On clicked DeleteModule get selected node and remove module from list and treeview
        /// </summary>
        private void DeleteModuleBtn_Click(object sender, EventArgs e)
        {
            TreeNode node = TrVwModulesList.SelectedNode; //Get selected node                
            if (node != null && node.Level == 0) //if nodes level is 0 it is module node
            {

                Modules.RemoveAt(TrVwModulesList.Nodes.IndexOf(node)); //remove module from list
                foreach (TreeNode assessmentNode in node.Nodes) //loop through each node the selected node contains 
                {
                    TrVwUpcomingAssessments.Nodes.RemoveByKey(assessmentNode.Name); //remove assessment nodes  from upcoming assessment treeview
                }
                TrVwModulesList.Nodes.Remove(node); //remove selected node from treeview
            }
            else if (node != null && node.Level > 0) //if node is greater than level 1
            {
                while (node.Parent != null) //Loop and get parent until node is most toplevel node
                {
                    node = node.Parent;
                }
                Modules.RemoveAt(TrVwModulesList.Nodes.IndexOf(node)); //remove module from list
                foreach (TreeNode assessmentNode in node.Nodes) //loop through each node the selected node contains 
                {
                    TrVwUpcomingAssessments.Nodes.RemoveByKey(assessmentNode.Name); //remove assessment nodes  from upcoming assessment treeview
                }
                TrVwModulesList.Nodes.Remove(node);    //remove node from treeview
            }
        }

        /// <summary>
        /// On closing form/Clicking save modules button call functions to serialize modules and settings to files
        /// </summary>
        private void FrmMain_Closed(object sender, EventArgs e)
        {
            SerializeSettings();
            SerializeModules();
        }
        /// <summary>
        /// Procedure to serialize each module to a file
        /// </summary>
        private void SerializeModules()
        {
            try
            {
                using (Stream fileStream = File.Open("data.xml", FileMode.Create)) //Create new data file and overwrite old one if it exists
                {
                    BinaryFormatter moduleSerializer = new BinaryFormatter();//Initialize binaryFormatter to serialize modules data
                    foreach (IModule module in Modules)
                    {
                        moduleSerializer.Serialize(fileStream, module); //Loop through modules list and serialize each module
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Procedure to serialize user settings to a file
        /// </summary>
        private void SerializeSettings()
        {
            try
            {
                using (Stream fileStream = File.Open("userSettings.xml", FileMode.Create)) //Create new userfile and overwrite old one if it exists
                {
                    BinaryFormatter settingsSerializer = new BinaryFormatter(); //Initialize binaryFormatter to serialize setting data
                    settingsSerializer.Serialize(fileStream, AutoLoadModules); //serialize autoload setting and loop through savedmodules and serialize each one
                    foreach (string module in SavedModules)
                    {
                        settingsSerializer.Serialize(fileStream, module);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Procedure to open data file if it exists and deserialize all the module data and add the modules to the list
        /// </summary>
        private void DeserializeModules()
        {
            try
            {
                if (!File.Exists("data.xml")) throw new Exception("No modules have been saved."); //Check if file exists, if not throw exception
                using (Stream fileStream = File.Open("data.xml", FileMode.Open)) //Open data file
                {
                    BinaryFormatter moduleSerializer = new BinaryFormatter(); //Initialize binaryFormatter to deserialize modules data
                    while (fileStream.Position != fileStream.Length) //while not at end of file
                    {
                        object obj = moduleSerializer.Deserialize(fileStream); //deserialize module and store in object
                        if (obj != null)
                        {
                            IModule module = (IModule)obj; //if obj is not null convert to module
                            if (Modules.Contains(module) || !SavedModules.Contains(module.Title+"..."+module.Code)) //if module list already contains module 
                                continue;                                               // or savedModules does not contain the module continue to next loop
                            Modules.Add(module);                            
                            TreeNode moduleNode = new TreeNode(); //Add module to list and create node 
                            moduleNode.Name = module.Code;
                            moduleNode.Text = module.Title;
                            foreach (IAssessment assessment in module.Assessments)
                            {
                                TreeNode assessmentNode = new TreeNode();
                                assessmentNode.Name = assessment.Module + "..." + assessment.Title;
                                assessmentNode.Text = assessment.Title;
                                moduleNode.Nodes.Add(assessmentNode); //Create assessment node and add to module node
                            }
                            TrVwModulesList.Nodes.Add(moduleNode); //add module node to treeview and call procedure to add upcoming assessments
                            AddUpcomingViewAllAssessments(module);
                        }
                        else break;
                    }
                    SortAssessments(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Procedure to deserialize saved settings and store them in variables
        /// </summary>
        private void DeserializeSettings()
        {
            try
            {
                if (!File.Exists("userSettings.xml")) return; //If file doesnt exist exit procedure
                using (Stream fileStream = File.Open("userSettings.xml", FileMode.Open))
                {
                    BinaryFormatter settingsSerializer = new BinaryFormatter(); //Initialize binaryFormatter to deserialize setting data
                    while (fileStream.Position != fileStream.Length) //While not at end of file
                    {
                        object obj = settingsSerializer.Deserialize(fileStream); //Deserialize first object
                        if (obj != null)
                        {
                            if (obj is bool) //If obj is not null and is a boolean object, store the value in AutoLoadModules
                                AutoLoadModules = (bool)obj;
                            else if (obj is string)
                            {
                                string module = (string)obj;
                                if (SavedModules.Contains(module)) //If obj is a string object, check if SavedModules already contains it, if so move
                                    continue;                      //onto next loop, else add to list
                                SavedModules.Add(module);
                            }
                        }
                        else break;
                    }
                }                
            }
            catch (Exception ex) //Catch any error and tell user what happened
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// On view all button clicked change treeview to show all assessments or just upcoming ones
        /// </summary>
        private void TlStrpBtnViewAll_Click(object sender, EventArgs e)
        {
            if (!viewingAllAssessments) //If not showing all assessments then change treeview and label
            {
                viewingAllAssessments = true;
                LblUpComingAssessments.Text = "All Assessments";
                TlStrpBtnViewAll.Text = "View upcoming Assessments";
                
            } else //else change treeview to show just upcoming assessments
            {
                viewingAllAssessments = false;
                LblUpComingAssessments.Text = "Upcoming Assessments";
                TlStrpBtnViewAll.Text = "View all Assessments";                
            }
            TrVwUpcomingAssessments.Nodes.Clear(); //Clear all current nodes
            foreach (IModule module in Modules)
            {
                AddUpcomingViewAllAssessments(module); //Add assessment nodes for each module
            }
            sorted = false;
        }
        
        /// <summary>
        /// On clicking either delete assessment button get corrosponding assessment and remove it from module and remove its nodes
        /// </summary>
        private void TlStrpBtnDeleteAssessment_Click(object sender, EventArgs e)
        {
            ToolStripButton clickedBtn = sender as ToolStripButton;
            TreeNode node;
            IModule module;
            IAssessment assessment; //Create variables to hold node, module, assessment and get which button was clicked
            if (clickedBtn.Name.Contains("Mdl")) //if the button was on the module treeview toolstrip
            {
                if (TrVwModulesList.SelectedNode != null && TrVwModulesList.SelectedNode.Level < 1)//if module treeview selected node is module exit procedure
                {
                    MessageBox.Show("Please select an assessment first");
                    return;
                }
                node = TrVwModulesList.SelectedNode; //get selected module treeview node
            }
            else //else get upcoming assessments treeview selected node
            {
                if (TrVwUpcomingAssessments.SelectedNode != null)
                    node = TrVwUpcomingAssessments.SelectedNode;
                else
                {
                    MessageBox.Show("Please select an assessment first");
                    return;
                }
                              
            }
            module = modules.Find(item => item.Code == node.Name.Split(new string[] { "..." }, StringSplitOptions.RemoveEmptyEntries)[0]);
            if (!node.Text.Contains("  Due in:")) //Get owning module and find assessment by splitting text
                assessment = module.Assessments.Find(item => item.Title == node.Text);
            else
                assessment = module.Assessments.Find(item => item.Title == node.Text.Split(new string[] { "  Due in:" }, StringSplitOptions.RemoveEmptyEntries)[0]);
            if (assessment == null)
                return;
            module.Assessments.Remove(assessment); //remove assessment from module
            TrVwModulesList.Nodes[TrVwModulesList.Nodes.IndexOfKey(module.Code)].Nodes.RemoveByKey(assessment.Module + "..." + assessment.Title);
            TrVwUpcomingAssessments.Nodes.RemoveByKey(assessment.Module + "..." + assessment.Title); //remove nodes from both treeviews

        }
        /// <summary>
        /// On click show settings form as dialog
        /// </summary>
        private void TlStrpBtnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings settingsFrm = new FrmSettings(this);
            settingsFrm.ShowDialog(); //Create new settings form as dialog with its owner being this form. then show to user
        }

        /// <summary>
        /// On clicking assessment sort button, get all assessment nodes and use recursive quicksort to
        /// sort by due date
        /// </summary>
        private void SortAssessments(object sender, EventArgs e)
        {
            if (sorted)
                return;
            TreeNodeCollection assessmentNodes = TrVwUpcomingAssessments.Nodes; //Create collection to reference nodes
            TreeNode[] nodes = new TreeNode[assessmentNodes.Count]; //Create and initialize new treenode array to hold nodes
            assessmentNodes.CopyTo(nodes, 0); //Copy nodes to new array            
            nodes = RecursiveQuickSort(nodes, 0, assessmentNodes.Count ); //Call Recursive quicksort function   
            assessmentNodes.Clear();
            assessmentNodes.AddRange(nodes); //Clear nodes and then add nodes back in order
            sorted = true;
        }
        /// <summary>
        /// Uses a pivot to move items into order     
        /// </summary>
        /// <param name="nodes">Array holding Treenodes to sort</param>
        /// <param name="left">Left pivot pointer</param>
        /// <param name="right">Right pivot pointer</param>
        /// <returns>Returns the left pointer</returns>
        private int Partition(TreeNode[] nodes, int left, int right)
        {
            int start = left;
            TreeNode pivot = nodes[start]; //choose leftmost item as pivot
            left++;
            right--;
            while (true)
            {
                while (left <= right && (int)nodes[left].Tag <= (int)pivot.Tag) //increment Left pointer until the node on the left has a higher/equal amount of days than the pivot
                    left++;
                while (left <= right && (int)nodes[right].Tag > (int)pivot.Tag) //decrement the right pointer until the node to the right has a lower amount of days than the pivot.  
                    right--;

                if (left > right) //if left pointer is higher than right pointer then swap nodes and return left pointer
                {
                    nodes[start] = nodes[left - 1];
                    nodes[left - 1] = pivot;
                    return left;
                }                    
                TreeNode temp = nodes[left];
                nodes[left] = nodes[right];
                nodes[right] = temp;
            }
        }
        /// <summary>
        /// recursively calls itself to sort a treenode collection by date using the partition function
        /// </summary>
        /// <param name="nodes">Array holding Treenodes to sort</param>
        /// <param name="left">Left pivot pointer</param>
        /// <param name="right">Right pivot pointer</param>
        /// <returns>returns treenode array</returns>
        private TreeNode[] RecursiveQuickSort(TreeNode[] nodes, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(nodes, left, right); //Call Partition function and store right pointer as pivot
                    RecursiveQuickSort(nodes, left, pivot-1); //recursively call self and use pivot as new right
                    RecursiveQuickSort(nodes, pivot, right);//recursively call self and use pivot as new left
            }
            return nodes; //Return node array
        }        

        /// <summary>
        /// On Clicking Load Modules button call procedure to load modules from a file
        /// </summary>
        private void TlStrpBtnLoadModules_Click(object sender, EventArgs e)
        {
            DeserializeModules();
        }

        /// <summary>
        /// On Clicking Save Settings button call procedure to save user settings to a file
        /// </summary>
        private void TlStrpBtnLoadSettings_Click(object sender, EventArgs e)
        {
            DeserializeSettings();
        }
    }
}
