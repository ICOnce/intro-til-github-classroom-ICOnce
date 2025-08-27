using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class demo
    {
        public int LineAmount {  get; set; }
        public string LineContent { get; set; }

        public demo(int lineAmount, string lineContent)
        {
            LineAmount = lineAmount;
            LineContent = lineContent;
        }
    }
}
