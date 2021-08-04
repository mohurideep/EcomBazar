using Microsoft.AspNetCore.Razor.TagHelpers;
using Practise_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practise_Demo.TagHelpers
{
    public class SupportTagHelper : TagHelper
    {
        public SupportInfo info { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Content.SetHtmlContent($@"<p> Contact Address : {info.Address}</p><p> Tel No: {info.Phone}</p> <p>Email id : {info.Email}</p>");
        }
    }
}
