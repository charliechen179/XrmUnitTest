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
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.1.0001.3108")]
	public enum BulkDeleteOperationState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Ready = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Suspended = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Locked = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Completed = 3,
	}
	
	/// <summary>
	/// User-submitted bulk deletion job.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("bulkdeleteoperation")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.1.0001.3108")]
	public partial class BulkDeleteOperation : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string AsyncOperationId = "asyncoperationid";
			public const string BulkDeleteOperationId = "bulkdeleteoperationid";
			public const string Id = "bulkdeleteoperationid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string FailureCount = "failurecount";
			public const string IsRecurring = "isrecurring";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string NextRun = "nextrun";
			public const string OrderedQuerySetXml = "orderedquerysetxml";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningUser = "owninguser";
			public const string ProcessingQEIndex = "processingqeindex";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string SuccessCount = "successcount";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string AsyncOperation_BulkDeleteOperation = "asyncoperationid";
			public const string BulkDeleteOperation_BusinessUnit = "owningbusinessunit";
			public const string lk_bulkdeleteoperation_createdonbehalfby = "createdonbehalfby";
			public const string lk_bulkdeleteoperation_modifiedonbehalfby = "modifiedonbehalfby";
			public const string lk_bulkdeleteoperationbase_createdby = "createdby";
			public const string lk_bulkdeleteoperationbase_modifiedby = "modifiedby";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public BulkDeleteOperation() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "bulkdeleteoperation";
		
		public const int EntityTypeCode = 4424;
		
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
		/// Unique identifier of the system job that created this record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asyncoperationid")]
		public Microsoft.Xrm.Sdk.EntityReference AsyncOperationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("asyncoperationid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the bulk deletion job.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bulkdeleteoperationid")]
		public System.Nullable<System.Guid> BulkDeleteOperationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("bulkdeleteoperationid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bulkdeleteoperationid")]
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
				base.Id = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the bulk deletion job.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the bulk deletion job was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the bulkdeleteoperation.
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
		/// Number of records that could not be deleted by the bulk deletion job.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("failurecount")]
		public System.Nullable<int> FailureCount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("failurecount");
			}
		}
		
		/// <summary>
		/// Information about if recurrence is defined for the bulk deletion job.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isrecurring")]
		public System.Nullable<bool> IsRecurring
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isrecurring");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the bulk deletion job.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the bulk deletion job record was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the bulkdeleteoperation.
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
		/// Name of the bulk deletion job.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
		}
		
		/// <summary>
		/// Next scheduled time for the bulk deletion job to run.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nextrun")]
		public System.Nullable<System.DateTime> NextRun
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("nextrun");
			}
		}
		
		/// <summary>
		/// Fetch XML of the ordered query set.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orderedquerysetxml")]
		public string OrderedQuerySetXml
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("orderedquerysetxml");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user or team who owns the bulk delete operation.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
		}
		
		/// <summary>
		/// Business unit that owns the bulk deletion job.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Business user what owns the bulk delete operation.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Index of the ordered query expression that defines the deletion set.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processingqeindex")]
		public System.Nullable<int> ProcessingQEIndex
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("processingqeindex");
			}
		}
		
		/// <summary>
		/// Status of the bulk deletion job.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<DLaB.Xrm.Entities.BulkDeleteOperationState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((DLaB.Xrm.Entities.BulkDeleteOperationState)(System.Enum.ToObject(typeof(DLaB.Xrm.Entities.BulkDeleteOperationState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
		}
		
		/// <summary>
		/// Reason for the status of the bulk deletion job.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
		}
		
		/// <summary>
		/// Number of records deleted by the bulk deletion job.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("successcount")]
		public System.Nullable<int> SuccessCount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("successcount");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// 1:N BulkDeleteOperation_BulkDeleteFailure
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkDeleteOperation_BulkDeleteFailure")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.BulkDeleteFailure> BulkDeleteOperation_BulkDeleteFailure
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("BulkDeleteOperation_BulkDeleteFailure", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BulkDeleteOperation_BulkDeleteFailure");
				this.SetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("BulkDeleteOperation_BulkDeleteFailure", null, value);
				this.OnPropertyChanged("BulkDeleteOperation_BulkDeleteFailure");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_bulkdeleteoperation
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_bulkdeleteoperation")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.UserEntityInstanceData> userentityinstancedata_bulkdeleteoperation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_bulkdeleteoperation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_bulkdeleteoperation");
				this.SetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_bulkdeleteoperation", null, value);
				this.OnPropertyChanged("userentityinstancedata_bulkdeleteoperation");
			}
		}
		
		/// <summary>
		/// N:1 AsyncOperation_BulkDeleteOperation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asyncoperationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("AsyncOperation_BulkDeleteOperation")]
		public DLaB.Xrm.Entities.AsyncOperation AsyncOperation_BulkDeleteOperation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.AsyncOperation>("AsyncOperation_BulkDeleteOperation", null);
			}
		}
		
		/// <summary>
		/// N:1 BulkDeleteOperation_BusinessUnit
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkDeleteOperation_BusinessUnit")]
		public DLaB.Xrm.Entities.BusinessUnit BulkDeleteOperation_BusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.BusinessUnit>("BulkDeleteOperation_BusinessUnit", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_bulkdeleteoperation_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bulkdeleteoperation_createdonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_bulkdeleteoperation_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_bulkdeleteoperation_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_bulkdeleteoperation_createdonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_bulkdeleteoperation_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_bulkdeleteoperation_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_bulkdeleteoperation_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bulkdeleteoperation_modifiedonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_bulkdeleteoperation_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_bulkdeleteoperation_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_bulkdeleteoperation_modifiedonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_bulkdeleteoperation_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_bulkdeleteoperation_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_bulkdeleteoperationbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bulkdeleteoperationbase_createdby")]
		public DLaB.Xrm.Entities.SystemUser lk_bulkdeleteoperationbase_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_bulkdeleteoperationbase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_bulkdeleteoperationbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bulkdeleteoperationbase_modifiedby")]
		public DLaB.Xrm.Entities.SystemUser lk_bulkdeleteoperationbase_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_bulkdeleteoperationbase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public BulkDeleteOperation(object anonymousType) : 
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
                        Attributes["bulkdeleteoperationid"] = base.Id;
                        break;
                    case "bulkdeleteoperationid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual bulkdeleteoperation_statuscode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((bulkdeleteoperation_statuscode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
		}
	}
}