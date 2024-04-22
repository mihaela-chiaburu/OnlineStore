using eUseControl.BuisnessLogic.Interfaces;
using eUseControl.BuisnessLogic.MainBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BuisnessLogic
{
    public class BuisnessLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
    }
}
