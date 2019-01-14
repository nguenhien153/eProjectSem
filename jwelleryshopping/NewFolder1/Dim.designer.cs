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
	public partial class DimDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DimDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Project_demoConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DimDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DimDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DimDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DimDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DimMst> DimMsts
		{
			get
			{
				return this.GetTable<DimMst>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DimMst")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class DimMst
	{
		
		private string _Style_Code;
		
		private string _DimQlty_ID;
		
		private string _DimSubType_ID;
		
		private decimal _Dim_Crt;
		
		private decimal _Dim_Pcs;
		
		private decimal _Dim_Gm;
		
		private decimal _Dim_Size;
		
		private decimal _Dim_Rate;
		
		private decimal _Dim_Amt;
		
		public DimMst()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Style_Code", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public string Style_Code
		{
			get
			{
				return this._Style_Code;
			}
			set
			{
				if ((this._Style_Code != value))
				{
					this._Style_Code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DimQlty_ID", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string DimQlty_ID
		{
			get
			{
				return this._DimQlty_ID;
			}
			set
			{
				if ((this._DimQlty_ID != value))
				{
					this._DimQlty_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DimSubType_ID", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string DimSubType_ID
		{
			get
			{
				return this._DimSubType_ID;
			}
			set
			{
				if ((this._DimSubType_ID != value))
				{
					this._DimSubType_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dim_Crt", DbType="Decimal(10,2) NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public decimal Dim_Crt
		{
			get
			{
				return this._Dim_Crt;
			}
			set
			{
				if ((this._Dim_Crt != value))
				{
					this._Dim_Crt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dim_Pcs", DbType="Decimal(10,2) NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public decimal Dim_Pcs
		{
			get
			{
				return this._Dim_Pcs;
			}
			set
			{
				if ((this._Dim_Pcs != value))
				{
					this._Dim_Pcs = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dim_Gm", DbType="Decimal(10,2) NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
		public decimal Dim_Gm
		{
			get
			{
				return this._Dim_Gm;
			}
			set
			{
				if ((this._Dim_Gm != value))
				{
					this._Dim_Gm = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dim_Size", DbType="Decimal(10,2) NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7)]
		public decimal Dim_Size
		{
			get
			{
				return this._Dim_Size;
			}
			set
			{
				if ((this._Dim_Size != value))
				{
					this._Dim_Size = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dim_Rate", DbType="Decimal(10,2) NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=8)]
		public decimal Dim_Rate
		{
			get
			{
				return this._Dim_Rate;
			}
			set
			{
				if ((this._Dim_Rate != value))
				{
					this._Dim_Rate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dim_Amt", DbType="Decimal(10,2) NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=9)]
		public decimal Dim_Amt
		{
			get
			{
				return this._Dim_Amt;
			}
			set
			{
				if ((this._Dim_Amt != value))
				{
					this._Dim_Amt = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
