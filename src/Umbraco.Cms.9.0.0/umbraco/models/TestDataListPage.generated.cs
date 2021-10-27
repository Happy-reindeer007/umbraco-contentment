//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407
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

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Test Data List Page</summary>
	[PublishedModel("testDataListPage")]
	public partial class TestDataListPage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		public new const string ModelTypeAlias = "testDataListPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<TestDataListPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public TestDataListPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Data List Countries
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListCountries")]
		public virtual global::System.Collections.Generic.List<string> DataListCountries => this.Value<global::System.Collections.Generic.List<string>>(_publishedValueFallback, "dataListCountries");

		///<summary>
		/// Data List CSV
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListCsv")]
		public virtual string DataListCsv => this.Value<string>(_publishedValueFallback, "dataListCsv");

		///<summary>
		/// Data List Currencies
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListCurrencies")]
		public virtual global::System.Collections.Generic.List<string> DataListCurrencies => this.Value<global::System.Collections.Generic.List<string>>(_publishedValueFallback, "dataListCurrencies");

		///<summary>
		/// Data List Enumeration
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListEnumeration")]
		public virtual global::System.Collections.Generic.List<global::System.ConsoleColor> DataListEnumeration => this.Value<global::System.Collections.Generic.List<global::System.ConsoleColor>>(_publishedValueFallback, "dataListEnumeration");

		///<summary>
		/// Data List File System
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListFileSystem")]
		public virtual string DataListFileSystem => this.Value<string>(_publishedValueFallback, "dataListFileSystem");

		///<summary>
		/// Data List JSON
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListJson")]
		public virtual string DataListJson => this.Value<string>(_publishedValueFallback, "dataListJson");

		///<summary>
		/// Data List Languages
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListLanguages")]
		public virtual global::System.Collections.Generic.List<string> DataListLanguages => this.Value<global::System.Collections.Generic.List<string>>(_publishedValueFallback, "dataListLanguages");

		///<summary>
		/// Data List Number Range
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[ImplementPropertyType("dataListNumberRange")]
		public virtual double DataListNumberRange => this.Value<double>(_publishedValueFallback, "dataListNumberRange");

		///<summary>
		/// Data List SQL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListSql")]
		public virtual string DataListSql => this.Value<string>(_publishedValueFallback, "dataListSql");

		///<summary>
		/// Data List Time Zones
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListTimeZones")]
		public virtual global::System.Collections.Generic.List<global::System.TimeZoneInfo> DataListTimeZones => this.Value<global::System.Collections.Generic.List<global::System.TimeZoneInfo>>(_publishedValueFallback, "dataListTimeZones");

		///<summary>
		/// Data List uCssClassName
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListUCssClassName")]
		public virtual global::System.Collections.Generic.List<string> DataListUcssClassName => this.Value<global::System.Collections.Generic.List<string>>(_publishedValueFallback, "dataListUCssClassName");

		///<summary>
		/// Data List Umbraco Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListUmbracoContent")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent DataListUmbracoContent => this.Value<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent>(_publishedValueFallback, "dataListUmbracoContent");

		///<summary>
		/// Data List Umbraco Content by XPath
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListUmbracoContentByXPath")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent DataListUmbracoContentByXpath => this.Value<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent>(_publishedValueFallback, "dataListUmbracoContentByXPath");

		///<summary>
		/// Data List Umbraco Content Properties
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListUmbracoContentProperties")]
		public virtual string DataListUmbracoContentProperties => this.Value<string>(_publishedValueFallback, "dataListUmbracoContentProperties");

		///<summary>
		/// Data List Umbraco Content Types
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListUmbracoContentTypes")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContentType DataListUmbracoContentTypes => this.Value<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContentType>(_publishedValueFallback, "dataListUmbracoContentTypes");

		///<summary>
		/// Data List Umbraco Dictionary Items
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListUmbracoDictionaryItems")]
		public virtual string DataListUmbracoDictionaryItems => this.Value<string>(_publishedValueFallback, "dataListUmbracoDictionaryItems");

		///<summary>
		/// Data List Umbraco Entities
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListUmbracoEntities")]
		public virtual global::Umbraco.Cms.Core.Models.Entities.IEntitySlim DataListUmbracoEntities => this.Value<global::Umbraco.Cms.Core.Models.Entities.IEntitySlim>(_publishedValueFallback, "dataListUmbracoEntities");

		///<summary>
		/// Data List Umbraco Examine Query
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListUmbracoExamineQuery")]
		public virtual string DataListUmbracoExamineQuery => this.Value<string>(_publishedValueFallback, "dataListUmbracoExamineQuery");

		///<summary>
		/// Data List Umbraco Image Crops
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListUmbracoImageCrops")]
		public virtual string DataListUmbracoImageCrops => this.Value<string>(_publishedValueFallback, "dataListUmbracoImageCrops");

		///<summary>
		/// Data List Umbraco Languages
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListUmbracoLanguages")]
		public virtual string DataListUmbracoLanguages => this.Value<string>(_publishedValueFallback, "dataListUmbracoLanguages");

		///<summary>
		/// Data List Umbraco Member Groups: Add member groups to test this.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[ImplementPropertyType("dataListUmbracoMemberGroups")]
		public virtual global::System.Guid DataListUmbracoMemberGroups => this.Value<global::System.Guid>(_publishedValueFallback, "dataListUmbracoMemberGroups");

		///<summary>
		/// Data List Umbraco Members: Add members to test this.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListUmbracoMembers")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent DataListUmbracoMembers => this.Value<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent>(_publishedValueFallback, "dataListUmbracoMembers");

		///<summary>
		/// Data List Umbraco Tags
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListUmbracoTags")]
		public virtual string DataListUmbracoTags => this.Value<string>(_publishedValueFallback, "dataListUmbracoTags");

		///<summary>
		/// Data List Umbraco User Groups
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListUmbracoUserGroups")]
		public virtual global::Umbraco.Cms.Core.Models.Membership.IUserGroup DataListUmbracoUserGroups => this.Value<global::Umbraco.Cms.Core.Models.Membership.IUserGroup>(_publishedValueFallback, "dataListUmbracoUserGroups");

		///<summary>
		/// Data List Umbraco Users
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListUmbracoUsers")]
		public virtual global::Umbraco.Cms.Core.Models.Membership.IUser DataListUmbracoUsers => this.Value<global::Umbraco.Cms.Core.Models.Membership.IUser>(_publishedValueFallback, "dataListUmbracoUsers");

		///<summary>
		/// Data List User-defined
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListUserDefined")]
		public virtual string DataListUserDefined => this.Value<string>(_publishedValueFallback, "dataListUserDefined");

		///<summary>
		/// Data List XML
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListXml")]
		public virtual string DataListXml => this.Value<string>(_publishedValueFallback, "dataListXml");

		///<summary>
		/// Data List XML Sitemap Change Frequency
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListXmlSitemapChangeFrequency")]
		public virtual string DataListXmlSitemapChangeFrequency => this.Value<string>(_publishedValueFallback, "dataListXmlSitemapChangeFrequency");

		///<summary>
		/// Data List XML Sitemap: Priority
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dataListXmlSitemapPriority")]
		public virtual string DataListXmlSitemapPriority => this.Value<string>(_publishedValueFallback, "dataListXmlSitemapPriority");
	}
}
