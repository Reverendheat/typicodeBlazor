using Microsoft.AspNetCore.Components;
using TypiCodeTestingAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TypiCodeTestingAPI.Data;
using Raven.Embedded;

namespace TypiCodeTestingAPI
{
    public class SSOLinkBase : ComponentBase
    {
        [Inject]
        public ISSOLinkDataService SSOLinkDataService { get; set; }


        public IEnumerable<SSOLink> SSOLinks { get; set; }

        protected override async Task OnInitializedAsync()
        {
            SSOLinks = (await SSOLinkDataService.GetSSOLinks().ConfigureAwait(true)).ToList();
        }
    }
}
