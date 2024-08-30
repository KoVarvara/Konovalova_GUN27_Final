using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Mechanics
{
    public abstract class CasinoGameBase
    {
        public abstract void PlayGame();

        public CasinoGameBase()
        {
            FactoryMethod();
        }

        //public event void OnWin();
        protected abstract void FactoryMethod();
        
    }
}
