//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
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
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1118 with alias "navigationBase"
	/// <summary>Navigation Base</summary>
	public partial interface INavigationBase : IPublishedContent
	{
		/// <summary>Keywords</summary>
		IEnumerable<string> Keywords { get; }

		/// <summary>Description</summary>
		string SeoMetaDescription { get; }

		/// <summary>Hide in Navigation</summary>
		bool UmbracoNavihide { get; }
	}

	/// <summary>Navigation Base</summary>
	[PublishedContentModel("navigationBase")]
	public partial class NavigationBase : PublishedContentModel, INavigationBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "navigationBase";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public NavigationBase(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NavigationBase, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Keywords: Keywords that describe the content of the page. This is consired optional since most modern search engines don't use this anymore
		///</summary>
		[ImplementPropertyType("keywords")]
		public IEnumerable<string> Keywords
		{
			get { return GetKeywords(this); }
		}

		/// <summary>Static getter for Keywords</summary>
		public static IEnumerable<string> GetKeywords(INavigationBase that) { return that.GetPropertyValue<IEnumerable<string>>("keywords"); }

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[ImplementPropertyType("seoMetaDescription")]
		public string SeoMetaDescription
		{
			get { return GetSeoMetaDescription(this); }
		}

		/// <summary>Static getter for Description</summary>
		public static string GetSeoMetaDescription(INavigationBase that) { return that.GetPropertyValue<string>("seoMetaDescription"); }

		///<summary>
		/// Hide in Navigation: If you don't want this page to appear in the navigation, check this box
		///</summary>
		[ImplementPropertyType("umbracoNavihide")]
		public bool UmbracoNavihide
		{
			get { return GetUmbracoNavihide(this); }
		}

		/// <summary>Static getter for Hide in Navigation</summary>
		public static bool GetUmbracoNavihide(INavigationBase that) { return that.GetPropertyValue<bool>("umbracoNavihide"); }
	}
}
