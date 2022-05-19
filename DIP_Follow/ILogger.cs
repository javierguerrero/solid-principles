using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Follow
{
    public interface ILogger
    {
        void Write(Activity activity);
    }
}
