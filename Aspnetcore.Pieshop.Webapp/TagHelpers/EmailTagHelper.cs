using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Aspnetcore.Pieshop.Webapp.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string Content { get; set; }
        public string Address { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Address);

            output.Content.SetContent(Content);
        }
    }
}