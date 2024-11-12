using Final.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Mechanics
{
    internal interface IBuilderSupporter<ISaveLoadService>
    {
        void BuildService(ISaveLoadService service);

        void BuildCustom(CasinoGameBase[] customClasses);
    }
}
