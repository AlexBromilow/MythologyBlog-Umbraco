using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Umbraco.Cms.Core.Models.Blocks;

namespace MythologyBlog.Web.TagHelpers
{
    public class BlockContentTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext? ViewContext { get; set; }

        [HtmlAttributeName("blocks")]
        public IEnumerable<BlockListItem>? Blocks { get; set; }

        private readonly IViewComponentHelper _vcHelper;
        private readonly IWebHostEnvironment _environment;
        private readonly ILogger<BlockContentTagHelper> _logger;

        public BlockContentTagHelper(IViewComponentHelper vchelper, ILogger<BlockContentTagHelper> logger, IWebHostEnvironment env)
        {
            _environment = env;
            _logger = logger;
            _vcHelper = vchelper;
        }

        public async override void Process(TagHelperContext context, TagHelperOutput output)
        {
            ((IViewContextAware)_vcHelper).Contextualize(ViewContext);
            output.TagName = null;
            var builder = new HtmlContentBuilder();

            var blocks = Blocks;

            if (blocks != null && blocks.Any())
            {
                foreach (var block in blocks)
                {
                    var componentVCName = block.Content.ContentType.Alias;
                    componentVCName = componentVCName.ToFirstUpper();
                    try
                    {
                        builder.AppendHtml(
                            await _vcHelper.InvokeAsync(componentVCName, new { widgetContent = block.Content, widgetSettings = block.Settings })
                        );
                    }
                    catch (InvalidOperationException iox)
                    {
                        _logger.LogError(iox, $"Cannot find Component: {componentVCName}. Exception: {iox}");
                        if (_environment.IsDevelopment())
                        {
                            builder.AppendHtml($"<pre>Cannot find Component - {componentVCName}. Exception: {iox}</pre>");
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, $"React Component Failure: {componentVCName}. Exception: {ex}");
                        if (_environment.IsDevelopment())
                        {
                            builder.AppendHtml($"<pre>React Component Failure - {componentVCName}. Exception: {ex}</pre>");
                        }
                    }
                }
            }

            output.PostContent.SetHtmlContent(builder);
        }
    }
}
