using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10.Interfaces
{
    public interface IMessage
    {
        void ShortAlert(string message);
        void LongAlert(string message);
    }
}
