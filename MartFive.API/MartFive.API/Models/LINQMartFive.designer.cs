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

namespace MartFive.API.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PagalMart")]
	public partial class LINQMartFiveDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertItem(Item instance);
    partial void UpdateItem(Item instance);
    partial void DeleteItem(Item instance);
    partial void InsertPicture(Picture instance);
    partial void UpdatePicture(Picture instance);
    partial void DeletePicture(Picture instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public LINQMartFiveDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["PagalMartConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LINQMartFiveDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQMartFiveDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQMartFiveDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQMartFiveDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Item> Items
		{
			get
			{
				return this.GetTable<Item>();
			}
		}
		
		public System.Data.Linq.Table<Picture> Pictures
		{
			get
			{
				return this.GetTable<Picture>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Item")]
	public partial class Item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Item_Id;
		
		private string _Item_Name;
		
		private System.Nullable<int> _Item_Price;
		
		private string _Item_Description;
		
		private System.Nullable<int> _Item_Quantity;
		
		private int _Pic_Id;
		
		private int _SCat_Id;
		
		private EntityRef<Picture> _Picture;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItem_IdChanging(int value);
    partial void OnItem_IdChanged();
    partial void OnItem_NameChanging(string value);
    partial void OnItem_NameChanged();
    partial void OnItem_PriceChanging(System.Nullable<int> value);
    partial void OnItem_PriceChanged();
    partial void OnItem_DescriptionChanging(string value);
    partial void OnItem_DescriptionChanged();
    partial void OnItem_QuantityChanging(System.Nullable<int> value);
    partial void OnItem_QuantityChanged();
    partial void OnPic_IdChanging(int value);
    partial void OnPic_IdChanged();
    partial void OnSCat_IdChanging(int value);
    partial void OnSCat_IdChanged();
    #endregion
		
		public Item()
		{
			this._Picture = default(EntityRef<Picture>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Item_Id
		{
			get
			{
				return this._Item_Id;
			}
			set
			{
				if ((this._Item_Id != value))
				{
					this.OnItem_IdChanging(value);
					this.SendPropertyChanging();
					this._Item_Id = value;
					this.SendPropertyChanged("Item_Id");
					this.OnItem_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_Name", DbType="NVarChar(MAX)")]
		public string Item_Name
		{
			get
			{
				return this._Item_Name;
			}
			set
			{
				if ((this._Item_Name != value))
				{
					this.OnItem_NameChanging(value);
					this.SendPropertyChanging();
					this._Item_Name = value;
					this.SendPropertyChanged("Item_Name");
					this.OnItem_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_Price", DbType="Int")]
		public System.Nullable<int> Item_Price
		{
			get
			{
				return this._Item_Price;
			}
			set
			{
				if ((this._Item_Price != value))
				{
					this.OnItem_PriceChanging(value);
					this.SendPropertyChanging();
					this._Item_Price = value;
					this.SendPropertyChanged("Item_Price");
					this.OnItem_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_Description", DbType="NVarChar(MAX)")]
		public string Item_Description
		{
			get
			{
				return this._Item_Description;
			}
			set
			{
				if ((this._Item_Description != value))
				{
					this.OnItem_DescriptionChanging(value);
					this.SendPropertyChanging();
					this._Item_Description = value;
					this.SendPropertyChanged("Item_Description");
					this.OnItem_DescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_Quantity", DbType="Int")]
		public System.Nullable<int> Item_Quantity
		{
			get
			{
				return this._Item_Quantity;
			}
			set
			{
				if ((this._Item_Quantity != value))
				{
					this.OnItem_QuantityChanging(value);
					this.SendPropertyChanging();
					this._Item_Quantity = value;
					this.SendPropertyChanged("Item_Quantity");
					this.OnItem_QuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pic_Id", DbType="Int NOT NULL")]
		public int Pic_Id
		{
			get
			{
				return this._Pic_Id;
			}
			set
			{
				if ((this._Pic_Id != value))
				{
					if (this._Picture.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPic_IdChanging(value);
					this.SendPropertyChanging();
					this._Pic_Id = value;
					this.SendPropertyChanged("Pic_Id");
					this.OnPic_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCat_Id", DbType="Int NOT NULL")]
		public int SCat_Id
		{
			get
			{
				return this._SCat_Id;
			}
			set
			{
				if ((this._SCat_Id != value))
				{
					this.OnSCat_IdChanging(value);
					this.SendPropertyChanging();
					this._SCat_Id = value;
					this.SendPropertyChanged("SCat_Id");
					this.OnSCat_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Picture_Item", Storage="_Picture", ThisKey="Pic_Id", OtherKey="Pic_Id", IsForeignKey=true)]
		public Picture Picture
		{
			get
			{
				return this._Picture.Entity;
			}
			set
			{
				Picture previousValue = this._Picture.Entity;
				if (((previousValue != value) 
							|| (this._Picture.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Picture.Entity = null;
						previousValue.Items.Remove(this);
					}
					this._Picture.Entity = value;
					if ((value != null))
					{
						value.Items.Add(this);
						this._Pic_Id = value.Pic_Id;
					}
					else
					{
						this._Pic_Id = default(int);
					}
					this.SendPropertyChanged("Picture");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Picture")]
	public partial class Picture : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Pic_Id;
		
		private string _Pic_Name;
		
		private EntitySet<Item> _Items;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPic_IdChanging(int value);
    partial void OnPic_IdChanged();
    partial void OnPic_NameChanging(string value);
    partial void OnPic_NameChanged();
    #endregion
		
		public Picture()
		{
			this._Items = new EntitySet<Item>(new Action<Item>(this.attach_Items), new Action<Item>(this.detach_Items));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pic_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Pic_Id
		{
			get
			{
				return this._Pic_Id;
			}
			set
			{
				if ((this._Pic_Id != value))
				{
					this.OnPic_IdChanging(value);
					this.SendPropertyChanging();
					this._Pic_Id = value;
					this.SendPropertyChanged("Pic_Id");
					this.OnPic_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pic_Name", DbType="NVarChar(MAX)")]
		public string Pic_Name
		{
			get
			{
				return this._Pic_Name;
			}
			set
			{
				if ((this._Pic_Name != value))
				{
					this.OnPic_NameChanging(value);
					this.SendPropertyChanging();
					this._Pic_Name = value;
					this.SendPropertyChanged("Pic_Name");
					this.OnPic_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Picture_Item", Storage="_Items", ThisKey="Pic_Id", OtherKey="Pic_Id")]
		public EntitySet<Item> Items
		{
			get
			{
				return this._Items;
			}
			set
			{
				this._Items.Assign(value);
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
		
		private void attach_Items(Item entity)
		{
			this.SendPropertyChanging();
			entity.Picture = this;
		}
		
		private void detach_Items(Item entity)
		{
			this.SendPropertyChanging();
			entity.Picture = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _User_Id;
		
		private string _First_Name;
		
		private string _Last_Name;
		
		private string _User_Password;
		
		private string _User_Email;
		
		private bool _User_Status;
		
		private string _User_Phone;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IdChanging(int value);
    partial void OnUser_IdChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnUser_PasswordChanging(string value);
    partial void OnUser_PasswordChanged();
    partial void OnUser_EmailChanging(string value);
    partial void OnUser_EmailChanged();
    partial void OnUser_StatusChanging(bool value);
    partial void OnUser_StatusChanged();
    partial void OnUser_PhoneChanging(string value);
    partial void OnUser_PhoneChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int User_Id
		{
			get
			{
				return this._User_Id;
			}
			set
			{
				if ((this._User_Id != value))
				{
					this.OnUser_IdChanging(value);
					this.SendPropertyChanging();
					this._User_Id = value;
					this.SendPropertyChanged("User_Id");
					this.OnUser_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="NVarChar(MAX)")]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Name", DbType="NVarChar(MAX)")]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Password", DbType="NVarChar(MAX)")]
		public string User_Password
		{
			get
			{
				return this._User_Password;
			}
			set
			{
				if ((this._User_Password != value))
				{
					this.OnUser_PasswordChanging(value);
					this.SendPropertyChanging();
					this._User_Password = value;
					this.SendPropertyChanged("User_Password");
					this.OnUser_PasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Email", DbType="NVarChar(MAX)")]
		public string User_Email
		{
			get
			{
				return this._User_Email;
			}
			set
			{
				if ((this._User_Email != value))
				{
					this.OnUser_EmailChanging(value);
					this.SendPropertyChanging();
					this._User_Email = value;
					this.SendPropertyChanged("User_Email");
					this.OnUser_EmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Status", DbType="Bit NOT NULL")]
		public bool User_Status
		{
			get
			{
				return this._User_Status;
			}
			set
			{
				if ((this._User_Status != value))
				{
					this.OnUser_StatusChanging(value);
					this.SendPropertyChanging();
					this._User_Status = value;
					this.SendPropertyChanged("User_Status");
					this.OnUser_StatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Phone", DbType="NVarChar(MAX)")]
		public string User_Phone
		{
			get
			{
				return this._User_Phone;
			}
			set
			{
				if ((this._User_Phone != value))
				{
					this.OnUser_PhoneChanging(value);
					this.SendPropertyChanging();
					this._User_Phone = value;
					this.SendPropertyChanged("User_Phone");
					this.OnUser_PhoneChanged();
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
}
#pragma warning restore 1591