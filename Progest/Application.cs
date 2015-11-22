using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parse;

namespace Progest
{
    public class Application
    {
        private Application instance;
         
        private Application()
        {
            ParseObject.RegisterSubclass <Software> ();
            ParseClient.Initialize(ParseApplicationId, ParseWindowsKey);
        }

        public string ParseApplicationId
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string ParseWindowsKey
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Application GetInstance()
        {
            if (instance == null)
                instance = new Application();

            return instance;
        }

        public void Close()
        {
            instance = null;
        }
    }
}