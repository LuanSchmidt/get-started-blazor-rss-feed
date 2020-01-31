#pragma checksum "C:\Users\luan.schmidt\BlazorAppTests\Pages\FetchFeeds.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3a9f81a2011cafc6010b99b3588da57316cac15"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>C# Corner RSS Feeds</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Getting latest post details from C# Corner RSS Feeds</p>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\luan.schmidt\BlazorAppTests\Pages\FetchFeeds.razor"
 if (feeds == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "C:\Users\luan.schmidt\BlazorAppTests\Pages\FetchFeeds.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Title</th>\r\n                <th>Post Type</th>\r\n                <th>Published Date</th>\r\n                <th>Author</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 26 "C:\Users\luan.schmidt\BlazorAppTests\Pages\FetchFeeds.razor"
             foreach (var feed in feeds)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(15);
            __builder.AddAttribute(16, "href", 
#nullable restore
#line 29 "C:\Users\luan.schmidt\BlazorAppTests\Pages\FetchFeeds.razor"
                                       feed.Link

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "target", "_blank");
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(19, 
#nullable restore
#line 29 "C:\Users\luan.schmidt\BlazorAppTests\Pages\FetchFeeds.razor"
                                                                  feed.Title

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 30 "C:\Users\luan.schmidt\BlazorAppTests\Pages\FetchFeeds.razor"
                         feed.FeedType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 31 "C:\Users\luan.schmidt\BlazorAppTests\Pages\FetchFeeds.razor"
                         feed.DatePublishingString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 32 "C:\Users\luan.schmidt\BlazorAppTests\Pages\FetchFeeds.razor"
                         feed.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 34 "C:\Users\luan.schmidt\BlazorAppTests\Pages\FetchFeeds.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 37 "C:\Users\luan.schmidt\BlazorAppTests\Pages\FetchFeeds.razor"
}

#line default
#line hidden
#nullable disable
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