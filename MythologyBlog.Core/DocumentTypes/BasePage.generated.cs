//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v13.7.0+eaea7a6
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace MythologyBlog.Core.DocumentTypes
{
	/// <summary>Base Page</summary>
	[PublishedModel("basePage")]
	public partial class BasePage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.0+eaea7a6")]
		public new const string ModelTypeAlias = "basePage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.0+eaea7a6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.0+eaea7a6")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.0+eaea7a6")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<BasePage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public BasePage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Custom Canonical Url: Enter a url to be used in the pages canonical tag. If empty it will default to the page url. Enter url in the form "https://www.domain.com/example-url".
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.0+eaea7a6")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("customCanonicalUrl")]
		public virtual string CustomCanonicalUrl => this.Value<string>(_publishedValueFallback, "customCanonicalUrl");

		///<summary>
		/// Hide From Site Maps?
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.0+eaea7a6")]
		[ImplementPropertyType("hideFromSiteMaps")]
		public virtual bool HideFromSiteMaps => this.Value<bool>(_publishedValueFallback, "hideFromSiteMaps");

		///<summary>
		/// No Index: Tick to add the noindex tag. This will prevent all search engines that support the noindex rule from indexing this page.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.0+eaea7a6")]
		[ImplementPropertyType("noIndex")]
		public virtual bool NoIndex => this.Value<bool>(_publishedValueFallback, "noIndex");

		///<summary>
		/// Search Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.0+eaea7a6")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("searchImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SearchImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "searchImage");

		///<summary>
		/// SEO Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.0+eaea7a6")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoDescription")]
		public virtual string SeoDescription => this.Value<string>(_publishedValueFallback, "seoDescription");

		///<summary>
		/// Keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.0+eaea7a6")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoKeywords")]
		public virtual string SeoKeywords => this.Value<string>(_publishedValueFallback, "seoKeywords");

		///<summary>
		/// SEO Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.0+eaea7a6")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoTitle")]
		public virtual string SeoTitle => this.Value<string>(_publishedValueFallback, "seoTitle");

		///<summary>
		/// Spacing Below?
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.0+eaea7a6")]
		[ImplementPropertyType("spacingBelow")]
		public virtual bool SpacingBelow => this.Value<bool>(_publishedValueFallback, "spacingBelow");

		///<summary>
		/// Summary Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.0+eaea7a6")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("summaryText")]
		public virtual string SummaryText => this.Value<string>(_publishedValueFallback, "summaryText");

		///<summary>
		/// Xml Frequency
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.0+eaea7a6")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("xmlFrequency")]
		public virtual string XmlFrequency => this.Value<string>(_publishedValueFallback, "xmlFrequency");

		///<summary>
		/// Xml Priority
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.0+eaea7a6")]
		[ImplementPropertyType("xmlPriority")]
		public virtual decimal XmlPriority => this.Value<decimal>(_publishedValueFallback, "xmlPriority");
	}
}
