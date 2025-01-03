//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.18.15
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Article</summary>
	[PublishedModel("article")]
	public partial class Article : PublishedContentModel, IArticleControls, IContentControls, IHeaderControls, IMainImageControls, ISeoControls, IVisibilityControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.15")]
		public new const string ModelTypeAlias = "article";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.15")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.15")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.15")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Article, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Article(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Author Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.15")]
		[ImplementPropertyType("authorName")]
		public virtual string AuthorName => global::Umbraco.Web.PublishedModels.ArticleControls.GetAuthorName(this);

		///<summary>
		/// Publish Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.15")]
		[ImplementPropertyType("publishDate")]
		public virtual global::System.DateTime PublishDate => global::Umbraco.Web.PublishedModels.ArticleControls.GetPublishDate(this);

		///<summary>
		/// Main Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.15")]
		[ImplementPropertyType("mainContent")]
		public virtual global::Newtonsoft.Json.Linq.JToken MainContent => global::Umbraco.Web.PublishedModels.ContentControls.GetMainContent(this);

		///<summary>
		/// Subtitle: Add Subtitle for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.15")]
		[ImplementPropertyType("subtitle")]
		public virtual string Subtitle => global::Umbraco.Web.PublishedModels.HeaderControls.GetSubtitle(this);

		///<summary>
		/// Title: Add Title for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.15")]
		[ImplementPropertyType("title")]
		public virtual string Title => global::Umbraco.Web.PublishedModels.HeaderControls.GetTitle(this);

		///<summary>
		/// Main Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.15")]
		[ImplementPropertyType("mainImage")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops MainImage => global::Umbraco.Web.PublishedModels.MainImageControls.GetMainImage(this);

		///<summary>
		/// Meta Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.15")]
		[ImplementPropertyType("metaDescription")]
		public virtual string MetaDescription => global::Umbraco.Web.PublishedModels.SeoControls.GetMetaDescription(this);

		///<summary>
		/// Meta Keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.15")]
		[ImplementPropertyType("metaKeywords")]
		public virtual global::System.Collections.Generic.IEnumerable<string> MetaKeywords => global::Umbraco.Web.PublishedModels.SeoControls.GetMetaKeywords(this);

		///<summary>
		/// Meta Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.15")]
		[ImplementPropertyType("metaTitle")]
		public virtual string MetaTitle => global::Umbraco.Web.PublishedModels.SeoControls.GetMetaTitle(this);

		///<summary>
		/// Hide From XML Sitemap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.15")]
		[ImplementPropertyType("hideFromXMLSitemap")]
		public virtual bool HideFromXmlsitemap => global::Umbraco.Web.PublishedModels.VisibilityControls.GetHideFromXmlsitemap(this);

		///<summary>
		/// Umbraco Navi Hide
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.15")]
		[ImplementPropertyType("umbracoNaviHide")]
		public virtual bool UmbracoNaviHide => global::Umbraco.Web.PublishedModels.VisibilityControls.GetUmbracoNaviHide(this);
	}
}
