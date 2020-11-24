using EpiserverHeadlessBoilerplate.Models.Pages;
using System.Collections.Generic;

namespace EpiserverHeadlessBoilerplate.Models.Dtos
{
    public class LayoutDto
    {
        public StartPage StartPage { get; set; }

        public IEnumerable<StartPage> StartPages { get; set; }
    }
}