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

namespace SportsStore.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SportsStoreDB")]
	public partial class StoreDbContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertShoe(Shoe instance);
    partial void UpdateShoe(Shoe instance);
    partial void DeleteShoe(Shoe instance);
    partial void InsertClothing(Clothing instance);
    partial void UpdateClothing(Clothing instance);
    partial void DeleteClothing(Clothing instance);
    partial void InsertSportsEquipment(SportsEquipment instance);
    partial void UpdateSportsEquipment(SportsEquipment instance);
    partial void DeleteSportsEquipment(SportsEquipment instance);
    partial void InsertTeam(Team instance);
    partial void UpdateTeam(Team instance);
    partial void DeleteTeam(Team instance);
    #endregion
		
		public StoreDbContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SportsStoreDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StoreDbContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StoreDbContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StoreDbContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StoreDbContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Shoe> Shoes
		{
			get
			{
				return this.GetTable<Shoe>();
			}
		}
		
		public System.Data.Linq.Table<Clothing> Clothings
		{
			get
			{
				return this.GetTable<Clothing>();
			}
		}
		
		public System.Data.Linq.Table<SportsEquipment> SportsEquipments
		{
			get
			{
				return this.GetTable<SportsEquipment>();
			}
		}
		
		public System.Data.Linq.Table<Team> Teams
		{
			get
			{
				return this.GetTable<Team>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Shoes")]
	public partial class Shoe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _ShoeType;
		
		private string _Company;
		
		private string _Model;
		
		private System.Nullable<int> _Price;
		
		private System.Nullable<int> _Amount;
		
		private System.Nullable<bool> _IsSale;
		
		private string _Img;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnShoeTypeChanging(string value);
    partial void OnShoeTypeChanged();
    partial void OnCompanyChanging(string value);
    partial void OnCompanyChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnPriceChanging(System.Nullable<int> value);
    partial void OnPriceChanged();
    partial void OnAmountChanging(System.Nullable<int> value);
    partial void OnAmountChanged();
    partial void OnIsSaleChanging(System.Nullable<bool> value);
    partial void OnIsSaleChanged();
    partial void OnImgChanging(string value);
    partial void OnImgChanged();
    #endregion
		
		public Shoe()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShoeType", DbType="VarChar(30)")]
		public string ShoeType
		{
			get
			{
				return this._ShoeType;
			}
			set
			{
				if ((this._ShoeType != value))
				{
					this.OnShoeTypeChanging(value);
					this.SendPropertyChanging();
					this._ShoeType = value;
					this.SendPropertyChanged("ShoeType");
					this.OnShoeTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company", DbType="VarChar(30)")]
		public string Company
		{
			get
			{
				return this._Company;
			}
			set
			{
				if ((this._Company != value))
				{
					this.OnCompanyChanging(value);
					this.SendPropertyChanging();
					this._Company = value;
					this.SendPropertyChanged("Company");
					this.OnCompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(30)")]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				if ((this._Model != value))
				{
					this.OnModelChanging(value);
					this.SendPropertyChanging();
					this._Model = value;
					this.SendPropertyChanged("Model");
					this.OnModelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int")]
		public System.Nullable<int> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Int")]
		public System.Nullable<int> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsSale", DbType="Bit")]
		public System.Nullable<bool> IsSale
		{
			get
			{
				return this._IsSale;
			}
			set
			{
				if ((this._IsSale != value))
				{
					this.OnIsSaleChanging(value);
					this.SendPropertyChanging();
					this._IsSale = value;
					this.SendPropertyChanged("IsSale");
					this.OnIsSaleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Img", DbType="VarChar(150)")]
		public string Img
		{
			get
			{
				return this._Img;
			}
			set
			{
				if ((this._Img != value))
				{
					this.OnImgChanging(value);
					this.SendPropertyChanging();
					this._Img = value;
					this.SendPropertyChanged("Img");
					this.OnImgChanged();
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
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Clothing")]
	public partial class Clothing : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _ClothType;
		
		private string _Gender;
		
		private string _Company;
		
		private string _ClothModel;
		
		private System.Nullable<int> _Price;
		
		private System.Nullable<int> _Amount;
		
		private System.Nullable<bool> _IsShort;
		
		private System.Nullable<bool> _IsDreyfit;
		
		private string _Img;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnClothTypeChanging(string value);
    partial void OnClothTypeChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnCompanyChanging(string value);
    partial void OnCompanyChanged();
    partial void OnClothModelChanging(string value);
    partial void OnClothModelChanged();
    partial void OnPriceChanging(System.Nullable<int> value);
    partial void OnPriceChanged();
    partial void OnAmountChanging(System.Nullable<int> value);
    partial void OnAmountChanged();
    partial void OnIsShortChanging(System.Nullable<bool> value);
    partial void OnIsShortChanged();
    partial void OnIsDreyfitChanging(System.Nullable<bool> value);
    partial void OnIsDreyfitChanged();
    partial void OnImgChanging(string value);
    partial void OnImgChanged();
    #endregion
		
		public Clothing()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClothType", DbType="VarChar(40)")]
		public string ClothType
		{
			get
			{
				return this._ClothType;
			}
			set
			{
				if ((this._ClothType != value))
				{
					this.OnClothTypeChanging(value);
					this.SendPropertyChanging();
					this._ClothType = value;
					this.SendPropertyChanged("ClothType");
					this.OnClothTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(40)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company", DbType="VarChar(40)")]
		public string Company
		{
			get
			{
				return this._Company;
			}
			set
			{
				if ((this._Company != value))
				{
					this.OnCompanyChanging(value);
					this.SendPropertyChanging();
					this._Company = value;
					this.SendPropertyChanged("Company");
					this.OnCompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClothModel", DbType="VarChar(40)")]
		public string ClothModel
		{
			get
			{
				return this._ClothModel;
			}
			set
			{
				if ((this._ClothModel != value))
				{
					this.OnClothModelChanging(value);
					this.SendPropertyChanging();
					this._ClothModel = value;
					this.SendPropertyChanged("ClothModel");
					this.OnClothModelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int")]
		public System.Nullable<int> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Int")]
		public System.Nullable<int> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsShort", DbType="Bit")]
		public System.Nullable<bool> IsShort
		{
			get
			{
				return this._IsShort;
			}
			set
			{
				if ((this._IsShort != value))
				{
					this.OnIsShortChanging(value);
					this.SendPropertyChanging();
					this._IsShort = value;
					this.SendPropertyChanged("IsShort");
					this.OnIsShortChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsDreyfit", DbType="Bit")]
		public System.Nullable<bool> IsDreyfit
		{
			get
			{
				return this._IsDreyfit;
			}
			set
			{
				if ((this._IsDreyfit != value))
				{
					this.OnIsDreyfitChanging(value);
					this.SendPropertyChanging();
					this._IsDreyfit = value;
					this.SendPropertyChanged("IsDreyfit");
					this.OnIsDreyfitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Img", DbType="VarChar(150)")]
		public string Img
		{
			get
			{
				return this._Img;
			}
			set
			{
				if ((this._Img != value))
				{
					this.OnImgChanging(value);
					this.SendPropertyChanging();
					this._Img = value;
					this.SendPropertyChanged("Img");
					this.OnImgChanged();
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
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SportsEquipment")]
	public partial class SportsEquipment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _sportType;
		
		private string _ProductName;
		
		private string _Company;
		
		private string _ModelProduct;
		
		private System.Nullable<int> _Price;
		
		private System.Nullable<int> _Amount;
		
		private System.Nullable<int> _IdOfTheGroup;
		
		private string _Img;
		
		private EntityRef<Team> _Team;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnsportTypeChanging(string value);
    partial void OnsportTypeChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnCompanyChanging(string value);
    partial void OnCompanyChanged();
    partial void OnModelProductChanging(string value);
    partial void OnModelProductChanged();
    partial void OnPriceChanging(System.Nullable<int> value);
    partial void OnPriceChanged();
    partial void OnAmountChanging(System.Nullable<int> value);
    partial void OnAmountChanged();
    partial void OnIdOfTheGroupChanging(System.Nullable<int> value);
    partial void OnIdOfTheGroupChanged();
    partial void OnImgChanging(string value);
    partial void OnImgChanged();
    #endregion
		
		public SportsEquipment()
		{
			this._Team = default(EntityRef<Team>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sportType", DbType="VarChar(40)")]
		public string sportType
		{
			get
			{
				return this._sportType;
			}
			set
			{
				if ((this._sportType != value))
				{
					this.OnsportTypeChanging(value);
					this.SendPropertyChanging();
					this._sportType = value;
					this.SendPropertyChanged("sportType");
					this.OnsportTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="VarChar(40)")]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this.OnProductNameChanging(value);
					this.SendPropertyChanging();
					this._ProductName = value;
					this.SendPropertyChanged("ProductName");
					this.OnProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company", DbType="VarChar(40)")]
		public string Company
		{
			get
			{
				return this._Company;
			}
			set
			{
				if ((this._Company != value))
				{
					this.OnCompanyChanging(value);
					this.SendPropertyChanging();
					this._Company = value;
					this.SendPropertyChanged("Company");
					this.OnCompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModelProduct", DbType="VarChar(40)")]
		public string ModelProduct
		{
			get
			{
				return this._ModelProduct;
			}
			set
			{
				if ((this._ModelProduct != value))
				{
					this.OnModelProductChanging(value);
					this.SendPropertyChanging();
					this._ModelProduct = value;
					this.SendPropertyChanged("ModelProduct");
					this.OnModelProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int")]
		public System.Nullable<int> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Int")]
		public System.Nullable<int> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdOfTheGroup", DbType="Int")]
		public System.Nullable<int> IdOfTheGroup
		{
			get
			{
				return this._IdOfTheGroup;
			}
			set
			{
				if ((this._IdOfTheGroup != value))
				{
					if (this._Team.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdOfTheGroupChanging(value);
					this.SendPropertyChanging();
					this._IdOfTheGroup = value;
					this.SendPropertyChanged("IdOfTheGroup");
					this.OnIdOfTheGroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Img", DbType="VarChar(MAX)")]
		public string Img
		{
			get
			{
				return this._Img;
			}
			set
			{
				if ((this._Img != value))
				{
					this.OnImgChanging(value);
					this.SendPropertyChanging();
					this._Img = value;
					this.SendPropertyChanged("Img");
					this.OnImgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Team_SportsEquipment", Storage="_Team", ThisKey="IdOfTheGroup", OtherKey="Id", IsForeignKey=true)]
		public Team Team
		{
			get
			{
				return this._Team.Entity;
			}
			set
			{
				Team previousValue = this._Team.Entity;
				if (((previousValue != value) 
							|| (this._Team.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Team.Entity = null;
						previousValue.SportsEquipments.Remove(this);
					}
					this._Team.Entity = value;
					if ((value != null))
					{
						value.SportsEquipments.Add(this);
						this._IdOfTheGroup = value.Id;
					}
					else
					{
						this._IdOfTheGroup = default(Nullable<int>);
					}
					this.SendPropertyChanged("Team");
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
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Team")]
	public partial class Team : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _NameOfTheTeam;
		
		private EntitySet<SportsEquipment> _SportsEquipments;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameOfTheTeamChanging(string value);
    partial void OnNameOfTheTeamChanged();
    #endregion
		
		public Team()
		{
			this._SportsEquipments = new EntitySet<SportsEquipment>(new Action<SportsEquipment>(this.attach_SportsEquipments), new Action<SportsEquipment>(this.detach_SportsEquipments));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameOfTheTeam", DbType="VarChar(40)")]
		public string NameOfTheTeam
		{
			get
			{
				return this._NameOfTheTeam;
			}
			set
			{
				if ((this._NameOfTheTeam != value))
				{
					this.OnNameOfTheTeamChanging(value);
					this.SendPropertyChanging();
					this._NameOfTheTeam = value;
					this.SendPropertyChanged("NameOfTheTeam");
					this.OnNameOfTheTeamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Team_SportsEquipment", Storage="_SportsEquipments", ThisKey="Id", OtherKey="IdOfTheGroup")]
		public EntitySet<SportsEquipment> SportsEquipments
		{
			get
			{
				return this._SportsEquipments;
			}
			set
			{
				this._SportsEquipments.Assign(value);
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
		
		private void attach_SportsEquipments(SportsEquipment entity)
		{
			this.SendPropertyChanging();
			entity.Team = this;
		}
		
		private void detach_SportsEquipments(SportsEquipment entity)
		{
			this.SendPropertyChanging();
			entity.Team = null;
		}
	}
}
#pragma warning restore 1591
