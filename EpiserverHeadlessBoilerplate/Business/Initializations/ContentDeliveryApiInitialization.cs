using EPiServer.ContentApi.Cms;
using EPiServer.ContentApi.Core.Configuration;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverHeadlessBoilerplate.Business.Initialization
{
    [ModuleDependency(typeof(ContentApiCmsInitialization))]
    public class ContentDeliveryApiInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Services.Configure<ContentApiConfiguration>(config =>
            {
                config.Default().SetMinimumRoles(string.Empty);
            });
        }

        public void Initialize(InitializationEngine context)
        {

            //Add initialization logic, this method is called once CMS has been initialized
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }
    }
}