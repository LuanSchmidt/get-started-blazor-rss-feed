#pragma checksum "C:\Users\luan.schmidt\BlazorAppTests\Pages\FetchFeeds.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3a9f81a2011cafc6010b99b3588da57316cac15"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAppTests.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\luan.schmidt\BlazorAppTests\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\luan.schmidt\BlazorAppTests\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\luan.schmidt\BlazorAppTests\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\luan.schmidt\BlazorAppTests\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\luan.schmidt\BlazorAppTests\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\luan.schmidt\BlazorAppTests\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\luan.schmidt\BlazorAppTests\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\luan.schmidt\BlazorAppTests\_Imports.razor"
using BlazorAppTests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\luan.schmidt\BlazorAppTests\_Imports.razor"
using BlazorAppTests.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\luan.schmidt\BlazorAppTests\Pages\FetchFeeds.razor"
using BlazorAppTests.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchfeeds")]
    public partial class FetchFeeds : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\luan.schmidt\BlazorAppTests\Pages\FetchFeeds.razor"
       
    List<Feed> feeds;
    protected override async Task OnInitializedAsync()
    {
        feeds = await FeedService.GetFeedsAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RssFeedService FeedService { get; set; }
    }
}
#pragma warning restore 1591
