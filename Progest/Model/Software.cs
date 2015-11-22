using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parse;

namespace Progest
{
    [ParseClassName("Software")]
    public class Software : ParseObject
    {
        private string code;
        private string label;
        private System.Collections.Generic.List<Progest.Release> releases;

        public Software()
        {

        }

        public Software(string code, string label)
        {
            this.code = code;
            this.label = label;
        }

        [ParseFieldName("code")]
        public string Code
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("label")]
        public string Label
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
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