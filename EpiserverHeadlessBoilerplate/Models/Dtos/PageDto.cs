using System;
using EPiServer.Core;
using EpiserverHeadlessBoilerplate.Models.Pages;

namespace EpiserverHeadlessBoilerplate.Models.Dtos
{
    public class PageDto<T> : IPageDto<T> where T : SitePageData
    {
        public PageDto(T currentPage)
        {
            CurrentPage = currentPage;
        }
        public T CurrentPage { get; private set; }
        public LayoutDto Layout { get; set; }
        public IContent Section { get; set; }
    }

    public static class PageDto
    {
        public static PageDto<T> Create<T>(T page) where T : SitePageData
        {
            return new PageDto<T>(page);
        }
    }
}