using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.IO;

namespace ACL_Master
{
    class ListDirectories
    {
        public List<string> GetDirectories(string path)
        {
            List<string> list = new List<string>();

            if (!string.IsNullOrEmpty(path))
            {
                if (path.Last() != '\\')
                {
                    path += "\\";
                }

                EnumerateDictories(list, path);
            }

            return list;
        }

        private void EnumerateDictories(IList<string> results, string path)
        {
            var parent = Directory.GetParent(path);

            if (parent != null)
            {
                EnumerateDictories(results, parent.FullName);

                results.Add(parent.FullName);
            }
        }
    }
}
