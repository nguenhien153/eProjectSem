﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jwelleryshopping.NewFolder1
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Runtime.Serialization;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Project_demo")]
	public partial class DimInfoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDimInfoMst(DimInfoMst instance);
    partial void UpdateDimInfoMst(DimInfoMst instance);
    partial void DeleteDimInfoMst(DimInfoMst instance);
    #endregion
		
		public DimInfoDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Project_demoConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DimInfoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DimInfoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DimInfoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DimInfoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DimInfoMst> DimInfoMsts
		{
			get
			{
				return this.GetTable<DimInfoMst>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DimInfoMst")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class DimInfoMst : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _DimID;
		
		private string _DimType;
		
		private string _DimSubType;
		
		private string _DimCrt;
		
		private string _DimPrice;
		
		private string _DimImg;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDimIDChanging(string value);
    partial void OnDimIDChanged();
    partial void OnDimTypeChanging(string value);
    partial void OnDimTypeChanged();
    partial void OnDimSubTypeChanging(string value);
    partial void OnDimSubTypeChanged();
    partial void OnDimCrtChanging(string value);
    partial void OnDimCrtChanged();
    partial void OnDimPriceChanging(string value);
    partial void OnDimPriceChanged();
    partial void OnDimImgChanging(string value);
    partial void OnDimImgChanged();
    #endregion
		
		public DimInfoMst()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DimID", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public string DimID
		{
			get
			{
				return this._DimID;
			}
			set
			{
				if ((this._DimID != value))
				{
					this.OnDimIDChanging(value);
					this.SendPropertyChanging();
					this._DimID = value;
					this.SendPropertyChanged("DimID");
					this.OnDimIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DimType", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string DimType
		{
			get
			{
				return this._DimType;
			}
			set
			{
				if ((this._DimType != value))
				{
					this.OnDimTypeChanging(value);
					this.SendPropertyChanging();
					this._DimType = value;
					this.SendPropertyChanged("DimType");
					this.OnDimTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DimSubType", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string DimSubType
		{
			get
			{
				return this._DimSubType;
			}
			set
			{
				if ((this._DimSubType != value))
				{
					this.OnDimSubTypeChanging(value);
					this.SendPropertyChanging();
					this._DimSubType = value;
					this.SendPropertyChanged("DimSubType");
					this.OnDimSubTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DimCrt", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public string DimCrt
		{
			get
			{
				return this._DimCrt;
			}
			set
			{
				if ((this._DimCrt != value))
				{
					this.OnDimCrtChanging(value);
					this.SendPropertyChanging();
					this._DimCrt = value;
					this.SendPropertyChanged("DimCrt");
					this.OnDimCrtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DimPrice", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public string DimPrice
		{
			get
			{
				return this._DimPrice;
			}
			set
			{
				if ((this._DimPrice != value))
				{
					this.OnDimPriceChanging(value);
					this.SendPropertyChanging();
					this._DimPrice = value;
					this.SendPropertyChanged("DimPrice");
					this.OnDimPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DimImg", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
		public string DimImg
		{
			get
			{
				return this._DimImg;
			}
			set
			{
				if ((this._DimImg != value))
				{
					this.OnDimImgChanging(value);
					this.SendPropertyChanging();
					this._DimImg = value;
					this.SendPropertyChanged("DimImg");
					this.OnDimImgChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
}
#pragma warning restore 1591
