using System;
using System.Collections.Generic;
using System.Text;
using MCSTCoreApp.Application.ViewModels.Common;

namespace MCSTCoreApp.Application.Interfaces
{
    public interface ICommonService
    {
        FooterViewModel GetFooter();

        List<SlideViewModel> GetSlides(string groupAlias);

        SystemConfigViewModel GetSystemConfig(string code);
    }
}
