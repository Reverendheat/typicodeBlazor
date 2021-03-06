﻿using Microsoft.AspNetCore.Components;
using TypiCodeTestingAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TypiCodeTestingAPI.Data;
using Raven.Embedded;

namespace TypiCodeTestingAPI
{
    public class PostOverviewBase : ComponentBase
    {
        [Inject]
        public IPostDataService PostDataService { get; set; }

       
        public IEnumerable<Post> Posts { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Posts = (await PostDataService.GetAllPosts().ConfigureAwait(true)).ToList();
        }
    }
}
