#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPC.CTD.BL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbCuidateBien")]
	public partial class dmCovidTrackingDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertOrganizacion(Organizacion instance);
    partial void UpdateOrganizacion(Organizacion instance);
    partial void DeleteOrganizacion(Organizacion instance);
    partial void InsertRecomendacionOrganizacion(RecomendacionOrganizacion instance);
    partial void UpdateRecomendacionOrganizacion(RecomendacionOrganizacion instance);
    partial void DeleteRecomendacionOrganizacion(RecomendacionOrganizacion instance);
    partial void InsertRecomendacionDia(RecomendacionDia instance);
    partial void UpdateRecomendacionDia(RecomendacionDia instance);
    partial void DeleteRecomendacionDia(RecomendacionDia instance);
    #endregion
		
		public dmCovidTrackingDataContext() : 
				base(global::UPC.CTD.BL.Properties.Settings.Default.dbCuidateBienConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dmCovidTrackingDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dmCovidTrackingDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dmCovidTrackingDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dmCovidTrackingDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Organizacion> Organizacions
		{
			get
			{
				return this.GetTable<Organizacion>();
			}
		}
		
		public System.Data.Linq.Table<RecomendacionOrganizacion> RecomendacionOrganizacions
		{
			get
			{
				return this.GetTable<RecomendacionOrganizacion>();
			}
		}
		
		public System.Data.Linq.Table<RecomendacionDia> RecomendacionDias
		{
			get
			{
				return this.GetTable<RecomendacionDia>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Organizacion")]
	public partial class Organizacion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nombre;
		
		private bool _Activo;
		
		private EntitySet<RecomendacionOrganizacion> _RecomendacionOrganizacions;
		
		private EntitySet<RecomendacionDia> _RecomendacionDias;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnActivoChanging(bool value);
    partial void OnActivoChanged();
    #endregion
		
		public Organizacion()
		{
			this._RecomendacionOrganizacions = new EntitySet<RecomendacionOrganizacion>(new Action<RecomendacionOrganizacion>(this.attach_RecomendacionOrganizacions), new Action<RecomendacionOrganizacion>(this.detach_RecomendacionOrganizacions));
			this._RecomendacionDias = new EntitySet<RecomendacionDia>(new Action<RecomendacionDia>(this.attach_RecomendacionDias), new Action<RecomendacionDia>(this.detach_RecomendacionDias));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Activo", DbType="Bit NOT NULL")]
		public bool Activo
		{
			get
			{
				return this._Activo;
			}
			set
			{
				if ((this._Activo != value))
				{
					this.OnActivoChanging(value);
					this.SendPropertyChanging();
					this._Activo = value;
					this.SendPropertyChanged("Activo");
					this.OnActivoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Organizacion_RecomendacionOrganizacion", Storage="_RecomendacionOrganizacions", ThisKey="Id", OtherKey="IdOrganizacion")]
		public EntitySet<RecomendacionOrganizacion> RecomendacionOrganizacions
		{
			get
			{
				return this._RecomendacionOrganizacions;
			}
			set
			{
				this._RecomendacionOrganizacions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Organizacion_RecomendacionDia", Storage="_RecomendacionDias", ThisKey="Id", OtherKey="IdOrganizacion")]
		public EntitySet<RecomendacionDia> RecomendacionDias
		{
			get
			{
				return this._RecomendacionDias;
			}
			set
			{
				this._RecomendacionDias.Assign(value);
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
		
		private void attach_RecomendacionOrganizacions(RecomendacionOrganizacion entity)
		{
			this.SendPropertyChanging();
			entity.Organizacion = this;
		}
		
		private void detach_RecomendacionOrganizacions(RecomendacionOrganizacion entity)
		{
			this.SendPropertyChanging();
			entity.Organizacion = null;
		}
		
		private void attach_RecomendacionDias(RecomendacionDia entity)
		{
			this.SendPropertyChanging();
			entity.Organizacion = this;
		}
		
		private void detach_RecomendacionDias(RecomendacionDia entity)
		{
			this.SendPropertyChanging();
			entity.Organizacion = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RecomendacionOrganizacion")]
	public partial class RecomendacionOrganizacion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _IdOrganizacion;
		
		private string _Recomendacion;
		
		private bool _Activo;
		
		private EntityRef<Organizacion> _Organizacion;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnIdOrganizacionChanging(int value);
    partial void OnIdOrganizacionChanged();
    partial void OnRecomendacionChanging(string value);
    partial void OnRecomendacionChanged();
    partial void OnActivoChanging(bool value);
    partial void OnActivoChanged();
    #endregion
		
		public RecomendacionOrganizacion()
		{
			this._Organizacion = default(EntityRef<Organizacion>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdOrganizacion", DbType="Int NOT NULL")]
		public int IdOrganizacion
		{
			get
			{
				return this._IdOrganizacion;
			}
			set
			{
				if ((this._IdOrganizacion != value))
				{
					if (this._Organizacion.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdOrganizacionChanging(value);
					this.SendPropertyChanging();
					this._IdOrganizacion = value;
					this.SendPropertyChanged("IdOrganizacion");
					this.OnIdOrganizacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Recomendacion", DbType="VarChar(1000) NOT NULL", CanBeNull=false)]
		public string Recomendacion
		{
			get
			{
				return this._Recomendacion;
			}
			set
			{
				if ((this._Recomendacion != value))
				{
					this.OnRecomendacionChanging(value);
					this.SendPropertyChanging();
					this._Recomendacion = value;
					this.SendPropertyChanged("Recomendacion");
					this.OnRecomendacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Activo", DbType="Bit NOT NULL")]
		public bool Activo
		{
			get
			{
				return this._Activo;
			}
			set
			{
				if ((this._Activo != value))
				{
					this.OnActivoChanging(value);
					this.SendPropertyChanging();
					this._Activo = value;
					this.SendPropertyChanged("Activo");
					this.OnActivoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Organizacion_RecomendacionOrganizacion", Storage="_Organizacion", ThisKey="IdOrganizacion", OtherKey="Id", IsForeignKey=true)]
		public Organizacion Organizacion
		{
			get
			{
				return this._Organizacion.Entity;
			}
			set
			{
				Organizacion previousValue = this._Organizacion.Entity;
				if (((previousValue != value) 
							|| (this._Organizacion.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Organizacion.Entity = null;
						previousValue.RecomendacionOrganizacions.Remove(this);
					}
					this._Organizacion.Entity = value;
					if ((value != null))
					{
						value.RecomendacionOrganizacions.Add(this);
						this._IdOrganizacion = value.Id;
					}
					else
					{
						this._IdOrganizacion = default(int);
					}
					this.SendPropertyChanged("Organizacion");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RecomendacionDia")]
	public partial class RecomendacionDia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Dia;
		
		private int _IdOrganizacion;
		
		private string _Recomendacion;
		
		private EntityRef<Organizacion> _Organizacion;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDiaChanging(int value);
    partial void OnDiaChanged();
    partial void OnIdOrganizacionChanging(int value);
    partial void OnIdOrganizacionChanged();
    partial void OnRecomendacionChanging(string value);
    partial void OnRecomendacionChanged();
    #endregion
		
		public RecomendacionDia()
		{
			this._Organizacion = default(EntityRef<Organizacion>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dia", DbType="Int NOT NULL")]
		public int Dia
		{
			get
			{
				return this._Dia;
			}
			set
			{
				if ((this._Dia != value))
				{
					this.OnDiaChanging(value);
					this.SendPropertyChanging();
					this._Dia = value;
					this.SendPropertyChanged("Dia");
					this.OnDiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdOrganizacion", DbType="Int NOT NULL")]
		public int IdOrganizacion
		{
			get
			{
				return this._IdOrganizacion;
			}
			set
			{
				if ((this._IdOrganizacion != value))
				{
					if (this._Organizacion.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdOrganizacionChanging(value);
					this.SendPropertyChanging();
					this._IdOrganizacion = value;
					this.SendPropertyChanged("IdOrganizacion");
					this.OnIdOrganizacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Recomendacion", DbType="VarChar(1000) NOT NULL", CanBeNull=false)]
		public string Recomendacion
		{
			get
			{
				return this._Recomendacion;
			}
			set
			{
				if ((this._Recomendacion != value))
				{
					this.OnRecomendacionChanging(value);
					this.SendPropertyChanging();
					this._Recomendacion = value;
					this.SendPropertyChanged("Recomendacion");
					this.OnRecomendacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Organizacion_RecomendacionDia", Storage="_Organizacion", ThisKey="IdOrganizacion", OtherKey="Id", IsForeignKey=true)]
		public Organizacion Organizacion
		{
			get
			{
				return this._Organizacion.Entity;
			}
			set
			{
				Organizacion previousValue = this._Organizacion.Entity;
				if (((previousValue != value) 
							|| (this._Organizacion.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Organizacion.Entity = null;
						previousValue.RecomendacionDias.Remove(this);
					}
					this._Organizacion.Entity = value;
					if ((value != null))
					{
						value.RecomendacionDias.Add(this);
						this._IdOrganizacion = value.Id;
					}
					else
					{
						this._IdOrganizacion = default(int);
					}
					this.SendPropertyChanged("Organizacion");
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
