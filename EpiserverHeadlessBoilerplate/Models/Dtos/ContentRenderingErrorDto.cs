using System;
using EPiServer;
using EPiServer.Core;

namespace EpiserverHeadlessBoilerplate.Models.Dtos
{
    public class ContentRenderingErrorDto
    {
        public ContentRenderingErrorDto(IContentData contentData, Exception exception)
        {
            var content = contentData as IContent;
            if (content != null)
            {
                ContentName = content.Name;
            }
            else
            {
                ContentName = string.Empty;
            }

            ContentTypeName = contentData.GetOriginalType().Name;

            Exception = exception;
        }

        public string ContentName { get; set; }
        public string ContentTypeName { get; set; }
        public Exception Exception { get; set; }
    }
}