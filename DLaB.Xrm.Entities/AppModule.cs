//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLaB.Xrm.Entities
{
	
	/// <summary>
	/// A role-based, modular business app that provides task-based functionality for a particular area of work.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("appmodule")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class AppModule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string AppModuleId = "appmoduleid";
			public const string Id = "appmoduleid";
			public const string AppModuleIdUnique = "appmoduleidunique";
			public const string AppModuleVersion = "appmoduleversion";
			public const string AppModuleXmlManaged = "appmodulexmlmanaged";
			public const string ClientType = "clienttype";
			public const string ComponentState = "componentstate";
			public const string ConfigXML = "configxml";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string Descriptor = "descriptor";
			public const string EventHandlers = "eventhandlers";
			public const string FormFactor = "formfactor";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IntroducedVersion = "introducedversion";
			public const string IsDefault = "isdefault";
			public const string IsFeatured = "isfeatured";
			public const string IsManaged = "ismanaged";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OverwriteTime = "overwritetime";
			public const string PublishedOn = "publishedon";
			public const string PublisherId = "publisherid";
			public const string SolutionId = "solutionid";
			public const string UniqueName = "uniquename";
			public const string URL = "url";
			public const string VersionNumber = "versionnumber";
			public const string WebResourceId = "webresourceid";
			public const string WelcomePageId = "welcomepageid";
			public const string lk_appmodule_createdby = "lk_appmodule_createdby";
			public const string lk_appmodule_createdonbehalfby = "lk_appmodule_createdonbehalfby";
			public const string lk_appmodule_modifiedby = "lk_appmodule_modifiedby";
			public const string lk_appmodule_modifiedonbehalfby = "lk_appmodule_modifiedonbehalfby";
			public const string organization_appmodule = "organization_appmodule";
			public const string publisher_appmodule = "publisher_appmodule";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public AppModule() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "appmodule";
		
		public const string PrimaryIdAttribute = "appmoduleid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 9006;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appmoduleid")]
		public System.Nullable<System.Guid> AppModuleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("appmoduleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AppModuleId");
				this.SetAttributeValue("appmoduleid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("AppModuleId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appmoduleid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.AppModuleId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the App Module used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appmoduleidunique")]
		public System.Nullable<System.Guid> AppModuleIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("appmoduleidunique");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AppModuleIdUnique");
				this.SetAttributeValue("appmoduleidunique", value);
				this.OnPropertyChanged("AppModuleIdUnique");
			}
		}
		
		/// <summary>
		/// App Module Version
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appmoduleversion")]
		public string AppModuleVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("appmoduleversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AppModuleVersion");
				this.SetAttributeValue("appmoduleversion", value);
				this.OnPropertyChanged("AppModuleVersion");
			}
		}
		
		/// <summary>
		/// App Module Xml Managed
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appmodulexmlmanaged")]
		public string AppModuleXmlManaged
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("appmodulexmlmanaged");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AppModuleXmlManaged");
				this.SetAttributeValue("appmodulexmlmanaged", value);
				this.OnPropertyChanged("AppModuleXmlManaged");
			}
		}
		
		/// <summary>
		/// Client Type such as Web or UCI
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("clienttype")]
		public System.Nullable<int> ClientType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("clienttype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ClientType");
				this.SetAttributeValue("clienttype", value);
				this.OnPropertyChanged("ClientType");
			}
		}
		
		/// <summary>
		/// For internal use only
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
			}
		}
		
		/// <summary>
		/// Contains configuration XML
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("configxml")]
		public string ConfigXML
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("configxml");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConfigXML");
				this.SetAttributeValue("configxml", value);
				this.OnPropertyChanged("ConfigXML");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedBy");
				this.SetAttributeValue("createdby", value);
				this.OnPropertyChanged("CreatedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOn");
				this.SetAttributeValue("createdon", value);
				this.OnPropertyChanged("CreatedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Description for entity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// App Module Descriptor
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("descriptor")]
		public string Descriptor
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("descriptor");
			}
		}
		
		/// <summary>
		/// App Module Event Handlers
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("eventhandlers")]
		public string EventHandlers
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("eventhandlers");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EventHandlers");
				this.SetAttributeValue("eventhandlers", value);
				this.OnPropertyChanged("EventHandlers");
			}
		}
		
		/// <summary>
		/// Form Factor
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formfactor")]
		public System.Nullable<int> FormFactor
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("formfactor");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FormFactor");
				this.SetAttributeValue("formfactor", value);
				this.OnPropertyChanged("FormFactor");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Version in which the similarity rule is introduced.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
		public string IntroducedVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("introducedversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IntroducedVersion");
				this.SetAttributeValue("introducedversion", value);
				this.OnPropertyChanged("IntroducedVersion");
			}
		}
		
		/// <summary>
		/// Is Default
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdefault")]
		public System.Nullable<bool> IsDefault
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdefault");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsDefault");
				this.SetAttributeValue("isdefault", value);
				this.OnPropertyChanged("IsDefault");
			}
		}
		
		/// <summary>
		/// Is Featured
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isfeatured")]
		public System.Nullable<bool> IsFeatured
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isfeatured");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsFeatured");
				this.SetAttributeValue("isfeatured", value);
				this.OnPropertyChanged("IsFeatured");
			}
		}
		
		/// <summary>
		/// Is Managed
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedBy");
				this.SetAttributeValue("modifiedby", value);
				this.OnPropertyChanged("ModifiedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOn");
				this.SetAttributeValue("modifiedon", value);
				this.OnPropertyChanged("ModifiedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Name of App Module
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization associated with the app.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Internal use only
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Date and time when the record was published.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publishedon")]
		public System.Nullable<System.DateTime> PublishedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("publishedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PublishedOn");
				this.SetAttributeValue("publishedon", value);
				this.OnPropertyChanged("PublishedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the publisher.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisherid")]
		public Microsoft.Xrm.Sdk.EntityReference PublisherId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("publisherid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PublisherId");
				this.SetAttributeValue("publisherid", value);
				this.OnPropertyChanged("PublisherId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// Unique Name of App Module
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uniquename")]
		public string UniqueName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("uniquename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UniqueName");
				this.SetAttributeValue("uniquename", value);
				this.OnPropertyChanged("UniqueName");
			}
		}
		
		/// <summary>
		/// Contains URL
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("url")]
		public string URL
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("url");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("URL");
				this.SetAttributeValue("url", value);
				this.OnPropertyChanged("URL");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the Web Resource
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("webresourceid")]
		public System.Nullable<System.Guid> WebResourceId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("webresourceid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("WebResourceId");
				this.SetAttributeValue("webresourceid", value);
				this.OnPropertyChanged("WebResourceId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the Web Resource as Welcome Page Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("welcomepageid")]
		public System.Nullable<System.Guid> WelcomePageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("welcomepageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("WelcomePageId");
				this.SetAttributeValue("welcomepageid", value);
				this.OnPropertyChanged("WelcomePageId");
			}
		}
		
		/// <summary>
		/// 1:N appmodule_appconfig
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appmodule_appconfig")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.AppConfig> appmodule_appconfig
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.AppConfig>("appmodule_appconfig", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("appmodule_appconfig");
				this.SetRelatedEntities<DLaB.Xrm.Entities.AppConfig>("appmodule_appconfig", null, value);
				this.OnPropertyChanged("appmodule_appconfig");
			}
		}
		
		/// <summary>
		/// 1:N appmodule_appmodulecomponent
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appmodule_appmodulecomponent")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.AppModuleComponent> appmodule_appmodulecomponent
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.AppModuleComponent>("appmodule_appmodulecomponent", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("appmodule_appmodulecomponent");
				this.SetRelatedEntities<DLaB.Xrm.Entities.AppModuleComponent>("appmodule_appmodulecomponent", null, value);
				this.OnPropertyChanged("appmodule_appmodulecomponent");
			}
		}
		
		/// <summary>
		/// N:N appmoduleroles_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appmoduleroles_association")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.Role> appmoduleroles_association
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.Role>("appmoduleroles_association", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("appmoduleroles_association");
				this.SetRelatedEntities<DLaB.Xrm.Entities.Role>("appmoduleroles_association", null, value);
				this.OnPropertyChanged("appmoduleroles_association");
			}
		}
		
		/// <summary>
		/// N:1 lk_appmodule_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appmodule_createdby")]
		public DLaB.Xrm.Entities.SystemUser lk_appmodule_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_appmodule_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_appmodule_createdby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_appmodule_createdby", null, value);
				this.OnPropertyChanged("lk_appmodule_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_appmodule_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appmodule_createdonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_appmodule_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_appmodule_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_appmodule_createdonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_appmodule_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_appmodule_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_appmodule_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appmodule_modifiedby")]
		public DLaB.Xrm.Entities.SystemUser lk_appmodule_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_appmodule_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_appmodule_modifiedby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_appmodule_modifiedby", null, value);
				this.OnPropertyChanged("lk_appmodule_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_appmodule_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appmodule_modifiedonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_appmodule_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_appmodule_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_appmodule_modifiedonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_appmodule_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_appmodule_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_appmodule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_appmodule")]
		public DLaB.Xrm.Entities.Organization organization_appmodule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Organization>("organization_appmodule", null);
			}
		}
		
		/// <summary>
		/// N:1 publisher_appmodule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisherid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("publisher_appmodule")]
		public DLaB.Xrm.Entities.Publisher publisher_appmodule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Publisher>("publisher_appmodule", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("publisher_appmodule");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Publisher>("publisher_appmodule", null, value);
				this.OnPropertyChanged("publisher_appmodule");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public AppModule(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["appmoduleid"] = base.Id;
                        break;
                    case "appmoduleid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public virtual ComponentState? ComponentStateEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ComponentState?)(EntityOptionSetEnum.GetEnum(this, "componentstate")));
			}
		}
	}
}