using EPiServer.Core;
using EpiserverHeadlessBoilerplate.Models.Pages;

namespace EpiserverHeadlessBoilerplate.Models.Dtos
{
    public interface IPageDto<out T> where T : SitePageData
    {
        T CurrentPage { get; }
        LayoutDto Layout { get; set; }
        IContent Section { get; set; }
    }
}
