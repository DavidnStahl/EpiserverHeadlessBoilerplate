using EpiserverHeadlessBoilerplate.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverHeadlessBoilerplate.Business
{
    public interface IModifyLayout
    {
        void ModifyLayout(LayoutDto layoutDto);
    }
}