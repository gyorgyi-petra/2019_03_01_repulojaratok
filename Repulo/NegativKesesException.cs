using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repulo
{
    class NegativKesesException : Exception
    {
        public NegativKesesException()
            : base("A keses sose lehet negativ"  )
        {

                
        }


    }
}
