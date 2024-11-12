using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Data
{
    public interface ISaveLoadService<T> 
    {
        void SaveData(T data, string identifier);


        void LoadData(string identifier)
        {

        }
       
    }
}
