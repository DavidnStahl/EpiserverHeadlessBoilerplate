using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EpiserverHeadlessBoilerplate.Models.Dtos;
using EpiserverHeadlessBoilerplate.Models.Pages;

namespace EpiserverHeadlessBoilerplate.Business
{
    public class PageViewContextFactory
    {
        private readonly IContentLoader _contentLoader;

        private readonly IContentRepository _contentRepository;

        public PageViewContextFactory(IContentLoader contentLoader, IContentRepository contentRepository)
        {
            _contentLoader = contentLoader;
            _contentRepository = contentRepository;
        }

        public virtual LayoutDto CreateLayoutModel(ContentReference currentContentLink, RequestContext requestContext)
        {
            return new LayoutDto
            {
                StartPages = GetStartPages(),
                StartPage = _contentLoader.Get<StartPage>(SiteDefinition.Current.StartPage)
            };
        }

        public virtual IContent GetSection(ContentReference contentLink)
        {
            var currentContent = _contentLoader.Get<IContent>(contentLink);
            if (currentContent.ParentLink != null && currentContent.ParentLink.CompareToIgnoreWorkID(SiteDefinition.Current.StartPage))
            {
                return currentContent;
            }

            return _contentLoader.GetAncestors(contentLink)
                .OfType<PageData>()
                .SkipWhile(x => x.ParentLink == null || !x.ParentLink.CompareToIgnoreWorkID(SiteDefinition.Current.StartPage))
                .FirstOrDefault();
        }


        private IEnumerable<StartPage> GetStartPages() => 
            _contentRepository.GetChildren<StartPage>(SiteDefinition.Current.RootPage, new LoaderOptions { LanguageLoaderOption.MasterLanguage() });


    }
}