using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Progest
{
    public class Software
    {
        private string code;
        private string label;
        private System.Collections.Generic.List<Progest.Release> releases;

        public Software(string code, string label)
        {
            this.code = code;
            this.label = label;
        }

        public string Code
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Label
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<Release> Releases
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<SoftwareModule> SoftwareModules
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}