﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EyePatch.Blog.Entity
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EyePatch")]
	public partial class EyePatchBlogDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTag(Tag instance);
    partial void UpdateTag(Tag instance);
    partial void DeleteTag(Tag instance);
    partial void InsertPostTag(PostTag instance);
    partial void UpdatePostTag(PostTag instance);
    partial void DeletePostTag(PostTag instance);
    partial void InsertBlogInfo(BlogInfo instance);
    partial void UpdateBlogInfo(BlogInfo instance);
    partial void DeleteBlogInfo(BlogInfo instance);
    partial void InsertPost(Post instance);
    partial void UpdatePost(Post instance);
    partial void DeletePost(Post instance);
    #endregion
		
		public EyePatchBlogDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["EyePatchConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EyePatchBlogDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EyePatchBlogDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EyePatchBlogDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EyePatchBlogDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Tag> Tags
		{
			get
			{
				return this.GetTable<Tag>();
			}
		}
		
		public System.Data.Linq.Table<PostTag> PostTags
		{
			get
			{
				return this.GetTable<PostTag>();
			}
		}
		
		public System.Data.Linq.Table<BlogInfo> BlogInfos
		{
			get
			{
				return this.GetTable<BlogInfo>();
			}
		}
		
		public System.Data.Linq.Table<Post> Posts
		{
			get
			{
				return this.GetTable<Post>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tag")]
	public partial class Tag : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Tag1;
		
		private EntitySet<PostTag> _PostTags;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Tag()
		{
			this._PostTags = new EntitySet<PostTag>(new Action<PostTag>(this.attach_PostTags), new Action<PostTag>(this.detach_PostTags));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Tag", Storage="_Tag1", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Tag1;
			}
			set
			{
				if ((this._Tag1 != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Tag1 = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tag_PostTag", Storage="_PostTags", ThisKey="ID", OtherKey="TagId")]
		public EntitySet<PostTag> PostTags
		{
			get
			{
				return this._PostTags;
			}
			set
			{
				this._PostTags.Assign(value);
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
		
		private void attach_PostTags(PostTag entity)
		{
			this.SendPropertyChanging();
			entity.Tag = this;
		}
		
		private void detach_PostTags(PostTag entity)
		{
			this.SendPropertyChanging();
			entity.Tag = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PostTags")]
	public partial class PostTag : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PostId;
		
		private int _TagId;
		
		private EntityRef<Tag> _Tag;
		
		private EntityRef<Post> _Post;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPostIdChanging(int value);
    partial void OnPostIdChanged();
    partial void OnTagIdChanging(int value);
    partial void OnTagIdChanged();
    #endregion
		
		public PostTag()
		{
			this._Tag = default(EntityRef<Tag>);
			this._Post = default(EntityRef<Post>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PostId
		{
			get
			{
				return this._PostId;
			}
			set
			{
				if ((this._PostId != value))
				{
					if (this._Post.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPostIdChanging(value);
					this.SendPropertyChanging();
					this._PostId = value;
					this.SendPropertyChanged("PostId");
					this.OnPostIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TagId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int TagId
		{
			get
			{
				return this._TagId;
			}
			set
			{
				if ((this._TagId != value))
				{
					if (this._Tag.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTagIdChanging(value);
					this.SendPropertyChanging();
					this._TagId = value;
					this.SendPropertyChanged("TagId");
					this.OnTagIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tag_PostTag", Storage="_Tag", ThisKey="TagId", OtherKey="ID", IsForeignKey=true)]
		public Tag Tag
		{
			get
			{
				return this._Tag.Entity;
			}
			set
			{
				Tag previousValue = this._Tag.Entity;
				if (((previousValue != value) 
							|| (this._Tag.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tag.Entity = null;
						previousValue.PostTags.Remove(this);
					}
					this._Tag.Entity = value;
					if ((value != null))
					{
						value.PostTags.Add(this);
						this._TagId = value.ID;
					}
					else
					{
						this._TagId = default(int);
					}
					this.SendPropertyChanged("Tag");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Post_PostTag", Storage="_Post", ThisKey="PostId", OtherKey="ID", IsForeignKey=true)]
		public Post Post
		{
			get
			{
				return this._Post.Entity;
			}
			set
			{
				Post previousValue = this._Post.Entity;
				if (((previousValue != value) 
							|| (this._Post.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Post.Entity = null;
						previousValue.PostTags.Remove(this);
					}
					this._Post.Entity = value;
					if ((value != null))
					{
						value.PostTags.Add(this);
						this._PostId = value.ID;
					}
					else
					{
						this._PostId = default(int);
					}
					this.SendPropertyChanged("Post");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BlogInfo")]
	public partial class BlogInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _ListPageID;
		
		private int _PostPageID;
		
		private string _Disqus;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnListPageIDChanging(int value);
    partial void OnListPageIDChanged();
    partial void OnPostPageIDChanging(int value);
    partial void OnPostPageIDChanged();
    partial void OnDisqusChanging(string value);
    partial void OnDisqusChanged();
    #endregion
		
		public BlogInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ListPageID", DbType="Int NOT NULL")]
		public int ListPageID
		{
			get
			{
				return this._ListPageID;
			}
			set
			{
				if ((this._ListPageID != value))
				{
					this.OnListPageIDChanging(value);
					this.SendPropertyChanging();
					this._ListPageID = value;
					this.SendPropertyChanged("ListPageID");
					this.OnListPageIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostPageID", DbType="Int NOT NULL")]
		public int PostPageID
		{
			get
			{
				return this._PostPageID;
			}
			set
			{
				if ((this._PostPageID != value))
				{
					this.OnPostPageIDChanging(value);
					this.SendPropertyChanging();
					this._PostPageID = value;
					this.SendPropertyChanged("PostPageID");
					this.OnPostPageIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Disqus", DbType="NVarChar(MAX)")]
		public string Disqus
		{
			get
			{
				return this._Disqus;
			}
			set
			{
				if ((this._Disqus != value))
				{
					this.OnDisqusChanging(value);
					this.SendPropertyChanging();
					this._Disqus = value;
					this.SendPropertyChanged("Disqus");
					this.OnDisqusChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Post")]
	public partial class Post : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Title;
		
		private string _Url;
		
		private string _Body;
		
		private System.DateTime _Created;
		
		private System.Nullable<System.DateTime> _Published;
		
		private System.Nullable<System.DateTime> _LastModified;
		
		private EntitySet<PostTag> _PostTags;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    partial void OnBodyChanging(string value);
    partial void OnBodyChanged();
    partial void OnCreatedChanging(System.DateTime value);
    partial void OnCreatedChanged();
    partial void OnPublishedChanging(System.Nullable<System.DateTime> value);
    partial void OnPublishedChanged();
    partial void OnLastModifiedChanging(System.Nullable<System.DateTime> value);
    partial void OnLastModifiedChanged();
    #endregion
		
		public Post()
		{
			this._PostTags = new EntitySet<PostTag>(new Action<PostTag>(this.attach_PostTags), new Action<PostTag>(this.detach_PostTags));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Url
		{
			get
			{
				return this._Url;
			}
			set
			{
				if ((this._Url != value))
				{
					this.OnUrlChanging(value);
					this.SendPropertyChanging();
					this._Url = value;
					this.SendPropertyChanged("Url");
					this.OnUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="NText NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this.OnBodyChanging(value);
					this.SendPropertyChanging();
					this._Body = value;
					this.SendPropertyChanged("Body");
					this.OnBodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Created", DbType="DateTime2 NOT NULL")]
		public System.DateTime Created
		{
			get
			{
				return this._Created;
			}
			set
			{
				if ((this._Created != value))
				{
					this.OnCreatedChanging(value);
					this.SendPropertyChanging();
					this._Created = value;
					this.SendPropertyChanged("Created");
					this.OnCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Published", DbType="DateTime2")]
		public System.Nullable<System.DateTime> Published
		{
			get
			{
				return this._Published;
			}
			set
			{
				if ((this._Published != value))
				{
					this.OnPublishedChanging(value);
					this.SendPropertyChanging();
					this._Published = value;
					this.SendPropertyChanged("Published");
					this.OnPublishedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastModified", DbType="DateTime2")]
		public System.Nullable<System.DateTime> LastModified
		{
			get
			{
				return this._LastModified;
			}
			set
			{
				if ((this._LastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._LastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Post_PostTag", Storage="_PostTags", ThisKey="ID", OtherKey="PostId")]
		public EntitySet<PostTag> PostTags
		{
			get
			{
				return this._PostTags;
			}
			set
			{
				this._PostTags.Assign(value);
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
		
		private void attach_PostTags(PostTag entity)
		{
			this.SendPropertyChanging();
			entity.Post = this;
		}
		
		private void detach_PostTags(PostTag entity)
		{
			this.SendPropertyChanging();
			entity.Post = null;
		}
	}
}
#pragma warning restore 1591
