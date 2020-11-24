using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverHeadlessBoilerplate.Models.Pages
{
    [ContentType(
        DisplayName = "StartPage",
        GUID = "14DE5969 - CEA7 - 401D - 91B1 - 31917B1F4189",
        GroupName = Global.GroupNames.Specialized
    )]
    [AvailableContentTypes( ExcludeOn = new[] { typeof(StartPage) })]
    public class StartPage : SitePageData
    {        
    }
}