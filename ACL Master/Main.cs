using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Security.AccessControl;


/*ACL Tool by Kyle Gustafson is given away as freeware.  If you have paid money for it, you should try to get that money back.
 
 Coded using Microsoft Visual Studio Express 2012 for Windows Desktop.*/

namespace ACL_Master
{
    public partial class frmAclMaster : Form
    {
        public frmAclMaster()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string dC = Convert.ToString(tbDC.Text);
            //get the DC in order to be able to connect

            string oU = Convert.ToString(tbOU.Text);
            //Add "OU=" to the string so DirectoryServices can search for the OU needed

            string lDAP = "LDAP://" + dC + ":389/" + oU;
            //LDAP string needed for the OU where the security groups will be created

            string filePath = Convert.ToString(tbFilePath.Text);
            //convert the filepath provided to a user

            string groupBase = filePath.Replace(@"\\", "");
            //get the group base name to be used to create security groups in AD

            string groupBaseStr = null;
            

            if (groupBase.Length < 55)
            {
                groupBaseStr = groupBase;
                
            }
            else if (groupBase.Length > 55)
            {
                int groupBaseLength = groupBase.Length;
                int lengthDif = groupBaseLength - 56;
                string tempGroupBase = groupBase.Remove(0, lengthDif);
                string newGroupBase = tempGroupBase.Insert(0, "%");
                groupBaseStr = newGroupBase;
                
            }
            //check the number of characters in the group base name.  If it is too many characters, remove the excess characters and add in a % to indicate to the Tech that this has been done.

            string groupBaseName = groupBaseStr.Replace('\\', '.');
            //the base group name that will be used in AD for security groups

            string groupWrite = groupBaseName + (@" - W");
            //the write permission security group

            string groupWriteCN = "CN=" + Convert.ToString(groupWrite);
            //Add "CN=" so Directory Services can create the group in the specified OU
            
            string groupRead = groupBaseName + (@" - R");
            //the read permission security group

            string groupReadCN = "CN=" + Convert.ToString(groupRead);
            //Add "CN=" so Directory Services can create the group in the specified OU

            DirectoryEntry aclOu = new DirectoryEntry("LDAP://" + dC + ":389/" + oU);
            DirectoryEntry groupW = aclOu.Children.Add(groupWriteCN, "group");
            groupW.Properties["samAccountName"].Value = groupWrite;
            groupW.CommitChanges();
            //Create Write Security Group in AD
            DirectoryEntry groupR = aclOu.Children.Add(groupReadCN, "group");
            groupR.Properties["samAccountName"].Value = groupRead;
            groupR.CommitChanges();
            //Create Read Security Group in AD

            System.Threading.Thread.Sleep(60000);
            //wait to let the creation of the groups propogate to other DCs.
            
            System.IO.DirectoryInfo folderInfo = new System.IO.DirectoryInfo(filePath);
            DirectorySecurity folderSecurity = folderInfo.GetAccessControl();

            FileSystemAccessRule ruleR =
                new FileSystemAccessRule(groupRead,
                    FileSystemRights.Read |
                    FileSystemRights.ReadAndExecute |
                    FileSystemRights.ListDirectory,
                    InheritanceFlags.ContainerInherit |
                    InheritanceFlags.ObjectInherit,
                    PropagationFlags.None,
                    AccessControlType.Allow);

            folderSecurity.AddAccessRule(ruleR);
            folderInfo.SetAccessControl(folderSecurity);
            //Assign Read permissions on the folder for the Read Security Group

            FileSystemAccessRule ruleW =
                new FileSystemAccessRule(groupWrite,
                    FileSystemRights.Modify |
                    FileSystemRights.Read |
                    FileSystemRights.ReadAndExecute |
                    FileSystemRights.ListDirectory |
                    FileSystemRights.Write,
                    InheritanceFlags.ContainerInherit |
                    InheritanceFlags.ObjectInherit,
                    PropagationFlags.None,
                    AccessControlType.Allow);

            folderSecurity.AddAccessRule(ruleW);
            folderInfo.SetAccessControl(folderSecurity);
            //Assign Write permissions on the folder for the Write Security Group

            if (cBoxTraverse.Checked)
            {
                ListDirectories pathsList = new ListDirectories();  //call DirectoryHelper class to create the list of the parent file pathes
                List<string> parentPaths = pathsList.GetDirectories(filePath);
                parentPaths.RemoveAt(0); //removes the filePath (the full path provided) from the list as it should not receive list permissions
                foreach (string p in parentPaths)
                {
                    System.IO.DirectoryInfo folderInfoLR = new System.IO.DirectoryInfo(p);
                    DirectorySecurity folderSecurityLR = folderInfoLR.GetAccessControl();
                    FileSystemAccessRule ruleLR =
                                  new FileSystemAccessRule(groupRead,
                                  FileSystemRights.Traverse |
                                  FileSystemRights.ListDirectory |
                                  FileSystemRights.ReadAttributes |
                                  FileSystemRights.ReadExtendedAttributes |
                                  FileSystemRights.ReadPermissions,
                                  InheritanceFlags.None,
                                  PropagationFlags.None,
                                  AccessControlType.Allow);

                    folderSecurityLR.AddAccessRule(ruleLR);
                    folderInfoLR.SetAccessControl(folderSecurityLR);

                    System.IO.DirectoryInfo folderInfoLW = new System.IO.DirectoryInfo(p);
                    DirectorySecurity folderSecurityLW = folderInfoLW.GetAccessControl();
                    FileSystemAccessRule ruleLW =
                                  new FileSystemAccessRule(groupWrite,
                                  FileSystemRights.Traverse |
                                  FileSystemRights.ListDirectory |
                                  FileSystemRights.ReadAttributes |
                                  FileSystemRights.ReadExtendedAttributes |
                                  FileSystemRights.ReadPermissions,
                                  InheritanceFlags.None,
                                  PropagationFlags.None,
                                  AccessControlType.Allow);

                    folderSecurityLW.AddAccessRule(ruleLW);
                    folderInfoLW.SetAccessControl(folderSecurityLW);
                    //assigning list/traverse permissions to parent folders, so that groups can get into the folder.
                }
            }
                       
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
