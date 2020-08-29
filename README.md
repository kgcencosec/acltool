# ACL Tool

Back in my Sys Admin days, we had a pretty complicated permissions structure for Windows file shares at one job. I wrote this in my free time, not on the job, so I can give it away. I had thought about doing more with this project and improving it and maybe even giving away a compiled version...or selling it. None of those ever came to fruition and my career shifted directions. So, here we are years later and I would rather just give the code away. This is a tool I wrote to overcome assigning permissions in a complex Windows file share environment. I will warn you, this is one of the only two C# apps I have ever coded and I am not a developer. The other was for a college project. This is a basic Windows Form Application that will create a read and a write Security Group in AD, named after a file share path and then assign permissions to the shared folder accordingly. It was built to work in an Access Based Enumeration (ABE) enabled environment. It works with DFS* as well. 

# Usage
If you chek a box in the GUI to Traverse parent directories, it will create 'traverse' (read and execute on the folder ONLY) permissions for the groups on parent folders in the file share path. It takes three inputs:

1. Domain Controller (or the FQDN of the Active Directory Domain). Example: domain.dc.com
2. OU (Organization Unit) in distinguishedName format. Example: OU=Folders,OU=Base,DC=domain,DC=dc,DC=com
3. File Path. This is the path to the file share you want to set permissions on. Example: \windows\file\share

# IMPORTANT Notes
This is a functional program, but it never made it out of Beta and has a few quirks that I never got around to addressing. Mostly it is just that it doesn't report progress (I started working on this and never finished) and it takes a LONG time to assign traversal permissions. Depending on your storage IO capabilities underlying your file share and how deep in the structure this is used, it can take some time. I don't mean run it and go grab a coffee long time. I mean run it and go grab lunch. You will want to verify it applied correctly on the file share. You will see the groups in AD almost immediately and can populate them accordingly though. I hope someone out there that is still running a windows file share environment some

*Note 1: If you use DFS, you will need to add the groups to be able to access DFS or nest them in a group that does.
*Note 2. You will need to compile it and sign it to run (or ignore the smart check warning at install).
