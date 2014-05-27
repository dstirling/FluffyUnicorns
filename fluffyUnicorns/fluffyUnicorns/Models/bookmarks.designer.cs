﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fluffyUnicorns.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="fluffyUnicorns")]
	public partial class bookmarksDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertbookmark(bookmark instance);
    partial void Updatebookmark(bookmark instance);
    partial void Deletebookmark(bookmark instance);
    #endregion
		
		public bookmarksDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["fluffyUnicornsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public bookmarksDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public bookmarksDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public bookmarksDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public bookmarksDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<bookmark> bookmarks
		{
			get
			{
				return this.GetTable<bookmark>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.bookmarks")]
	public partial class bookmark : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _fileName;
		
		private string _fileData;
		
		private string _fileDescription;
		
		private string _browser;
		
		private System.Nullable<int> _userID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnfileNameChanging(string value);
    partial void OnfileNameChanged();
    partial void OnfileDataChanging(string value);
    partial void OnfileDataChanged();
    partial void OnfileDescriptionChanging(string value);
    partial void OnfileDescriptionChanged();
    partial void OnbrowserChanging(string value);
    partial void OnbrowserChanged();
    partial void OnuserIDChanging(System.Nullable<int> value);
    partial void OnuserIDChanged();
    #endregion
		
		public bookmark()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fileName", DbType="VarChar(50)")]
		public string fileName
		{
			get
			{
				return this._fileName;
			}
			set
			{
				if ((this._fileName != value))
				{
					this.OnfileNameChanging(value);
					this.SendPropertyChanging();
					this._fileName = value;
					this.SendPropertyChanged("fileName");
					this.OnfileNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fileData", DbType="VarChar(100)")]
		public string fileData
		{
			get
			{
				return this._fileData;
			}
			set
			{
				if ((this._fileData != value))
				{
					this.OnfileDataChanging(value);
					this.SendPropertyChanging();
					this._fileData = value;
					this.SendPropertyChanged("fileData");
					this.OnfileDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fileDescription", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string fileDescription
		{
			get
			{
				return this._fileDescription;
			}
			set
			{
				if ((this._fileDescription != value))
				{
					this.OnfileDescriptionChanging(value);
					this.SendPropertyChanging();
					this._fileDescription = value;
					this.SendPropertyChanged("fileDescription");
					this.OnfileDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_browser", DbType="VarChar(50)")]
		public string browser
		{
			get
			{
				return this._browser;
			}
			set
			{
				if ((this._browser != value))
				{
					this.OnbrowserChanging(value);
					this.SendPropertyChanging();
					this._browser = value;
					this.SendPropertyChanged("browser");
					this.OnbrowserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="Int")]
		public System.Nullable<int> userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
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
