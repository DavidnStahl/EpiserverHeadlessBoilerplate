using System;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;

namespace EpiserverHeadlessBoilerplate.Business
{
    public static class PageTypeExtensions
    {
        public static PageType GetPageType(this Type pageType)
        {
            var pageTypeRepository = ServiceLocator.Current.GetInstance<IContentTypeRepository<PageType>>();

            return pageTypeRepository.Load(pageType);
        }
    }
}