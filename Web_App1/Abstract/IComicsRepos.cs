using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_App1.Models;

namespace Web_App1.Abstract
{
    public interface IComicsRepos
    {
        IEnumerable<comics> Comics { get; }
    }
}
