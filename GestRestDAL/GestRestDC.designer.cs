﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestRestDAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GestRest")]
	public partial class GestRestDCDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertReserva(Reserva instance);
    partial void UpdateReserva(Reserva instance);
    partial void DeleteReserva(Reserva instance);
    #endregion
		
		public GestRestDCDataContext() : 
				base(global::GestRestDAL.Properties.Settings.Default.GestRestConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public GestRestDCDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GestRestDCDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GestRestDCDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GestRestDCDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Reserva> Reservas
		{
			get
			{
				return this.GetTable<Reserva>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Reservas")]
	public partial class Reserva : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nombre;
		
		private System.DateTime _Fecha;
		
		private System.Nullable<int> _Mesa;
		
		private System.Nullable<int> _Comensales;
		
		private string _Telefono;
		
		private bool _HanLlegado;
		
		private System.Nullable<int> _Turno;
		
		private string _Comentarios;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnFechaChanging(System.DateTime value);
    partial void OnFechaChanged();
    partial void OnMesaChanging(System.Nullable<int> value);
    partial void OnMesaChanged();
    partial void OnComensalesChanging(System.Nullable<int> value);
    partial void OnComensalesChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    partial void OnHanLlegadoChanging(bool value);
    partial void OnHanLlegadoChanged();
    partial void OnTurnoChanging(System.Nullable<int> value);
    partial void OnTurnoChanged();
    partial void OnComentariosChanging(string value);
    partial void OnComentariosChanged();
    #endregion
		
		public Reserva()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="DateTime NOT NULL")]
		public System.DateTime Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this.OnFechaChanging(value);
					this.SendPropertyChanging();
					this._Fecha = value;
					this.SendPropertyChanged("Fecha");
					this.OnFechaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mesa", DbType="Int")]
		public System.Nullable<int> Mesa
		{
			get
			{
				return this._Mesa;
			}
			set
			{
				if ((this._Mesa != value))
				{
					this.OnMesaChanging(value);
					this.SendPropertyChanging();
					this._Mesa = value;
					this.SendPropertyChanged("Mesa");
					this.OnMesaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comensales", DbType="Int")]
		public System.Nullable<int> Comensales
		{
			get
			{
				return this._Comensales;
			}
			set
			{
				if ((this._Comensales != value))
				{
					this.OnComensalesChanging(value);
					this.SendPropertyChanging();
					this._Comensales = value;
					this.SendPropertyChanged("Comensales");
					this.OnComensalesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="NVarChar(20)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HanLlegado", DbType="Bit NOT NULL")]
		public bool HanLlegado
		{
			get
			{
				return this._HanLlegado;
			}
			set
			{
				if ((this._HanLlegado != value))
				{
					this.OnHanLlegadoChanging(value);
					this.SendPropertyChanging();
					this._HanLlegado = value;
					this.SendPropertyChanged("HanLlegado");
					this.OnHanLlegadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Turno", DbType="Int")]
		public System.Nullable<int> Turno
		{
			get
			{
				return this._Turno;
			}
			set
			{
				if ((this._Turno != value))
				{
					this.OnTurnoChanging(value);
					this.SendPropertyChanging();
					this._Turno = value;
					this.SendPropertyChanged("Turno");
					this.OnTurnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comentarios", DbType="NVarChar(250)")]
		public string Comentarios
		{
			get
			{
				return this._Comentarios;
			}
			set
			{
				if ((this._Comentarios != value))
				{
					this.OnComentariosChanging(value);
					this.SendPropertyChanging();
					this._Comentarios = value;
					this.SendPropertyChanged("Comentarios");
					this.OnComentariosChanged();
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