using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnmanagedLayerBulkRemover
{
    public class SolutionItem
    {
        public string UniqueName { get; set; }
        public string FriendlyName { get; set; }
        public string Version { get; set; }
        public string IsManaged { get; set; }
    }

    public class LogLine
    {
        public LogLine(string text, Color color)
        {
            this.Text = text;
            this.Color = color;
        }
        public string Text { get; set; }
        public Color Color { get; set; }
    }
}
