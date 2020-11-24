using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiserverHeadlessBoilerplate.Models.Blocks.Interfaces
{
    public interface IBlock <T> where T : SiteBlockData
    {
    }
}
