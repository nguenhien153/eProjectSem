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
	public partial class GoldDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertGoldKrtMst(GoldKrtMst instance);
    partial void UpdateGoldKrtMst(GoldKrtMst instance);
    partial void DeleteGoldKrtMst(GoldKrtMst instance);
    #endregion
		
		public GoldDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Project_demoConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public GoldDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GoldDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GoldDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GoldDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<GoldKrtMst> GoldKrtMsts
		{
			get
			{
				return this.GetTable<GoldKrtMst>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GoldKrtMst")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class GoldKrtMst : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _GoldType_ID;
		
		private string _Gold_Crt;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGoldType_IDChanging(string value);
    partial void OnGoldType_IDChanged();
    partial void OnGold_CrtChanging(string value);
    partial void OnGold_CrtChanged();
    #endregion
		
		public GoldKrtMst()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GoldType_ID", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public string GoldType_ID
		{
			get
			{
				return this._GoldType_ID;
			}
			set
			{
				if ((this._GoldType_ID != value))
				{
					this.OnGoldType_IDChanging(value);
					this.SendPropertyChanging();
					this._GoldType_ID = value;
					this.SendPropertyChanged("GoldType_ID");
					this.OnGoldType_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gold_Crt", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string Gold_Crt
		{
			get
			{
				return this._Gold_Crt;
			}
			set
			{
				if ((this._Gold_Crt != value))
				{
					this.OnGold_CrtChanging(value);
					this.SendPropertyChanging();
					this._Gold_Crt = value;
					this.SendPropertyChanged("Gold_Crt");
					this.OnGold_CrtChanged();
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