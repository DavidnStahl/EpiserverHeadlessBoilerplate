using EPiServer.Shell;
using EpiserverHeadlessBoilerplate.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverHeadlessBoilerplate.Business.UIDescriptors
{
    [UIDescriptorRegistration]
    public class ForceAllPropertiesViewUiDescriptor : UIDescriptor<StartPage>
    {
        public ForceAllPropertiesViewUiDescriptor()
        {
            DefaultView = CmsViewNames.AllPropertiesView;
        }
    }
    
}