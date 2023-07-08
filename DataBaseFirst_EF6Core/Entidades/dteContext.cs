using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataBaseFirst_EF6Core.Entidades
{
    public partial class dteContext : DbContext
    {
        public dteContext()
        {
        }

        public dteContext(DbContextOptions<dteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accion> Accions { get; set; } = null!;
        public virtual DbSet<AmbienteDestino> AmbienteDestinos { get; set; } = null!;
        public virtual DbSet<Automatizacion> Automatizacions { get; set; } = null!;
        public virtual DbSet<Cabecera> Cabeceras { get; set; } = null!;
        public virtual DbSet<CabeceraAlert> CabeceraAlerts { get; set; } = null!;
        public virtual DbSet<CabeceraCore> CabeceraCores { get; set; } = null!;
        public virtual DbSet<CabeceraDetalle> CabeceraDetalles { get; set; } = null!;
        public virtual DbSet<CabeceraIncidencium> CabeceraIncidencia { get; set; } = null!;
        public virtual DbSet<CabeceraJson> CabeceraJsons { get; set; } = null!;
        public virtual DbSet<CabeceraPropiedad> CabeceraPropiedads { get; set; } = null!;
        public virtual DbSet<CabeceraReintentoCore> CabeceraReintentoCores { get; set; } = null!;
        public virtual DbSet<CabeceraReintentoJson> CabeceraReintentoJsons { get; set; } = null!;
        public virtual DbSet<CabeceraWeb> CabeceraWebs { get; set; } = null!;
        public virtual DbSet<Capitalizacion> Capitalizacions { get; set; } = null!;
        public virtual DbSet<CodigoActividadEconomica> CodigoActividadEconomicas { get; set; } = null!;
        public virtual DbSet<CodigoImportacion> CodigoImportacions { get; set; } = null!;
        public virtual DbSet<Color> Colors { get; set; } = null!;
        public virtual DbSet<CondicionOperacion> CondicionOperacions { get; set; } = null!;
        public virtual DbSet<Conexion> Conexions { get; set; } = null!;
        public virtual DbSet<Controlador> Controladors { get; set; } = null!;
        public virtual DbSet<Correo> Correos { get; set; } = null!;
        public virtual DbSet<CorreoXAccion> CorreoXAccions { get; set; } = null!;
        public virtual DbSet<CorreoXAccion1> CorreoXAccions1 { get; set; } = null!;
        public virtual DbSet<DatosDte> DatosDtes { get; set; } = null!;
        public virtual DbSet<Departamento> Departamentos { get; set; } = null!;
        public virtual DbSet<Detalle> Detalles { get; set; } = null!;
        public virtual DbSet<DetalleAlert> DetalleAlerts { get; set; } = null!;
        public virtual DbSet<DetallePropiedad> DetallePropiedads { get; set; } = null!;
        public virtual DbSet<DetalleRegistro> DetalleRegistros { get; set; } = null!;
        public virtual DbSet<ErrorAplicacion> ErrorAplicacions { get; set; } = null!;
        public virtual DbSet<Estado> Estados { get; set; } = null!;
        public virtual DbSet<FormaPago> FormaPagos { get; set; } = null!;
        public virtual DbSet<Json> Jsons { get; set; } = null!;
        public virtual DbSet<ModeloFacturacion> ModeloFacturacions { get; set; } = null!;
        public virtual DbSet<Municipio> Municipios { get; set; } = null!;
        public virtual DbSet<OtrosDocumentosAsociado> OtrosDocumentosAsociados { get; set; } = null!;
        public virtual DbSet<Pai> Pais { get; set; } = null!;
        public virtual DbSet<Parametro> Parametros { get; set; } = null!;
        public virtual DbSet<Pdf> Pdfs { get; set; } = null!;
        public virtual DbSet<PdfSeccion> PdfSeccions { get; set; } = null!;
        public virtual DbSet<PdfVinculacion> PdfVinculacions { get; set; } = null!;
        public virtual DbSet<Plazo> Plazos { get; set; } = null!;
        public virtual DbSet<RecintoFiscal> RecintoFiscals { get; set; } = null!;
        public virtual DbSet<Regiman> Regimen { get; set; } = null!;
        public virtual DbSet<Registro> Registros { get; set; } = null!;
        public virtual DbSet<RetencionIvaMh> RetencionIvaMhs { get; set; } = null!;
        public virtual DbSet<Tabla> Tablas { get; set; } = null!;
        public virtual DbSet<Tipado> Tipados { get; set; } = null!;
        public virtual DbSet<TipoContingencium> TipoContingencia { get; set; } = null!;
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; } = null!;
        public virtual DbSet<TipoDocumentoContingencium> TipoDocumentoContingencia { get; set; } = null!;
        public virtual DbSet<TipoDocumentoIdentificacionReceptor> TipoDocumentoIdentificacionReceptors { get; set; } = null!;
        public virtual DbSet<TipoEstablecimiento> TipoEstablecimientos { get; set; } = null!;
        public virtual DbSet<TipoEstado> TipoEstados { get; set; } = null!;
        public virtual DbSet<TipoGeneracionDocumento> TipoGeneracionDocumentos { get; set; } = null!;
        public virtual DbSet<TipoInvalidacion> TipoInvalidacions { get; set; } = null!;
        public virtual DbSet<TipoItem> TipoItems { get; set; } = null!;
        public virtual DbSet<TipoJson> TipoJsons { get; set; } = null!;
        public virtual DbSet<TipoPersona> TipoPersonas { get; set; } = null!;
        public virtual DbSet<TipoServicioMedico> TipoServicioMedicos { get; set; } = null!;
        public virtual DbSet<TipoTransmision> TipoTransmisions { get; set; } = null!;
        public virtual DbSet<TituloRemitenBiene> TituloRemitenBienes { get; set; } = null!;
        public virtual DbSet<Tributo> Tributos { get; set; } = null!;
        public virtual DbSet<UnidadMedidum> UnidadMedida { get; set; } = null!;
        public virtual DbSet<ValorDefecto> ValorDefectos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accion>(entity =>
            {
                entity.ToTable("accion", "conf");

                entity.HasComment("descrpicion de tipo de accion");

                entity.HasIndex(e => e.Nombre, "accion_nombre_unic")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre")
                    .HasComment("se representara como el titulo del correo");
            });

            modelBuilder.Entity<AmbienteDestino>(entity =>
            {
                entity.ToTable("ambiente_destino");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<Automatizacion>(entity =>
            {
                entity.ToTable("automatizacion", "opc");

                entity.HasComment("Representacion de distintas consultas que se pueden programar para distintas horas, distintos dias o una fecha en especifico");

                entity.HasIndex(e => new { e.TiempoLanzamiento, e.FechaLanzamiento, e.Dia, e.Diario }, "horayfecha")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("identity");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasComment("si esta activo el etl lo agarrara, sino, no");

                entity.Property(e => e.Consulta)
                    .IsUnicode(false)
                    .HasColumnName("consulta")
                    .HasComment("script sql que se ejecutara en ese momento");

                entity.Property(e => e.Descripcion)
                    .IsUnicode(false)
                    .HasColumnName("descripcion")
                    .HasComment("descripcion detallada sobre lo que hace el procedimiento almacenado, se representara en la descripcion de los registros acerca de las acciones que se han realizado");

                entity.Property(e => e.Dia)
                    .HasMaxLength(999)
                    .HasColumnName("dia")
                    .HasComment("que dias se repetiran ? \r\nLunes: lu\r\nMartes: ma\r\nMiercoles: mi\r\nJueves: ju\r\nViernes: vi\r\nSabado: sa\r\nDomingo: do\r\nestos dias deben estar entre ;; cada uno\r\n;;lu;;mi;;vi;;     \r\nSi se escribiese mal no se tomara en cuenta, debe ir capitalizada justo como se ve en la descripcion y sin espacios entre los puntos y comas y los dias");

                entity.Property(e => e.Diario)
                    .HasColumnName("diario")
                    .HasComment("si se repetira diariamente, todos los dias, no se ha consentido en la programacion si puede ser nulo, es un booleano, es true o es false");

                entity.Property(e => e.Error)
                    .HasColumnName("error")
                    .HasComment("conteo de errores, no puede ser nulo porque al momento de hacer la suma no se tiene en cuenta que sea nulo");

                entity.Property(e => e.FechaLanzamiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_lanzamiento")
                    .HasComment("fecha de lanzamiento");

                entity.Property(e => e.Lanzamiento)
                    .HasColumnName("lanzamiento")
                    .HasComment("cantara progresivamente cuantas veces se ha lanzado la automatizacion,no puede ser nulo porque al momento de hacer la suma no se tiene consentido que pueda ser nulo");

                entity.Property(e => e.TiempoLanzamiento)
                    .HasColumnName("tiempo_lanzamiento")
                    .HasComment("hora y minuto de lanzamiento, no puede ser nulo porque siempre se necesita un momento determinado en el que la accion se ejecute");

                entity.Property(e => e.UltimoError)
                    .HasColumnType("datetime")
                    .HasColumnName("ultimo_error")
                    .HasComment("hora y fecha del ultimo error");

                entity.Property(e => e.UltimoLanzamiento)
                    .HasColumnType("datetime")
                    .HasColumnName("ultimo_lanzamiento")
                    .HasComment("fecha y hora del ultimo lanzamiento de este registro en esta tabla");
            });

            modelBuilder.Entity<Cabecera>(entity =>
            {
                entity.HasKey(e => new { e.Uuid, e.Cadena })
                    .HasName("primary_key_cabecera");

                entity.ToTable("cabecera");

                entity.HasIndex(e => e.Integridad, "UQ__cabecera__3847B53F2AF01426")
                    .IsUnique();

                entity.HasIndex(e => e.IdDetalleRegistro, "UQ__cabecera__653D45FD0825BF95")
                    .IsUnique();

                entity.HasIndex(e => new { e.Uuid, e.Eslavon, e.Cadena }, "unique_eslavon_cadena")
                    .IsUnique();

                entity.Property(e => e.Uuid)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("uuid")
                    .HasComment("");

                entity.Property(e => e.Cadena)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("cadena");

                entity.Property(e => e.AceptadoMh).HasColumnName("aceptado_mh");

                entity.Property(e => e.Creacion)
                    .HasColumnType("datetime")
                    .HasColumnName("creacion");

                entity.Property(e => e.DonanteCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodActividad")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonanteCodDomiciliado)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodDomiciliado")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonanteCodPais)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodPais")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonanteCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Correo")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonanteDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donante_DescActividad")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonanteDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Complemento")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonanteDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Departamento")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonanteDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Municipio")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonanteTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Telefono")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonanteTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_TipoDocumento")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonatarioCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodActividad")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonatarioCodEstable)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodEstable")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonatarioCodEstableMh)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodEstableMH")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonatarioCodPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodPuntoVenta")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonatarioCodPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodPuntoVentaMH")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonatarioCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Correo")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonatarioDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Complemento")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonatarioDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Departamento")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonatarioDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Municipio")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonatarioNombre)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Nombre")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonatarioNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_NombreComercial")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonatarioNrc)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Nrc")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonatarioNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_NumDocumento")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonatarioTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Telefono")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonatarioTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_TipoDocumento")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.DonatarioTipoEstablecimiento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_TipoEstablecimiento")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.EmisorCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodActividad");

                entity.Property(e => e.EmisorCodEstable)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodEstable");

                entity.Property(e => e.EmisorCodEstableMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodEstableMH");

                entity.Property(e => e.EmisorCodPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodPuntoVenta");

                entity.Property(e => e.EmisorCodPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodPuntoVentaMH");

                entity.Property(e => e.EmisorCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Codigo")
                    .HasComment("Comprobante de Retención Electrónica");

                entity.Property(e => e.EmisorCodigoMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodigoMH")
                    .HasComment("Comprobante de Retención Electrónica");

                entity.Property(e => e.EmisorCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Correo");

                entity.Property(e => e.EmisorDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_DescActividad");

                entity.Property(e => e.EmisorDireccionComplemento).HasColumnName("Emisor_Direccion_Complemento");

                entity.Property(e => e.EmisorDireccionDepartamento).HasColumnName("Emisor_Direccion_Departamento");

                entity.Property(e => e.EmisorDireccionMunicipio).HasColumnName("Emisor_Direccion_Municipio");

                entity.Property(e => e.EmisorNit)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nit");

                entity.Property(e => e.EmisorNombre)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nombre");

                entity.Property(e => e.EmisorNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_NombreComercial");

                entity.Property(e => e.EmisorNrc)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nrc");

                entity.Property(e => e.EmisorPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVenta")
                    .HasComment("Comprobante de Retención Electrónica");

                entity.Property(e => e.EmisorPuntoVentaContri)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVentaContri")
                    .HasComment("Comprobante de Retención Electrónica");

                entity.Property(e => e.EmisorPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVentaMH")
                    .HasComment("Comprobante de Retención Electrónica");

                entity.Property(e => e.EmisorTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Telefono");

                entity.Property(e => e.EmisorTipoEstablecimiento)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_TipoEstablecimiento");

                entity.Property(e => e.Error)
                    .HasColumnName("error")
                    .HasComment("si el documento tiene algun error");

                entity.Property(e => e.ErrorMh).HasColumnName("error_mh");

                entity.Property(e => e.Eslavon)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("eslavon");

                entity.Property(e => e.EtlCompleto).HasColumnName("etl_completo");

                entity.Property(e => e.ExtensionCodEmpleado)
                    .IsUnicode(false)
                    .HasColumnName("Extension_CodEmpleado")
                    .HasComment("Documento Contable de Liquidación Electrónica");

                entity.Property(e => e.ExtensionDocuEntrega)
                    .IsUnicode(false)
                    .HasColumnName("Extension_DocuEntrega");

                entity.Property(e => e.ExtensionDocuRecibe).HasColumnName("Extension_DocuRecibe");

                entity.Property(e => e.ExtensionNombEntrega).HasColumnName("Extension_NombEntrega");

                entity.Property(e => e.ExtensionNombRecibe).HasColumnName("Extension_NombRecibe");

                entity.Property(e => e.ExtensionObservaciones).HasColumnName("Extension_Observaciones");

                entity.Property(e => e.ExtensionPlacaVehiculo).HasColumnName("Extension_PlacaVehiculo");

                entity.Property(e => e.FechaDte)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("fechaDte");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id")
                    .HasComment("");

                entity.Property(e => e.IdAccion).HasColumnName("id_accion");

                entity.Property(e => e.IdConexion).HasColumnName("id_conexion");

                entity.Property(e => e.IdDetalleRegistro).HasColumnName("id_detalle_registro");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdJson).HasColumnName("id_json");

                entity.Property(e => e.IdTabla).HasColumnName("id_tabla");

                entity.Property(e => e.IdTransaccion).HasColumnName("id_transaccion");

                entity.Property(e => e.IdentificacionAmbiente)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_Ambiente");

                entity.Property(e => e.IdentificacionCodigoGeneracion).HasColumnName("Identificacion_CodigoGeneracion");

                entity.Property(e => e.IdentificacionFecEmi)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_FecEmi");

                entity.Property(e => e.IdentificacionHorEmi)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_HorEmi");

                entity.Property(e => e.IdentificacionMotivoContigencia)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_MotivoContigencia")
                    .HasComment("Factura de Exportación Electrónica");

                entity.Property(e => e.IdentificacionMotivoContin)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_MotivoContin");

                entity.Property(e => e.IdentificacionNumeroControl)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_NumeroControl");

                entity.Property(e => e.IdentificacionRecintoFiscal)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_RecintoFiscal")
                    .HasComment("Factura de Exportación Electrónica");

                entity.Property(e => e.IdentificacionRegimen)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_Regimen")
                    .HasComment("Factura de Exportación Electrónica");

                entity.Property(e => e.IdentificacionTipoContingencia)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoContingencia");

                entity.Property(e => e.IdentificacionTipoDte)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoDte");

                entity.Property(e => e.IdentificacionTipoItemExpor)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoItemExpor")
                    .HasComment("Factura de Exportación Electrónica");

                entity.Property(e => e.IdentificacionTipoModelo)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoModelo");

                entity.Property(e => e.IdentificacionTipoMoneda)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoMoneda");

                entity.Property(e => e.IdentificacionTipoOperacion)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoOperacion");

                entity.Property(e => e.IdentificacionVersion).HasColumnName("Identificacion_Version");

                entity.Property(e => e.Integridad)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("integridad");

                entity.Property(e => e.JsonAprobado).HasColumnName("json_aprobado");

                entity.Property(e => e.Pdf).HasColumnName("pdf");

                entity.Property(e => e.PdfFechaHora)
                    .HasColumnType("datetime")
                    .HasColumnName("pdf_fecha_hora");

                entity.Property(e => e.ReceptorBienTitulo)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_BienTitulo")
                    .HasComment("Nota de Remisión Electrónica");

                entity.Property(e => e.ReceptorCodActividad).HasColumnName("Receptor_CodActividad");

                entity.Property(e => e.ReceptorCodPais)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_CodPais")
                    .HasComment("Factura de Exportación Electrónica");

                entity.Property(e => e.ReceptorCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Correo");

                entity.Property(e => e.ReceptorDescActividad).HasColumnName("Receptor_DescActividad");

                entity.Property(e => e.ReceptorDireccionComplemento).HasColumnName("Receptor_Direccion_Complemento");

                entity.Property(e => e.ReceptorDireccionDepartamento).HasColumnName("Receptor_Direccion_Departamento");

                entity.Property(e => e.ReceptorDireccionMunicipio).HasColumnName("Receptor_Direccion_Municipio");

                entity.Property(e => e.ReceptorNit)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nit")
                    .HasComment("Comprobante de Crédito Fiscal Electrónica");

                entity.Property(e => e.ReceptorNombre)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nombre");

                entity.Property(e => e.ReceptorNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NombreComercial")
                    .HasComment("Comprobante de Crédito Fiscal Electrónica");

                entity.Property(e => e.ReceptorNombrePais)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NombrePais")
                    .HasComment("Factura de Exportación Electrónica");

                entity.Property(e => e.ReceptorNrc)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nrc");

                entity.Property(e => e.ReceptorNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NumDocumento");

                entity.Property(e => e.ReceptorTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Telefono");

                entity.Property(e => e.ReceptorTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_TipoDocumento");

                entity.Property(e => e.ReceptorTipoPersona)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_TipoPersona")
                    .HasComment("Factura de Exportación Electrónica");

                entity.Property(e => e.ResumenCondicionOperacion).HasColumnName("Resumen_CondicionOperacion");

                entity.Property(e => e.ResumenDescIncoterms)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescIncoterms");

                entity.Property(e => e.ResumenDescu)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Descu")
                    .HasComment("Factura de Sujeto Excluido Electrónica");

                entity.Property(e => e.ResumenDescuExenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuExenta");

                entity.Property(e => e.ResumenDescuGravada)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuGravada");

                entity.Property(e => e.ResumenDescuNoSuj)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuNoSuj");

                entity.Property(e => e.ResumenDescuento)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Descuento")
                    .HasComment("Factura de Exportación Electrónica");

                entity.Property(e => e.ResumenFlete)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Flete");

                entity.Property(e => e.ResumenIvaPerci1)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_IvaPerci1")
                    .HasComment("Comprobante de Crédito Fiscal Electrónica, Nota de Crédito Electrónica,Nota de Débito Electrónica");

                entity.Property(e => e.ResumenIvaRete1)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_IvaRete1");

                entity.Property(e => e.ResumenMontoTotalOperacion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_MontoTotalOperacion");

                entity.Property(e => e.ResumenNumPagoElectronico)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_NumPagoElectronico");

                entity.Property(e => e.ResumenObservaciones)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Observaciones");

                entity.Property(e => e.ResumenPagosCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Codigo");

                entity.Property(e => e.ResumenPagosMontoPago)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_MontoPago");

                entity.Property(e => e.ResumenPagosPeriodo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Periodo");

                entity.Property(e => e.ResumenPagosPlazo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Plazo");

                entity.Property(e => e.ResumenPagosReferencia)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Referencia");

                entity.Property(e => e.ResumenPorcentajeDescuento)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_PorcentajeDescuento");

                entity.Property(e => e.ResumenReteRenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_ReteRenta");

                entity.Property(e => e.ResumenSaldoFavor)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SaldoFavor");

                entity.Property(e => e.ResumenSeguro)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Seguro")
                    .HasComment("Factura de Exportación Electrónica");

                entity.Property(e => e.ResumenSubTotal)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SubTotal");

                entity.Property(e => e.ResumenSubTotalVentas)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SubTotalVentas");

                entity.Property(e => e.ResumenTotalCompra)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalCompra")
                    .HasComment("Factura de Sujeto Excluido Electrónica");

                entity.Property(e => e.ResumenTotalDescu)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalDescu");

                entity.Property(e => e.ResumenTotalExenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalExenta");

                entity.Property(e => e.ResumenTotalGravada)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalGravada");

                entity.Property(e => e.ResumenTotalIva)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIva");

                entity.Property(e => e.ResumenTotalIvaretenido)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIVAretenido")
                    .HasComment("Comprobante de Retención Electrónica");

                entity.Property(e => e.ResumenTotalIvaretenidoLetras)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIVAretenidoLetras")
                    .HasComment("Comprobante de Retención Electrónica");

                entity.Property(e => e.ResumenTotalLetras)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalLetras");

                entity.Property(e => e.ResumenTotalNoGravado)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalNoGravado");

                entity.Property(e => e.ResumenTotalNoSuj)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalNoSuj");

                entity.Property(e => e.ResumenTotalPagar)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalPagar");

                entity.Property(e => e.ResumenTotalSujetoRetencion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalSujetoRetencion")
                    .HasComment("Comprobante de Retención Electrónica");

                entity.Property(e => e.ResumenTributosCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Codigo");

                entity.Property(e => e.ResumenTributosDescripcion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Descripcion");

                entity.Property(e => e.ResumenTributosValor)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Valor");

                entity.Property(e => e.ResumenValorTotal)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_ValorTotal")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.Siguiente)
                    .HasColumnName("siguiente")
                    .HasComment("si el documento tiene otro delante de el");

                entity.Property(e => e.SujetoExcluidoCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_CodActividad")
                    .HasComment("Factura de Sujeto Excluido Electrónica");

                entity.Property(e => e.SujetoExcluidoCorreo)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Correo");

                entity.Property(e => e.SujetoExcluidoDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_DescActividad")
                    .HasComment("Factura de Sujeto Excluido Electrónica");

                entity.Property(e => e.SujetoExcluidoDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Complemento")
                    .HasComment("Factura de Sujeto Excluido Electrónica");

                entity.Property(e => e.SujetoExcluidoDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Departamento")
                    .HasComment("Factura de Sujeto Excluido Electrónica");

                entity.Property(e => e.SujetoExcluidoDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Municipio")
                    .HasComment("Factura de Sujeto Excluido Electrónica");

                entity.Property(e => e.SujetoExcluidoNombre)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Nombre")
                    .HasComment("Factura de Sujeto Excluido Electrónica");

                entity.Property(e => e.SujetoExcluidoNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_NumDocumento")
                    .HasComment("Factura de Sujeto Excluido Electrónica");

                entity.Property(e => e.SujetoExcluidoTelefono)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Telefono");

                entity.Property(e => e.SujetoExcluidoTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_TipoDocumento")
                    .HasComment("Factura de Sujeto Excluido Electrónica");

                entity.Property(e => e.VentaTerceroNit)
                    .IsUnicode(false)
                    .HasColumnName("VentaTercero_Nit");

                entity.Property(e => e.VentaTerceroNombre).HasColumnName("VentaTercero_Nombre");

                entity.HasOne(d => d.IdAccionNavigation)
                    .WithMany(p => p.Cabeceras)
                    .HasForeignKey(d => d.IdAccion)
                    .HasConstraintName("id_accion_cabecera");

                entity.HasOne(d => d.IdConexionNavigation)
                    .WithMany(p => p.Cabeceras)
                    .HasForeignKey(d => d.IdConexion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cabecera_id_conexion");

                entity.HasOne(d => d.IdDetalleRegistroNavigation)
                    .WithOne(p => p.Cabecera)
                    .HasForeignKey<Cabecera>(d => d.IdDetalleRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cabecera_id_detalle_registro");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Cabeceras)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cabecera_id_estado");

                entity.HasOne(d => d.IdJsonNavigation)
                    .WithMany(p => p.Cabeceras)
                    .HasForeignKey(d => d.IdJson)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cabecera_id_json");

                entity.HasOne(d => d.IdTablaNavigation)
                    .WithMany(p => p.Cabeceras)
                    .HasForeignKey(d => d.IdTabla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cabecera_id_tabla");

                entity.HasOne(d => d.CabeceraNavigation)
                    .WithMany(p => p.InverseCabeceraNavigation)
                    .HasForeignKey(d => new { d.Uuid, d.Eslavon })
                    .HasConstraintName("cabecera_eslavon");
            });

            modelBuilder.Entity<CabeceraAlert>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cabecera_alert");

                entity.Property(e => e.AceptadoMh).HasColumnName("aceptado_mh");

                entity.Property(e => e.Cadena)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("cadena");

                entity.Property(e => e.Cc).HasColumnName("cc");

                entity.Property(e => e.CeroComaCero)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Cero_Coma_Cero");

                entity.Property(e => e.ConexionEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Conexion_Email");

                entity.Property(e => e.ConexionEmailAsunto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Conexion_Email_Asunto");

                entity.Property(e => e.ConexionEmailCuerpo)
                    .IsUnicode(false)
                    .HasColumnName("Conexion_Email_Cuerpo");

                entity.Property(e => e.ConexionEmailIp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Conexion_Email_Ip");

                entity.Property(e => e.ConexionEmailPass)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Conexion_Email_Pass");

                entity.Property(e => e.ConexionEmailPuerto).HasColumnName("Conexion_Email_Puerto");

                entity.Property(e => e.ConexionEmailTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Conexion_Email_Title");

                entity.Property(e => e.CorreoPdf)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("Correo_Pdf");

                entity.Property(e => e.Creacion)
                    .HasColumnType("datetime")
                    .HasColumnName("creacion");

                entity.Property(e => e.DireccionServidor).HasColumnName("direccion_servidor");

                entity.Property(e => e.DonanteCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodActividad");

                entity.Property(e => e.DonanteCodDomiciliado)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodDomiciliado");

                entity.Property(e => e.DonanteCodPais)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodPais");

                entity.Property(e => e.DonanteCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Correo");

                entity.Property(e => e.DonanteDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donante_DescActividad");

                entity.Property(e => e.DonanteDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Complemento");

                entity.Property(e => e.DonanteDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Departamento");

                entity.Property(e => e.DonanteDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Municipio");

                entity.Property(e => e.DonanteTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Telefono");

                entity.Property(e => e.DonanteTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_TipoDocumento");

                entity.Property(e => e.DonatarioCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodActividad");

                entity.Property(e => e.DonatarioCodEstable)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodEstable");

                entity.Property(e => e.DonatarioCodEstableMh)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodEstableMH");

                entity.Property(e => e.DonatarioCodPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodPuntoVenta");

                entity.Property(e => e.DonatarioCodPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodPuntoVentaMH");

                entity.Property(e => e.DonatarioCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Correo");

                entity.Property(e => e.DonatarioDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Complemento");

                entity.Property(e => e.DonatarioDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Departamento");

                entity.Property(e => e.DonatarioDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Municipio");

                entity.Property(e => e.DonatarioNombre)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Nombre");

                entity.Property(e => e.DonatarioNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_NombreComercial");

                entity.Property(e => e.DonatarioNrc)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Nrc");

                entity.Property(e => e.DonatarioNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_NumDocumento");

                entity.Property(e => e.DonatarioTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Telefono");

                entity.Property(e => e.DonatarioTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_TipoDocumento");

                entity.Property(e => e.DonatarioTipoEstablecimiento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_TipoEstablecimiento");

                entity.Property(e => e.EmisorCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodActividad");

                entity.Property(e => e.EmisorCodEstable)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodEstable");

                entity.Property(e => e.EmisorCodEstableMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodEstableMH");

                entity.Property(e => e.EmisorCodPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodPuntoVenta");

                entity.Property(e => e.EmisorCodPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodPuntoVentaMH");

                entity.Property(e => e.EmisorCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Codigo");

                entity.Property(e => e.EmisorCodigoMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodigoMH");

                entity.Property(e => e.EmisorCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Correo");

                entity.Property(e => e.EmisorDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_DescActividad");

                entity.Property(e => e.EmisorDireccionComplemento).HasColumnName("Emisor_Direccion_Complemento");

                entity.Property(e => e.EmisorDireccionDepartamento).HasColumnName("Emisor_Direccion_Departamento");

                entity.Property(e => e.EmisorDireccionMunicipio).HasColumnName("Emisor_Direccion_Municipio");

                entity.Property(e => e.EmisorDireccionPdf).HasColumnName("Emisor_Direccion_Pdf");

                entity.Property(e => e.EmisorLogoPdf)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Logo_Pdf");

                entity.Property(e => e.EmisorNit)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nit");

                entity.Property(e => e.EmisorNitPdf)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nit_Pdf");

                entity.Property(e => e.EmisorNombre)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nombre");

                entity.Property(e => e.EmisorNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_NombreComercial");

                entity.Property(e => e.EmisorNrc)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nrc");

                entity.Property(e => e.EmisorNrcPdf)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nrc_Pdf");

                entity.Property(e => e.EmisorPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVenta");

                entity.Property(e => e.EmisorPuntoVentaContri)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVentaContri");

                entity.Property(e => e.EmisorPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVentaMH");

                entity.Property(e => e.EmisorTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Telefono");

                entity.Property(e => e.EmisorTipoEstablecimiento)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_TipoEstablecimiento");

                entity.Property(e => e.EmisorTipoEstablecimientoPdf)
                    .HasMaxLength(250)
                    .HasColumnName("Emisor_TipoEstablecimiento_Pdf");

                entity.Property(e => e.EmpresaNombrePdf)
                    .HasMaxLength(50)
                    .HasColumnName("Empresa_Nombre_Pdf");

                entity.Property(e => e.Error).HasColumnName("error");

                entity.Property(e => e.ErrorMh).HasColumnName("error_mh");

                entity.Property(e => e.Eslavon)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("eslavon");

                entity.Property(e => e.EstadoJson)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("estado_json");

                entity.Property(e => e.EtlCompleto).HasColumnName("etl_completo");

                entity.Property(e => e.ExtensionCodEmpleado)
                    .IsUnicode(false)
                    .HasColumnName("Extension_CodEmpleado");

                entity.Property(e => e.ExtensionDocuEntrega)
                    .IsUnicode(false)
                    .HasColumnName("Extension_DocuEntrega");

                entity.Property(e => e.ExtensionDocuRecibe).HasColumnName("Extension_DocuRecibe");

                entity.Property(e => e.ExtensionNombEntrega).HasColumnName("Extension_NombEntrega");

                entity.Property(e => e.ExtensionNombRecibe).HasColumnName("Extension_NombRecibe");

                entity.Property(e => e.ExtensionObservaciones).HasColumnName("Extension_Observaciones");

                entity.Property(e => e.ExtensionPlacaVehiculo).HasColumnName("Extension_PlacaVehiculo");

                entity.Property(e => e.FaceBookPdf)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("FaceBook_Pdf");

                entity.Property(e => e.FechaDte)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("fechaDte");

                entity.Property(e => e.FechaHoraCorreo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("fecha_hora_correo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdAccion).HasColumnName("id_accion");

                entity.Property(e => e.IdConexion).HasColumnName("id_conexion");

                entity.Property(e => e.IdDetalleRegistro).HasColumnName("id_detalle_registro");

                entity.Property(e => e.IdEnvioCalculado).HasColumnName("IdEnvio_Calculado");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdJson).HasColumnName("id_json");

                entity.Property(e => e.IdTabla).HasColumnName("id_tabla");

                entity.Property(e => e.IdTransaccion).HasColumnName("id_transaccion");

                entity.Property(e => e.IdentificacionAmbiente)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_Ambiente");

                entity.Property(e => e.IdentificacionCodigoGeneracion).HasColumnName("Identificacion_CodigoGeneracion");

                entity.Property(e => e.IdentificacionFecEmi)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_FecEmi");

                entity.Property(e => e.IdentificacionHorEmi)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_HorEmi");

                entity.Property(e => e.IdentificacionModeloFacturacion)
                    .HasMaxLength(250)
                    .HasColumnName("Identificacion_ModeloFacturacion");

                entity.Property(e => e.IdentificacionMotivoContigencia)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_MotivoContigencia");

                entity.Property(e => e.IdentificacionMotivoContin)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_MotivoContin");

                entity.Property(e => e.IdentificacionNumeroControl)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_NumeroControl");

                entity.Property(e => e.IdentificacionRecintoFiscal)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_RecintoFiscal");

                entity.Property(e => e.IdentificacionRegimen)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_Regimen");

                entity.Property(e => e.IdentificacionTipoContingencia)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoContingencia");

                entity.Property(e => e.IdentificacionTipoDocumento)
                    .HasMaxLength(50)
                    .HasColumnName("Identificacion_TipoDocumento");

                entity.Property(e => e.IdentificacionTipoDte)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoDte");

                entity.Property(e => e.IdentificacionTipoItemExpor)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoItemExpor");

                entity.Property(e => e.IdentificacionTipoModelo)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoModelo");

                entity.Property(e => e.IdentificacionTipoMoneda)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoMoneda");

                entity.Property(e => e.IdentificacionTipoOperacion)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoOperacion");

                entity.Property(e => e.IdentificacionTipoTransmision)
                    .HasMaxLength(250)
                    .HasColumnName("Identificacion_TipoTransmision");

                entity.Property(e => e.IdentificacionVersion).HasColumnName("Identificacion_Version");

                entity.Property(e => e.InstagramPdf)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("Instagram_Pdf");

                entity.Property(e => e.Integridad)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("integridad");

                entity.Property(e => e.JsonAprobado).HasColumnName("json_aprobado");

                entity.Property(e => e.NombreReceptorSujetoExcluido)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Receptor_SujetoExcluido");

                entity.Property(e => e.Pdf).HasColumnName("pdf");

                entity.Property(e => e.PdfFechaHora)
                    .HasColumnType("datetime")
                    .HasColumnName("pdf_fecha_hora");

                entity.Property(e => e.Qr).HasColumnName("QR");

                entity.Property(e => e.QrCorreo).HasColumnName("QR_Correo");

                entity.Property(e => e.ReceptorBienTitulo)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_BienTitulo");

                entity.Property(e => e.ReceptorCodActividad).HasColumnName("Receptor_CodActividad");

                entity.Property(e => e.ReceptorCodPais)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_CodPais");

                entity.Property(e => e.ReceptorCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Correo");

                entity.Property(e => e.ReceptorDescActividad).HasColumnName("Receptor_DescActividad");

                entity.Property(e => e.ReceptorDireccionComplemento).HasColumnName("Receptor_Direccion_Complemento");

                entity.Property(e => e.ReceptorDireccionDepartamento).HasColumnName("Receptor_Direccion_Departamento");

                entity.Property(e => e.ReceptorDireccionMunicipio).HasColumnName("Receptor_Direccion_Municipio");

                entity.Property(e => e.ReceptorDireccionPdf).HasColumnName("Receptor_Direccion_Pdf");

                entity.Property(e => e.ReceptorNit)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nit");

                entity.Property(e => e.ReceptorNombre)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nombre");

                entity.Property(e => e.ReceptorNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NombreComercial");

                entity.Property(e => e.ReceptorNombrePais)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NombrePais");

                entity.Property(e => e.ReceptorNrc)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nrc");

                entity.Property(e => e.ReceptorNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NumDocumento");

                entity.Property(e => e.ReceptorTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Telefono");

                entity.Property(e => e.ReceptorTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_TipoDocumento");

                entity.Property(e => e.ReceptorTipoDocumentoPdf)
                    .HasMaxLength(250)
                    .HasColumnName("Receptor_TipoDocumento_Pdf");

                entity.Property(e => e.ReceptorTipoPersona)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_TipoPersona");

                entity.Property(e => e.ResumenCondicionOperacion).HasColumnName("Resumen_CondicionOperacion");

                entity.Property(e => e.ResumenCondicionOperacionPdf)
                    .HasMaxLength(250)
                    .HasColumnName("Resumen_CondicionOperacion_Pdf");

                entity.Property(e => e.ResumenDescIncoterms)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescIncoterms");

                entity.Property(e => e.ResumenDescu)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Descu");

                entity.Property(e => e.ResumenDescuExenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuExenta");

                entity.Property(e => e.ResumenDescuGravada)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuGravada");

                entity.Property(e => e.ResumenDescuNoSuj)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuNoSuj");

                entity.Property(e => e.ResumenDescuento)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Descuento");

                entity.Property(e => e.ResumenFlete)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Flete");

                entity.Property(e => e.ResumenIvaPerci1)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_IvaPerci1");

                entity.Property(e => e.ResumenIvaRete1)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_IvaRete1");

                entity.Property(e => e.ResumenMontoTotalOperacion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_MontoTotalOperacion");

                entity.Property(e => e.ResumenNumPagoElectronico)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_NumPagoElectronico");

                entity.Property(e => e.ResumenObservaciones)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Observaciones");

                entity.Property(e => e.ResumenPagosCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Codigo");

                entity.Property(e => e.ResumenPagosMontoPago)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_MontoPago");

                entity.Property(e => e.ResumenPagosPeriodo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Periodo");

                entity.Property(e => e.ResumenPagosPlazo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Plazo");

                entity.Property(e => e.ResumenPagosReferencia)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Referencia");

                entity.Property(e => e.ResumenPorcentajeDescuento)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_PorcentajeDescuento");

                entity.Property(e => e.ResumenReteRenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_ReteRenta");

                entity.Property(e => e.ResumenSaldoFavor)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SaldoFavor");

                entity.Property(e => e.ResumenSeguro)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Seguro");

                entity.Property(e => e.ResumenSubTotal)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SubTotal");

                entity.Property(e => e.ResumenSubTotalVentas)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SubTotalVentas");

                entity.Property(e => e.ResumenTotalCompra)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalCompra");

                entity.Property(e => e.ResumenTotalDescu)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalDescu");

                entity.Property(e => e.ResumenTotalExenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalExenta");

                entity.Property(e => e.ResumenTotalGravada)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalGravada");

                entity.Property(e => e.ResumenTotalIva)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIva");

                entity.Property(e => e.ResumenTotalIvaretenido)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIVAretenido");

                entity.Property(e => e.ResumenTotalIvaretenidoLetras)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIVAretenidoLetras");

                entity.Property(e => e.ResumenTotalLetras)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalLetras");

                entity.Property(e => e.ResumenTotalNoGravado)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalNoGravado");

                entity.Property(e => e.ResumenTotalNoSuj)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalNoSuj");

                entity.Property(e => e.ResumenTotalPagar)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalPagar");

                entity.Property(e => e.ResumenTotalSujetoRetencion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalSujetoRetencion");

                entity.Property(e => e.ResumenTributosCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Codigo");

                entity.Property(e => e.ResumenTributosDescripcion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Descripcion");

                entity.Property(e => e.ResumenTributosValor)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Valor");

                entity.Property(e => e.ResumenValorTotal)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_ValorTotal");

                entity.Property(e => e.Siguiente).HasColumnName("siguiente");

                entity.Property(e => e.SujetoExcludioTipoDocumentoPdf)
                    .HasMaxLength(250)
                    .HasColumnName("SujetoExcludio_TipoDocumento_Pdf");

                entity.Property(e => e.SujetoExcluidoCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_CodActividad");

                entity.Property(e => e.SujetoExcluidoCorreo)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Correo");

                entity.Property(e => e.SujetoExcluidoDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_DescActividad");

                entity.Property(e => e.SujetoExcluidoDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Complemento");

                entity.Property(e => e.SujetoExcluidoDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Departamento");

                entity.Property(e => e.SujetoExcluidoDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Municipio");

                entity.Property(e => e.SujetoExcluidoDireccionPdf).HasColumnName("SujetoExcluido_Direccion_Pdf");

                entity.Property(e => e.SujetoExcluidoNombre)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Nombre");

                entity.Property(e => e.SujetoExcluidoNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_NumDocumento");

                entity.Property(e => e.SujetoExcluidoTelefono)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Telefono");

                entity.Property(e => e.SujetoExcluidoTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_TipoDocumento");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("uuid");

                entity.Property(e => e.VaCio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Va_Cio");

                entity.Property(e => e.VentaTerceroNit)
                    .IsUnicode(false)
                    .HasColumnName("VentaTercero_Nit");

                entity.Property(e => e.VentaTerceroNombre).HasColumnName("VentaTercero_Nombre");

                entity.Property(e => e.WhatsAppPdf)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("WhatsApp_Pdf");
            });

            modelBuilder.Entity<CabeceraCore>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cabecera_core");

                entity.Property(e => e.AceptadoMh).HasColumnName("aceptado_mh");

                entity.Property(e => e.Cadena)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("cadena");

                entity.Property(e => e.Cc).HasColumnName("cc");

                entity.Property(e => e.Creacion)
                    .HasColumnType("datetime")
                    .HasColumnName("creacion");

                entity.Property(e => e.DonanteCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodActividad");

                entity.Property(e => e.DonanteCodDomiciliado)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodDomiciliado");

                entity.Property(e => e.DonanteCodPais)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodPais");

                entity.Property(e => e.DonanteCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Correo");

                entity.Property(e => e.DonanteDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donante_DescActividad");

                entity.Property(e => e.DonanteDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Complemento");

                entity.Property(e => e.DonanteDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Departamento");

                entity.Property(e => e.DonanteDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Municipio");

                entity.Property(e => e.DonanteTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Telefono");

                entity.Property(e => e.DonanteTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_TipoDocumento");

                entity.Property(e => e.DonatarioCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodActividad");

                entity.Property(e => e.DonatarioCodEstable)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodEstable");

                entity.Property(e => e.DonatarioCodEstableMh)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodEstableMH");

                entity.Property(e => e.DonatarioCodPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodPuntoVenta");

                entity.Property(e => e.DonatarioCodPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodPuntoVentaMH");

                entity.Property(e => e.DonatarioCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Correo");

                entity.Property(e => e.DonatarioDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Complemento");

                entity.Property(e => e.DonatarioDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Departamento");

                entity.Property(e => e.DonatarioDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Municipio");

                entity.Property(e => e.DonatarioNombre)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Nombre");

                entity.Property(e => e.DonatarioNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_NombreComercial");

                entity.Property(e => e.DonatarioNrc)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Nrc");

                entity.Property(e => e.DonatarioNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_NumDocumento");

                entity.Property(e => e.DonatarioTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Telefono");

                entity.Property(e => e.DonatarioTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_TipoDocumento");

                entity.Property(e => e.DonatarioTipoEstablecimiento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_TipoEstablecimiento");

                entity.Property(e => e.EmisorCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodActividad");

                entity.Property(e => e.EmisorCodEstable)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodEstable");

                entity.Property(e => e.EmisorCodEstableMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodEstableMH");

                entity.Property(e => e.EmisorCodPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodPuntoVenta");

                entity.Property(e => e.EmisorCodPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodPuntoVentaMH");

                entity.Property(e => e.EmisorCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Codigo");

                entity.Property(e => e.EmisorCodigoMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodigoMH");

                entity.Property(e => e.EmisorCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Correo");

                entity.Property(e => e.EmisorDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_DescActividad");

                entity.Property(e => e.EmisorDireccionComplemento).HasColumnName("Emisor_Direccion_Complemento");

                entity.Property(e => e.EmisorDireccionDepartamento).HasColumnName("Emisor_Direccion_Departamento");

                entity.Property(e => e.EmisorDireccionMunicipio).HasColumnName("Emisor_Direccion_Municipio");

                entity.Property(e => e.EmisorNit)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nit");

                entity.Property(e => e.EmisorNombre)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nombre");

                entity.Property(e => e.EmisorNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_NombreComercial");

                entity.Property(e => e.EmisorNrc)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nrc");

                entity.Property(e => e.EmisorPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVenta");

                entity.Property(e => e.EmisorPuntoVentaContri)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVentaContri");

                entity.Property(e => e.EmisorPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVentaMH");

                entity.Property(e => e.EmisorTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Telefono");

                entity.Property(e => e.EmisorTipoEstablecimiento)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_TipoEstablecimiento");

                entity.Property(e => e.Error).HasColumnName("error");

                entity.Property(e => e.ErrorMh).HasColumnName("error_mh");

                entity.Property(e => e.Eslavon)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("eslavon");

                entity.Property(e => e.EtlCompleto).HasColumnName("etl_completo");

                entity.Property(e => e.ExtensionCodEmpleado)
                    .IsUnicode(false)
                    .HasColumnName("Extension_CodEmpleado");

                entity.Property(e => e.ExtensionDocuEntrega)
                    .IsUnicode(false)
                    .HasColumnName("Extension_DocuEntrega");

                entity.Property(e => e.ExtensionDocuRecibe).HasColumnName("Extension_DocuRecibe");

                entity.Property(e => e.ExtensionNombEntrega).HasColumnName("Extension_NombEntrega");

                entity.Property(e => e.ExtensionNombRecibe).HasColumnName("Extension_NombRecibe");

                entity.Property(e => e.ExtensionObservaciones).HasColumnName("Extension_Observaciones");

                entity.Property(e => e.ExtensionPlacaVehiculo).HasColumnName("Extension_PlacaVehiculo");

                entity.Property(e => e.FechaDte)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("fechaDte");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IdAccion).HasColumnName("id_accion");

                entity.Property(e => e.IdConexion).HasColumnName("id_conexion");

                entity.Property(e => e.IdDetalleRegistro).HasColumnName("id_detalle_registro");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdJson).HasColumnName("id_json");

                entity.Property(e => e.IdTabla).HasColumnName("id_tabla");

                entity.Property(e => e.IdTransaccion).HasColumnName("id_transaccion");

                entity.Property(e => e.IdentificacionAmbiente)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_Ambiente");

                entity.Property(e => e.IdentificacionCodigoGeneracion).HasColumnName("Identificacion_CodigoGeneracion");

                entity.Property(e => e.IdentificacionFecEmi)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_FecEmi");

                entity.Property(e => e.IdentificacionHorEmi)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_HorEmi");

                entity.Property(e => e.IdentificacionMotivoContigencia)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_MotivoContigencia");

                entity.Property(e => e.IdentificacionMotivoContin)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_MotivoContin");

                entity.Property(e => e.IdentificacionNumeroControl)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_NumeroControl");

                entity.Property(e => e.IdentificacionRecintoFiscal)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_RecintoFiscal");

                entity.Property(e => e.IdentificacionRegimen)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_Regimen");

                entity.Property(e => e.IdentificacionTipoContingencia)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoContingencia");

                entity.Property(e => e.IdentificacionTipoDte)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoDte");

                entity.Property(e => e.IdentificacionTipoItemExpor)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoItemExpor");

                entity.Property(e => e.IdentificacionTipoModelo)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoModelo");

                entity.Property(e => e.IdentificacionTipoMoneda)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoMoneda");

                entity.Property(e => e.IdentificacionTipoOperacion)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoOperacion");

                entity.Property(e => e.IdentificacionVersion).HasColumnName("Identificacion_Version");

                entity.Property(e => e.Integridad)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("integridad");

                entity.Property(e => e.JsonAprobado).HasColumnName("json_aprobado");

                entity.Property(e => e.Pdf).HasColumnName("pdf");

                entity.Property(e => e.PdfFechaHora)
                    .HasColumnType("datetime")
                    .HasColumnName("pdf_fecha_hora");

                entity.Property(e => e.ReceptorBienTitulo)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_BienTitulo");

                entity.Property(e => e.ReceptorCodActividad).HasColumnName("Receptor_CodActividad");

                entity.Property(e => e.ReceptorCodPais)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_CodPais");

                entity.Property(e => e.ReceptorCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Correo");

                entity.Property(e => e.ReceptorDescActividad).HasColumnName("Receptor_DescActividad");

                entity.Property(e => e.ReceptorDireccionComplemento).HasColumnName("Receptor_Direccion_Complemento");

                entity.Property(e => e.ReceptorDireccionDepartamento).HasColumnName("Receptor_Direccion_Departamento");

                entity.Property(e => e.ReceptorDireccionMunicipio).HasColumnName("Receptor_Direccion_Municipio");

                entity.Property(e => e.ReceptorNit)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nit");

                entity.Property(e => e.ReceptorNombre)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nombre");

                entity.Property(e => e.ReceptorNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NombreComercial");

                entity.Property(e => e.ReceptorNombrePais)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NombrePais");

                entity.Property(e => e.ReceptorNrc)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nrc");

                entity.Property(e => e.ReceptorNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NumDocumento");

                entity.Property(e => e.ReceptorTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Telefono");

                entity.Property(e => e.ReceptorTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_TipoDocumento");

                entity.Property(e => e.ReceptorTipoPersona)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_TipoPersona");

                entity.Property(e => e.ResumenCondicionOperacion).HasColumnName("Resumen_CondicionOperacion");

                entity.Property(e => e.ResumenDescIncoterms)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescIncoterms");

                entity.Property(e => e.ResumenDescu)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Descu");

                entity.Property(e => e.ResumenDescuExenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuExenta");

                entity.Property(e => e.ResumenDescuGravada)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuGravada");

                entity.Property(e => e.ResumenDescuNoSuj)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuNoSuj");

                entity.Property(e => e.ResumenDescuento)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Descuento");

                entity.Property(e => e.ResumenFlete)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Flete");

                entity.Property(e => e.ResumenIvaPerci1)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_IvaPerci1");

                entity.Property(e => e.ResumenIvaRete1)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_IvaRete1");

                entity.Property(e => e.ResumenMontoTotalOperacion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_MontoTotalOperacion");

                entity.Property(e => e.ResumenNumPagoElectronico)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_NumPagoElectronico");

                entity.Property(e => e.ResumenObservaciones)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Observaciones");

                entity.Property(e => e.ResumenPagosCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Codigo");

                entity.Property(e => e.ResumenPagosMontoPago)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_MontoPago");

                entity.Property(e => e.ResumenPagosPeriodo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Periodo");

                entity.Property(e => e.ResumenPagosPlazo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Plazo");

                entity.Property(e => e.ResumenPagosReferencia)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Referencia");

                entity.Property(e => e.ResumenPorcentajeDescuento)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_PorcentajeDescuento");

                entity.Property(e => e.ResumenReteRenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_ReteRenta");

                entity.Property(e => e.ResumenSaldoFavor)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SaldoFavor");

                entity.Property(e => e.ResumenSeguro)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Seguro");

                entity.Property(e => e.ResumenSubTotal)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SubTotal");

                entity.Property(e => e.ResumenSubTotalVentas)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SubTotalVentas");

                entity.Property(e => e.ResumenTotalCompra)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalCompra");

                entity.Property(e => e.ResumenTotalDescu)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalDescu");

                entity.Property(e => e.ResumenTotalExenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalExenta");

                entity.Property(e => e.ResumenTotalGravada)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalGravada");

                entity.Property(e => e.ResumenTotalIva)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIva");

                entity.Property(e => e.ResumenTotalIvaretenido)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIVAretenido");

                entity.Property(e => e.ResumenTotalIvaretenidoLetras)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIVAretenidoLetras");

                entity.Property(e => e.ResumenTotalLetras)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalLetras");

                entity.Property(e => e.ResumenTotalNoGravado)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalNoGravado");

                entity.Property(e => e.ResumenTotalNoSuj)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalNoSuj");

                entity.Property(e => e.ResumenTotalPagar)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalPagar");

                entity.Property(e => e.ResumenTotalSujetoRetencion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalSujetoRetencion");

                entity.Property(e => e.ResumenTributosCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Codigo");

                entity.Property(e => e.ResumenTributosDescripcion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Descripcion");

                entity.Property(e => e.ResumenTributosValor)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Valor");

                entity.Property(e => e.ResumenValorTotal)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_ValorTotal");

                entity.Property(e => e.Siguiente).HasColumnName("siguiente");

                entity.Property(e => e.SujetoExcluidoCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_CodActividad");

                entity.Property(e => e.SujetoExcluidoCorreo)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Correo");

                entity.Property(e => e.SujetoExcluidoDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_DescActividad");

                entity.Property(e => e.SujetoExcluidoDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Complemento");

                entity.Property(e => e.SujetoExcluidoDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Departamento");

                entity.Property(e => e.SujetoExcluidoDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Municipio");

                entity.Property(e => e.SujetoExcluidoNombre)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Nombre");

                entity.Property(e => e.SujetoExcluidoNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_NumDocumento");

                entity.Property(e => e.SujetoExcluidoTelefono)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Telefono");

                entity.Property(e => e.SujetoExcluidoTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_TipoDocumento");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("uuid");

                entity.Property(e => e.VentaTerceroNit)
                    .IsUnicode(false)
                    .HasColumnName("VentaTercero_Nit");

                entity.Property(e => e.VentaTerceroNombre).HasColumnName("VentaTercero_Nombre");
            });

            modelBuilder.Entity<CabeceraDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cabecera_detalle");

                entity.Property(e => e.Llave)
                    .HasMaxLength(128)
                    .HasColumnName("llave");
            });

            modelBuilder.Entity<CabeceraIncidencium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cabecera_incidencia");

                entity.Property(e => e.AceptadoMh).HasColumnName("aceptado_mh");

                entity.Property(e => e.Cadena)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("cadena");

                entity.Property(e => e.Cc).HasColumnName("cc");

                entity.Property(e => e.Creacion)
                    .HasColumnType("datetime")
                    .HasColumnName("creacion");

                entity.Property(e => e.DonanteCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodActividad");

                entity.Property(e => e.DonanteCodDomiciliado)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodDomiciliado");

                entity.Property(e => e.DonanteCodPais)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodPais");

                entity.Property(e => e.DonanteCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Correo");

                entity.Property(e => e.DonanteDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donante_DescActividad");

                entity.Property(e => e.DonanteDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Complemento");

                entity.Property(e => e.DonanteDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Departamento");

                entity.Property(e => e.DonanteDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Municipio");

                entity.Property(e => e.DonanteTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Telefono");

                entity.Property(e => e.DonanteTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_TipoDocumento");

                entity.Property(e => e.DonatarioCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodActividad");

                entity.Property(e => e.DonatarioCodEstable)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodEstable");

                entity.Property(e => e.DonatarioCodEstableMh)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodEstableMH");

                entity.Property(e => e.DonatarioCodPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodPuntoVenta");

                entity.Property(e => e.DonatarioCodPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodPuntoVentaMH");

                entity.Property(e => e.DonatarioCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Correo");

                entity.Property(e => e.DonatarioDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Complemento");

                entity.Property(e => e.DonatarioDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Departamento");

                entity.Property(e => e.DonatarioDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Municipio");

                entity.Property(e => e.DonatarioNombre)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Nombre");

                entity.Property(e => e.DonatarioNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_NombreComercial");

                entity.Property(e => e.DonatarioNrc)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Nrc");

                entity.Property(e => e.DonatarioNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_NumDocumento");

                entity.Property(e => e.DonatarioTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Telefono");

                entity.Property(e => e.DonatarioTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_TipoDocumento");

                entity.Property(e => e.DonatarioTipoEstablecimiento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_TipoEstablecimiento");

                entity.Property(e => e.EmisorCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodActividad");

                entity.Property(e => e.EmisorCodEstable)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodEstable");

                entity.Property(e => e.EmisorCodEstableMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodEstableMH");

                entity.Property(e => e.EmisorCodPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodPuntoVenta");

                entity.Property(e => e.EmisorCodPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodPuntoVentaMH");

                entity.Property(e => e.EmisorCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Codigo");

                entity.Property(e => e.EmisorCodigoMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodigoMH");

                entity.Property(e => e.EmisorCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Correo");

                entity.Property(e => e.EmisorDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_DescActividad");

                entity.Property(e => e.EmisorDireccionComplemento).HasColumnName("Emisor_Direccion_Complemento");

                entity.Property(e => e.EmisorDireccionDepartamento).HasColumnName("Emisor_Direccion_Departamento");

                entity.Property(e => e.EmisorDireccionMunicipio).HasColumnName("Emisor_Direccion_Municipio");

                entity.Property(e => e.EmisorNit)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nit");

                entity.Property(e => e.EmisorNombre)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nombre");

                entity.Property(e => e.EmisorNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_NombreComercial");

                entity.Property(e => e.EmisorNrc)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nrc");

                entity.Property(e => e.EmisorPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVenta");

                entity.Property(e => e.EmisorPuntoVentaContri)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVentaContri");

                entity.Property(e => e.EmisorPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVentaMH");

                entity.Property(e => e.EmisorTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Telefono");

                entity.Property(e => e.EmisorTipoEstablecimiento)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_TipoEstablecimiento");

                entity.Property(e => e.Error).HasColumnName("error");

                entity.Property(e => e.ErrorMh).HasColumnName("error_mh");

                entity.Property(e => e.Eslavon)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("eslavon");

                entity.Property(e => e.EtlCompleto).HasColumnName("etl_completo");

                entity.Property(e => e.ExtensionCodEmpleado)
                    .IsUnicode(false)
                    .HasColumnName("Extension_CodEmpleado");

                entity.Property(e => e.ExtensionDocuEntrega)
                    .IsUnicode(false)
                    .HasColumnName("Extension_DocuEntrega");

                entity.Property(e => e.ExtensionDocuRecibe).HasColumnName("Extension_DocuRecibe");

                entity.Property(e => e.ExtensionNombEntrega).HasColumnName("Extension_NombEntrega");

                entity.Property(e => e.ExtensionNombRecibe).HasColumnName("Extension_NombRecibe");

                entity.Property(e => e.ExtensionObservaciones).HasColumnName("Extension_Observaciones");

                entity.Property(e => e.ExtensionPlacaVehiculo).HasColumnName("Extension_PlacaVehiculo");

                entity.Property(e => e.FechaDte)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("fechaDte");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IdAccion).HasColumnName("id_accion");

                entity.Property(e => e.IdConexion).HasColumnName("id_conexion");

                entity.Property(e => e.IdDetalleRegistro).HasColumnName("id_detalle_registro");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdJson).HasColumnName("id_json");

                entity.Property(e => e.IdTabla).HasColumnName("id_tabla");

                entity.Property(e => e.IdTransaccion).HasColumnName("id_transaccion");

                entity.Property(e => e.IdentificacionAmbiente)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_Ambiente");

                entity.Property(e => e.IdentificacionCodigoGeneracion).HasColumnName("Identificacion_CodigoGeneracion");

                entity.Property(e => e.IdentificacionFecEmi)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_FecEmi");

                entity.Property(e => e.IdentificacionHorEmi)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_HorEmi");

                entity.Property(e => e.IdentificacionMotivoContigencia)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_MotivoContigencia");

                entity.Property(e => e.IdentificacionMotivoContin)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_MotivoContin");

                entity.Property(e => e.IdentificacionNumeroControl)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_NumeroControl");

                entity.Property(e => e.IdentificacionRecintoFiscal)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_RecintoFiscal");

                entity.Property(e => e.IdentificacionRegimen)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_Regimen");

                entity.Property(e => e.IdentificacionTipoContingencia)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoContingencia");

                entity.Property(e => e.IdentificacionTipoDte)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoDte");

                entity.Property(e => e.IdentificacionTipoItemExpor)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoItemExpor");

                entity.Property(e => e.IdentificacionTipoModelo)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoModelo");

                entity.Property(e => e.IdentificacionTipoMoneda)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoMoneda");

                entity.Property(e => e.IdentificacionTipoOperacion)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoOperacion");

                entity.Property(e => e.IdentificacionVersion).HasColumnName("Identificacion_Version");

                entity.Property(e => e.Integridad)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("integridad");

                entity.Property(e => e.JsonAprobado).HasColumnName("json_aprobado");

                entity.Property(e => e.Pdf).HasColumnName("pdf");

                entity.Property(e => e.PdfFechaHora)
                    .HasColumnType("datetime")
                    .HasColumnName("pdf_fecha_hora");

                entity.Property(e => e.ReceptorBienTitulo)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_BienTitulo");

                entity.Property(e => e.ReceptorCodActividad).HasColumnName("Receptor_CodActividad");

                entity.Property(e => e.ReceptorCodPais)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_CodPais");

                entity.Property(e => e.ReceptorCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Correo");

                entity.Property(e => e.ReceptorDescActividad).HasColumnName("Receptor_DescActividad");

                entity.Property(e => e.ReceptorDireccionComplemento).HasColumnName("Receptor_Direccion_Complemento");

                entity.Property(e => e.ReceptorDireccionDepartamento).HasColumnName("Receptor_Direccion_Departamento");

                entity.Property(e => e.ReceptorDireccionMunicipio).HasColumnName("Receptor_Direccion_Municipio");

                entity.Property(e => e.ReceptorNit)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nit");

                entity.Property(e => e.ReceptorNombre)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nombre");

                entity.Property(e => e.ReceptorNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NombreComercial");

                entity.Property(e => e.ReceptorNombrePais)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NombrePais");

                entity.Property(e => e.ReceptorNrc)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nrc");

                entity.Property(e => e.ReceptorNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NumDocumento");

                entity.Property(e => e.ReceptorTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Telefono");

                entity.Property(e => e.ReceptorTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_TipoDocumento");

                entity.Property(e => e.ReceptorTipoPersona)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_TipoPersona");

                entity.Property(e => e.ResumenCondicionOperacion).HasColumnName("Resumen_CondicionOperacion");

                entity.Property(e => e.ResumenDescIncoterms)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescIncoterms");

                entity.Property(e => e.ResumenDescu)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Descu");

                entity.Property(e => e.ResumenDescuExenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuExenta");

                entity.Property(e => e.ResumenDescuGravada)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuGravada");

                entity.Property(e => e.ResumenDescuNoSuj)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuNoSuj");

                entity.Property(e => e.ResumenDescuento)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Descuento");

                entity.Property(e => e.ResumenFlete)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Flete");

                entity.Property(e => e.ResumenIvaPerci1)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_IvaPerci1");

                entity.Property(e => e.ResumenIvaRete1)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_IvaRete1");

                entity.Property(e => e.ResumenMontoTotalOperacion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_MontoTotalOperacion");

                entity.Property(e => e.ResumenNumPagoElectronico)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_NumPagoElectronico");

                entity.Property(e => e.ResumenObservaciones)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Observaciones");

                entity.Property(e => e.ResumenPagosCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Codigo");

                entity.Property(e => e.ResumenPagosMontoPago)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_MontoPago");

                entity.Property(e => e.ResumenPagosPeriodo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Periodo");

                entity.Property(e => e.ResumenPagosPlazo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Plazo");

                entity.Property(e => e.ResumenPagosReferencia)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Referencia");

                entity.Property(e => e.ResumenPorcentajeDescuento)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_PorcentajeDescuento");

                entity.Property(e => e.ResumenReteRenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_ReteRenta");

                entity.Property(e => e.ResumenSaldoFavor)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SaldoFavor");

                entity.Property(e => e.ResumenSeguro)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Seguro");

                entity.Property(e => e.ResumenSubTotal)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SubTotal");

                entity.Property(e => e.ResumenSubTotalVentas)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SubTotalVentas");

                entity.Property(e => e.ResumenTotalCompra)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalCompra");

                entity.Property(e => e.ResumenTotalDescu)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalDescu");

                entity.Property(e => e.ResumenTotalExenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalExenta");

                entity.Property(e => e.ResumenTotalGravada)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalGravada");

                entity.Property(e => e.ResumenTotalIva)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIva");

                entity.Property(e => e.ResumenTotalIvaretenido)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIVAretenido");

                entity.Property(e => e.ResumenTotalIvaretenidoLetras)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIVAretenidoLetras");

                entity.Property(e => e.ResumenTotalLetras)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalLetras");

                entity.Property(e => e.ResumenTotalNoGravado)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalNoGravado");

                entity.Property(e => e.ResumenTotalNoSuj)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalNoSuj");

                entity.Property(e => e.ResumenTotalPagar)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalPagar");

                entity.Property(e => e.ResumenTotalSujetoRetencion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalSujetoRetencion");

                entity.Property(e => e.ResumenTributosCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Codigo");

                entity.Property(e => e.ResumenTributosDescripcion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Descripcion");

                entity.Property(e => e.ResumenTributosValor)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Valor");

                entity.Property(e => e.ResumenValorTotal)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_ValorTotal");

                entity.Property(e => e.Siguiente).HasColumnName("siguiente");

                entity.Property(e => e.SujetoExcluidoCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_CodActividad");

                entity.Property(e => e.SujetoExcluidoCorreo)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Correo");

                entity.Property(e => e.SujetoExcluidoDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_DescActividad");

                entity.Property(e => e.SujetoExcluidoDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Complemento");

                entity.Property(e => e.SujetoExcluidoDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Departamento");

                entity.Property(e => e.SujetoExcluidoDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Municipio");

                entity.Property(e => e.SujetoExcluidoNombre)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Nombre");

                entity.Property(e => e.SujetoExcluidoNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_NumDocumento");

                entity.Property(e => e.SujetoExcluidoTelefono)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Telefono");

                entity.Property(e => e.SujetoExcluidoTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_TipoDocumento");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("uuid");

                entity.Property(e => e.VentaTerceroNit)
                    .IsUnicode(false)
                    .HasColumnName("VentaTercero_Nit");

                entity.Property(e => e.VentaTerceroNombre).HasColumnName("VentaTercero_Nombre");
            });

            modelBuilder.Entity<CabeceraJson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cabecera_json");

                entity.Property(e => e.AceptadoMh).HasColumnName("aceptado_mh");

                entity.Property(e => e.Cadena)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("cadena");

                entity.Property(e => e.Cc).HasColumnName("cc");

                entity.Property(e => e.Creacion)
                    .HasColumnType("datetime")
                    .HasColumnName("creacion");

                entity.Property(e => e.DireccionServidor).HasColumnName("direccion_servidor");

                entity.Property(e => e.DonanteCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodActividad");

                entity.Property(e => e.DonanteCodDomiciliado)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodDomiciliado");

                entity.Property(e => e.DonanteCodPais)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodPais");

                entity.Property(e => e.DonanteCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Correo");

                entity.Property(e => e.DonanteDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donante_DescActividad");

                entity.Property(e => e.DonanteDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Complemento");

                entity.Property(e => e.DonanteDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Departamento");

                entity.Property(e => e.DonanteDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Municipio");

                entity.Property(e => e.DonanteTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Telefono");

                entity.Property(e => e.DonanteTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_TipoDocumento");

                entity.Property(e => e.DonatarioCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodActividad");

                entity.Property(e => e.DonatarioCodEstable)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodEstable");

                entity.Property(e => e.DonatarioCodEstableMh)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodEstableMH");

                entity.Property(e => e.DonatarioCodPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodPuntoVenta");

                entity.Property(e => e.DonatarioCodPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodPuntoVentaMH");

                entity.Property(e => e.DonatarioCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Correo");

                entity.Property(e => e.DonatarioDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Complemento");

                entity.Property(e => e.DonatarioDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Departamento");

                entity.Property(e => e.DonatarioDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Municipio");

                entity.Property(e => e.DonatarioNombre)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Nombre");

                entity.Property(e => e.DonatarioNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_NombreComercial");

                entity.Property(e => e.DonatarioNrc)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Nrc");

                entity.Property(e => e.DonatarioNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_NumDocumento");

                entity.Property(e => e.DonatarioTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Telefono");

                entity.Property(e => e.DonatarioTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_TipoDocumento");

                entity.Property(e => e.DonatarioTipoEstablecimiento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_TipoEstablecimiento");

                entity.Property(e => e.EmisorCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodActividad");

                entity.Property(e => e.EmisorCodEstable)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodEstable");

                entity.Property(e => e.EmisorCodEstableMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodEstableMH");

                entity.Property(e => e.EmisorCodPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodPuntoVenta");

                entity.Property(e => e.EmisorCodPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodPuntoVentaMH");

                entity.Property(e => e.EmisorCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Codigo");

                entity.Property(e => e.EmisorCodigoMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodigoMH");

                entity.Property(e => e.EmisorCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Correo");

                entity.Property(e => e.EmisorDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_DescActividad");

                entity.Property(e => e.EmisorDireccionComplemento).HasColumnName("Emisor_Direccion_Complemento");

                entity.Property(e => e.EmisorDireccionDepartamento).HasColumnName("Emisor_Direccion_Departamento");

                entity.Property(e => e.EmisorDireccionMunicipio).HasColumnName("Emisor_Direccion_Municipio");

                entity.Property(e => e.EmisorNit)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nit");

                entity.Property(e => e.EmisorNombre)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nombre");

                entity.Property(e => e.EmisorNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_NombreComercial");

                entity.Property(e => e.EmisorNrc)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nrc");

                entity.Property(e => e.EmisorPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVenta");

                entity.Property(e => e.EmisorPuntoVentaContri)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVentaContri");

                entity.Property(e => e.EmisorPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVentaMH");

                entity.Property(e => e.EmisorTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Telefono");

                entity.Property(e => e.EmisorTipoEstablecimiento)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_TipoEstablecimiento");

                entity.Property(e => e.Error).HasColumnName("error");

                entity.Property(e => e.ErrorMh).HasColumnName("error_mh");

                entity.Property(e => e.Eslavon)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("eslavon");

                entity.Property(e => e.EstadoJson)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("estado_json");

                entity.Property(e => e.EtlCompleto).HasColumnName("etl_completo");

                entity.Property(e => e.ExtensionCodEmpleado)
                    .IsUnicode(false)
                    .HasColumnName("Extension_CodEmpleado");

                entity.Property(e => e.ExtensionDocuEntrega)
                    .IsUnicode(false)
                    .HasColumnName("Extension_DocuEntrega");

                entity.Property(e => e.ExtensionDocuRecibe).HasColumnName("Extension_DocuRecibe");

                entity.Property(e => e.ExtensionNombEntrega).HasColumnName("Extension_NombEntrega");

                entity.Property(e => e.ExtensionNombRecibe).HasColumnName("Extension_NombRecibe");

                entity.Property(e => e.ExtensionObservaciones).HasColumnName("Extension_Observaciones");

                entity.Property(e => e.ExtensionPlacaVehiculo).HasColumnName("Extension_PlacaVehiculo");

                entity.Property(e => e.FechaDte)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("fechaDte");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IdAccion).HasColumnName("id_accion");

                entity.Property(e => e.IdConexion).HasColumnName("id_conexion");

                entity.Property(e => e.IdDetalleRegistro).HasColumnName("id_detalle_registro");

                entity.Property(e => e.IdEnvioCalculado).HasColumnName("IdEnvio_Calculado");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdJson).HasColumnName("id_json");

                entity.Property(e => e.IdTabla).HasColumnName("id_tabla");

                entity.Property(e => e.IdTransaccion).HasColumnName("id_transaccion");

                entity.Property(e => e.IdentificacionAmbiente)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_Ambiente");

                entity.Property(e => e.IdentificacionCodigoGeneracion).HasColumnName("Identificacion_CodigoGeneracion");

                entity.Property(e => e.IdentificacionFecEmi)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_FecEmi");

                entity.Property(e => e.IdentificacionHorEmi)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_HorEmi");

                entity.Property(e => e.IdentificacionMotivoContigencia)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_MotivoContigencia");

                entity.Property(e => e.IdentificacionMotivoContin)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_MotivoContin");

                entity.Property(e => e.IdentificacionNumeroControl)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_NumeroControl");

                entity.Property(e => e.IdentificacionRecintoFiscal)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_RecintoFiscal");

                entity.Property(e => e.IdentificacionRegimen)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_Regimen");

                entity.Property(e => e.IdentificacionTipoContingencia)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoContingencia");

                entity.Property(e => e.IdentificacionTipoDte)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoDte");

                entity.Property(e => e.IdentificacionTipoItemExpor)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoItemExpor");

                entity.Property(e => e.IdentificacionTipoModelo)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoModelo");

                entity.Property(e => e.IdentificacionTipoMoneda)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoMoneda");

                entity.Property(e => e.IdentificacionTipoOperacion)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoOperacion");

                entity.Property(e => e.IdentificacionVersion).HasColumnName("Identificacion_Version");

                entity.Property(e => e.Integridad)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("integridad");

                entity.Property(e => e.JsonAprobado).HasColumnName("json_aprobado");

                entity.Property(e => e.Pdf).HasColumnName("pdf");

                entity.Property(e => e.PdfFechaHora)
                    .HasColumnType("datetime")
                    .HasColumnName("pdf_fecha_hora");

                entity.Property(e => e.ReceptorBienTitulo)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_BienTitulo");

                entity.Property(e => e.ReceptorCodActividad).HasColumnName("Receptor_CodActividad");

                entity.Property(e => e.ReceptorCodPais)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_CodPais");

                entity.Property(e => e.ReceptorCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Correo");

                entity.Property(e => e.ReceptorDescActividad).HasColumnName("Receptor_DescActividad");

                entity.Property(e => e.ReceptorDireccionComplemento).HasColumnName("Receptor_Direccion_Complemento");

                entity.Property(e => e.ReceptorDireccionDepartamento).HasColumnName("Receptor_Direccion_Departamento");

                entity.Property(e => e.ReceptorDireccionMunicipio).HasColumnName("Receptor_Direccion_Municipio");

                entity.Property(e => e.ReceptorNit)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nit");

                entity.Property(e => e.ReceptorNombre)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nombre");

                entity.Property(e => e.ReceptorNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NombreComercial");

                entity.Property(e => e.ReceptorNombrePais)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NombrePais");

                entity.Property(e => e.ReceptorNrc)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nrc");

                entity.Property(e => e.ReceptorNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NumDocumento");

                entity.Property(e => e.ReceptorTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Telefono");

                entity.Property(e => e.ReceptorTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_TipoDocumento");

                entity.Property(e => e.ReceptorTipoPersona)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_TipoPersona");

                entity.Property(e => e.ResumenCondicionOperacion).HasColumnName("Resumen_CondicionOperacion");

                entity.Property(e => e.ResumenDescIncoterms)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescIncoterms");

                entity.Property(e => e.ResumenDescu)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Descu");

                entity.Property(e => e.ResumenDescuExenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuExenta");

                entity.Property(e => e.ResumenDescuGravada)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuGravada");

                entity.Property(e => e.ResumenDescuNoSuj)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuNoSuj");

                entity.Property(e => e.ResumenDescuento)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Descuento");

                entity.Property(e => e.ResumenFlete)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Flete");

                entity.Property(e => e.ResumenIvaPerci1)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_IvaPerci1");

                entity.Property(e => e.ResumenIvaRete1)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_IvaRete1");

                entity.Property(e => e.ResumenMontoTotalOperacion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_MontoTotalOperacion");

                entity.Property(e => e.ResumenNumPagoElectronico)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_NumPagoElectronico");

                entity.Property(e => e.ResumenObservaciones)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Observaciones");

                entity.Property(e => e.ResumenPagosCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Codigo");

                entity.Property(e => e.ResumenPagosMontoPago)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_MontoPago");

                entity.Property(e => e.ResumenPagosPeriodo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Periodo");

                entity.Property(e => e.ResumenPagosPlazo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Plazo");

                entity.Property(e => e.ResumenPagosReferencia)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Referencia");

                entity.Property(e => e.ResumenPorcentajeDescuento)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_PorcentajeDescuento");

                entity.Property(e => e.ResumenReteRenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_ReteRenta");

                entity.Property(e => e.ResumenSaldoFavor)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SaldoFavor");

                entity.Property(e => e.ResumenSeguro)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Seguro");

                entity.Property(e => e.ResumenSubTotal)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SubTotal");

                entity.Property(e => e.ResumenSubTotalVentas)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SubTotalVentas");

                entity.Property(e => e.ResumenTotalCompra)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalCompra");

                entity.Property(e => e.ResumenTotalDescu)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalDescu");

                entity.Property(e => e.ResumenTotalExenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalExenta");

                entity.Property(e => e.ResumenTotalGravada)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalGravada");

                entity.Property(e => e.ResumenTotalIva)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIva");

                entity.Property(e => e.ResumenTotalIvaretenido)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIVAretenido");

                entity.Property(e => e.ResumenTotalIvaretenidoLetras)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIVAretenidoLetras");

                entity.Property(e => e.ResumenTotalLetras)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalLetras");

                entity.Property(e => e.ResumenTotalNoGravado)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalNoGravado");

                entity.Property(e => e.ResumenTotalNoSuj)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalNoSuj");

                entity.Property(e => e.ResumenTotalPagar)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalPagar");

                entity.Property(e => e.ResumenTotalSujetoRetencion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalSujetoRetencion");

                entity.Property(e => e.ResumenTributosCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Codigo");

                entity.Property(e => e.ResumenTributosDescripcion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Descripcion");

                entity.Property(e => e.ResumenTributosValor)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Valor");

                entity.Property(e => e.ResumenValorTotal)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_ValorTotal");

                entity.Property(e => e.Siguiente).HasColumnName("siguiente");

                entity.Property(e => e.SujetoExcluidoCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_CodActividad");

                entity.Property(e => e.SujetoExcluidoCorreo)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Correo");

                entity.Property(e => e.SujetoExcluidoDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_DescActividad");

                entity.Property(e => e.SujetoExcluidoDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Complemento");

                entity.Property(e => e.SujetoExcluidoDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Departamento");

                entity.Property(e => e.SujetoExcluidoDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Municipio");

                entity.Property(e => e.SujetoExcluidoNombre)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Nombre");

                entity.Property(e => e.SujetoExcluidoNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_NumDocumento");

                entity.Property(e => e.SujetoExcluidoTelefono)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Telefono");

                entity.Property(e => e.SujetoExcluidoTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_TipoDocumento");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("uuid");

                entity.Property(e => e.VentaTerceroNit)
                    .IsUnicode(false)
                    .HasColumnName("VentaTercero_Nit");

                entity.Property(e => e.VentaTerceroNombre).HasColumnName("VentaTercero_Nombre");
            });

            modelBuilder.Entity<CabeceraPropiedad>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cabecera_propiedad");

                entity.Property(e => e.Llave)
                    .HasMaxLength(128)
                    .HasColumnName("llave");
            });

            modelBuilder.Entity<CabeceraReintentoCore>(entity =>
            {
                entity.ToTable("cabecera_reintento_core");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Creacion)
                    .HasColumnType("datetime")
                    .HasColumnName("creacion");

                entity.Property(e => e.IdCabecera).HasColumnName("id_cabecera");

                entity.Property(e => e.IdConexion).HasColumnName("id_conexion");

                entity.Property(e => e.JsonCabecera)
                    .IsUnicode(false)
                    .HasColumnName("json_cabecera");

                entity.Property(e => e.JsonDetalle)
                    .IsUnicode(false)
                    .HasColumnName("json_detalle");

                entity.Property(e => e.Nota)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("nota");

                entity.Property(e => e.Procesado).HasColumnName("procesado");

                entity.HasOne(d => d.IdConexionNavigation)
                    .WithMany(p => p.CabeceraReintentoCores)
                    .HasForeignKey(d => d.IdConexion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_conexion_crc");
            });

            modelBuilder.Entity<CabeceraReintentoJson>(entity =>
            {
                entity.ToTable("cabecera_reintento_json");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Creacion)
                    .HasColumnType("datetime")
                    .HasColumnName("creacion");

                entity.Property(e => e.IdCabecera).HasColumnName("id_cabecera");

                entity.Property(e => e.IdConexion).HasColumnName("id_conexion");

                entity.Property(e => e.JsonCorreccion)
                    .IsUnicode(false)
                    .HasColumnName("json_correccion");

                entity.Property(e => e.Nota)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("nota");

                entity.Property(e => e.Procesado).HasColumnName("procesado");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("uuid");

                entity.HasOne(d => d.IdConexionNavigation)
                    .WithMany(p => p.CabeceraReintentoJsons)
                    .HasForeignKey(d => d.IdConexion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_conexion_crj");
            });

            modelBuilder.Entity<CabeceraWeb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cabecera_web");

                entity.Property(e => e.AceptadoMh).HasColumnName("aceptado_mh");

                entity.Property(e => e.Cadena)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("cadena");

                entity.Property(e => e.Cc).HasColumnName("cc");

                entity.Property(e => e.ContadorUuid).HasColumnName("contador_uuid");

                entity.Property(e => e.Creacion)
                    .HasColumnType("datetime")
                    .HasColumnName("creacion");

                entity.Property(e => e.DonanteCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodActividad");

                entity.Property(e => e.DonanteCodDomiciliado)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodDomiciliado");

                entity.Property(e => e.DonanteCodPais)
                    .IsUnicode(false)
                    .HasColumnName("Donante_CodPais");

                entity.Property(e => e.DonanteCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Correo");

                entity.Property(e => e.DonanteDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donante_DescActividad");

                entity.Property(e => e.DonanteDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Complemento");

                entity.Property(e => e.DonanteDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Departamento");

                entity.Property(e => e.DonanteDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Direccion_Municipio");

                entity.Property(e => e.DonanteTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Donante_Telefono");

                entity.Property(e => e.DonanteTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donante_TipoDocumento");

                entity.Property(e => e.DonatarioCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodActividad");

                entity.Property(e => e.DonatarioCodEstable)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodEstable");

                entity.Property(e => e.DonatarioCodEstableMh)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodEstableMH");

                entity.Property(e => e.DonatarioCodPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodPuntoVenta");

                entity.Property(e => e.DonatarioCodPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_CodPuntoVentaMH");

                entity.Property(e => e.DonatarioCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Correo");

                entity.Property(e => e.DonatarioDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Complemento");

                entity.Property(e => e.DonatarioDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Departamento");

                entity.Property(e => e.DonatarioDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Direccion_Municipio");

                entity.Property(e => e.DonatarioNombre)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Nombre");

                entity.Property(e => e.DonatarioNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_NombreComercial");

                entity.Property(e => e.DonatarioNrc)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Nrc");

                entity.Property(e => e.DonatarioNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_NumDocumento");

                entity.Property(e => e.DonatarioTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_Telefono");

                entity.Property(e => e.DonatarioTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_TipoDocumento");

                entity.Property(e => e.DonatarioTipoEstablecimiento)
                    .IsUnicode(false)
                    .HasColumnName("Donatario_TipoEstablecimiento");

                entity.Property(e => e.EmisorCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodActividad");

                entity.Property(e => e.EmisorCodEstable)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodEstable");

                entity.Property(e => e.EmisorCodEstableMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodEstableMH");

                entity.Property(e => e.EmisorCodPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodPuntoVenta");

                entity.Property(e => e.EmisorCodPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodPuntoVentaMH");

                entity.Property(e => e.EmisorCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Codigo");

                entity.Property(e => e.EmisorCodigoMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_CodigoMH");

                entity.Property(e => e.EmisorCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Correo");

                entity.Property(e => e.EmisorDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_DescActividad");

                entity.Property(e => e.EmisorDireccionComplemento).HasColumnName("Emisor_Direccion_Complemento");

                entity.Property(e => e.EmisorDireccionDepartamento).HasColumnName("Emisor_Direccion_Departamento");

                entity.Property(e => e.EmisorDireccionMunicipio).HasColumnName("Emisor_Direccion_Municipio");

                entity.Property(e => e.EmisorNit)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nit");

                entity.Property(e => e.EmisorNombre)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nombre");

                entity.Property(e => e.EmisorNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_NombreComercial");

                entity.Property(e => e.EmisorNrc)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Nrc");

                entity.Property(e => e.EmisorPuntoVenta)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVenta");

                entity.Property(e => e.EmisorPuntoVentaContri)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVentaContri");

                entity.Property(e => e.EmisorPuntoVentaMh)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_PuntoVentaMH");

                entity.Property(e => e.EmisorTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_Telefono");

                entity.Property(e => e.EmisorTipoEstablecimiento)
                    .IsUnicode(false)
                    .HasColumnName("Emisor_TipoEstablecimiento");

                entity.Property(e => e.Error).HasColumnName("error");

                entity.Property(e => e.ErrorMh).HasColumnName("error_mh");

                entity.Property(e => e.Eslavon)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("eslavon");

                entity.Property(e => e.EtlCompleto).HasColumnName("etl_completo");

                entity.Property(e => e.ExtensionCodEmpleado)
                    .IsUnicode(false)
                    .HasColumnName("Extension_CodEmpleado");

                entity.Property(e => e.ExtensionDocuEntrega)
                    .IsUnicode(false)
                    .HasColumnName("Extension_DocuEntrega");

                entity.Property(e => e.ExtensionDocuRecibe).HasColumnName("Extension_DocuRecibe");

                entity.Property(e => e.ExtensionNombEntrega).HasColumnName("Extension_NombEntrega");

                entity.Property(e => e.ExtensionNombRecibe).HasColumnName("Extension_NombRecibe");

                entity.Property(e => e.ExtensionObservaciones).HasColumnName("Extension_Observaciones");

                entity.Property(e => e.ExtensionPlacaVehiculo).HasColumnName("Extension_PlacaVehiculo");

                entity.Property(e => e.FechaDte)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("fechaDte");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IdAccion).HasColumnName("id_accion");

                entity.Property(e => e.IdConexion).HasColumnName("id_conexion");

                entity.Property(e => e.IdDetalleRegistro).HasColumnName("id_detalle_registro");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdJson).HasColumnName("id_json");

                entity.Property(e => e.IdTabla).HasColumnName("id_tabla");

                entity.Property(e => e.IdTransaccion).HasColumnName("id_transaccion");

                entity.Property(e => e.IdentificacionAmbiente)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_Ambiente");

                entity.Property(e => e.IdentificacionCodigoGeneracion).HasColumnName("Identificacion_CodigoGeneracion");

                entity.Property(e => e.IdentificacionFecEmi)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_FecEmi");

                entity.Property(e => e.IdentificacionHorEmi)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_HorEmi");

                entity.Property(e => e.IdentificacionMotivoContigencia)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_MotivoContigencia");

                entity.Property(e => e.IdentificacionMotivoContin)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_MotivoContin");

                entity.Property(e => e.IdentificacionNumeroControl)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_NumeroControl");

                entity.Property(e => e.IdentificacionRecintoFiscal)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_RecintoFiscal");

                entity.Property(e => e.IdentificacionRegimen)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_Regimen");

                entity.Property(e => e.IdentificacionTipoContingencia)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoContingencia");

                entity.Property(e => e.IdentificacionTipoDte)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoDte");

                entity.Property(e => e.IdentificacionTipoItemExpor)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoItemExpor");

                entity.Property(e => e.IdentificacionTipoModelo)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoModelo");

                entity.Property(e => e.IdentificacionTipoMoneda)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoMoneda");

                entity.Property(e => e.IdentificacionTipoOperacion)
                    .IsUnicode(false)
                    .HasColumnName("Identificacion_TipoOperacion");

                entity.Property(e => e.IdentificacionVersion).HasColumnName("Identificacion_Version");

                entity.Property(e => e.Integridad)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("integridad");

                entity.Property(e => e.JsonAprobado).HasColumnName("json_aprobado");

                entity.Property(e => e.Pdf).HasColumnName("pdf");

                entity.Property(e => e.PdfFechaHora)
                    .HasColumnType("datetime")
                    .HasColumnName("pdf_fecha_hora");

                entity.Property(e => e.ReceptorBienTitulo)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_BienTitulo");

                entity.Property(e => e.ReceptorCodActividad).HasColumnName("Receptor_CodActividad");

                entity.Property(e => e.ReceptorCodPais)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_CodPais");

                entity.Property(e => e.ReceptorCorreo)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Correo");

                entity.Property(e => e.ReceptorDescActividad).HasColumnName("Receptor_DescActividad");

                entity.Property(e => e.ReceptorDireccionComplemento).HasColumnName("Receptor_Direccion_Complemento");

                entity.Property(e => e.ReceptorDireccionDepartamento).HasColumnName("Receptor_Direccion_Departamento");

                entity.Property(e => e.ReceptorDireccionMunicipio).HasColumnName("Receptor_Direccion_Municipio");

                entity.Property(e => e.ReceptorNit)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nit");

                entity.Property(e => e.ReceptorNombre)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nombre");

                entity.Property(e => e.ReceptorNombreComercial)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NombreComercial");

                entity.Property(e => e.ReceptorNombrePais)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NombrePais");

                entity.Property(e => e.ReceptorNrc)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Nrc");

                entity.Property(e => e.ReceptorNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_NumDocumento");

                entity.Property(e => e.ReceptorTelefono)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_Telefono");

                entity.Property(e => e.ReceptorTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_TipoDocumento");

                entity.Property(e => e.ReceptorTipoPersona)
                    .IsUnicode(false)
                    .HasColumnName("Receptor_TipoPersona");

                entity.Property(e => e.ResumenCondicionOperacion).HasColumnName("Resumen_CondicionOperacion");

                entity.Property(e => e.ResumenDescIncoterms)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescIncoterms");

                entity.Property(e => e.ResumenDescu)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Descu");

                entity.Property(e => e.ResumenDescuExenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuExenta");

                entity.Property(e => e.ResumenDescuGravada)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuGravada");

                entity.Property(e => e.ResumenDescuNoSuj)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_DescuNoSuj");

                entity.Property(e => e.ResumenDescuento)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Descuento");

                entity.Property(e => e.ResumenFlete)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Flete");

                entity.Property(e => e.ResumenIvaPerci1)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_IvaPerci1");

                entity.Property(e => e.ResumenIvaRete1)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_IvaRete1");

                entity.Property(e => e.ResumenMontoTotalOperacion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_MontoTotalOperacion");

                entity.Property(e => e.ResumenNumPagoElectronico)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_NumPagoElectronico");

                entity.Property(e => e.ResumenObservaciones)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Observaciones");

                entity.Property(e => e.ResumenPagosCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Codigo");

                entity.Property(e => e.ResumenPagosMontoPago)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_MontoPago");

                entity.Property(e => e.ResumenPagosPeriodo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Periodo");

                entity.Property(e => e.ResumenPagosPlazo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Plazo");

                entity.Property(e => e.ResumenPagosReferencia)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Pagos_Referencia");

                entity.Property(e => e.ResumenPorcentajeDescuento)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_PorcentajeDescuento");

                entity.Property(e => e.ResumenReteRenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_ReteRenta");

                entity.Property(e => e.ResumenSaldoFavor)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SaldoFavor");

                entity.Property(e => e.ResumenSeguro)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Seguro");

                entity.Property(e => e.ResumenSubTotal)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SubTotal");

                entity.Property(e => e.ResumenSubTotalVentas)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_SubTotalVentas");

                entity.Property(e => e.ResumenTotalCompra)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalCompra");

                entity.Property(e => e.ResumenTotalDescu)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalDescu");

                entity.Property(e => e.ResumenTotalExenta)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalExenta");

                entity.Property(e => e.ResumenTotalGravada)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalGravada");

                entity.Property(e => e.ResumenTotalIva)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIva");

                entity.Property(e => e.ResumenTotalIvaretenido)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIVAretenido");

                entity.Property(e => e.ResumenTotalIvaretenidoLetras)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalIVAretenidoLetras");

                entity.Property(e => e.ResumenTotalLetras)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalLetras");

                entity.Property(e => e.ResumenTotalNoGravado)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalNoGravado");

                entity.Property(e => e.ResumenTotalNoSuj)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalNoSuj");

                entity.Property(e => e.ResumenTotalPagar)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalPagar");

                entity.Property(e => e.ResumenTotalSujetoRetencion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_TotalSujetoRetencion");

                entity.Property(e => e.ResumenTributosCodigo)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Codigo");

                entity.Property(e => e.ResumenTributosDescripcion)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Descripcion");

                entity.Property(e => e.ResumenTributosValor)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_Tributos_Valor");

                entity.Property(e => e.ResumenValorTotal)
                    .IsUnicode(false)
                    .HasColumnName("Resumen_ValorTotal");

                entity.Property(e => e.Siguiente).HasColumnName("siguiente");

                entity.Property(e => e.SujetoExcluidoCodActividad)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_CodActividad");

                entity.Property(e => e.SujetoExcluidoCorreo)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Correo");

                entity.Property(e => e.SujetoExcluidoDescActividad)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_DescActividad");

                entity.Property(e => e.SujetoExcluidoDireccionComplemento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Complemento");

                entity.Property(e => e.SujetoExcluidoDireccionDepartamento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Departamento");

                entity.Property(e => e.SujetoExcluidoDireccionMunicipio)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Direccion_Municipio");

                entity.Property(e => e.SujetoExcluidoNombre)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Nombre");

                entity.Property(e => e.SujetoExcluidoNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_NumDocumento");

                entity.Property(e => e.SujetoExcluidoTelefono)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_Telefono");

                entity.Property(e => e.SujetoExcluidoTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("SujetoExcluido_TipoDocumento");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("uuid");

                entity.Property(e => e.VentaTerceroNit)
                    .IsUnicode(false)
                    .HasColumnName("VentaTercero_Nit");

                entity.Property(e => e.VentaTerceroNombre).HasColumnName("VentaTercero_Nombre");
            });

            modelBuilder.Entity<Capitalizacion>(entity =>
            {
                entity.ToTable("capitalizacion", "opc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ejemplo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ejemplo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<CodigoActividadEconomica>(entity =>
            {
                entity.ToTable("codigo_actividad_economica");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<CodigoImportacion>(entity =>
            {
                entity.ToTable("codigo_importacion");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.ToTable("color", "conf");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Blanco).HasColumnName("blanco");

                entity.Property(e => e.Valor)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<CondicionOperacion>(entity =>
            {
                entity.ToTable("condicion_operacion");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<Conexion>(entity =>
            {
                entity.ToTable("conexion", "conf");

                entity.HasComment("Conexión a las bases de datos a las que se accede mediante el JDBC (Java Database Connectivity). Contiene un nombre genérico para la conexión, así como detalles específicos de la configuración de la conexión, como la dirección del servidor, el número de puerto, el nombre de la base de datos y las credenciales de autenticación.\r\n\r\nLa tabla \"Conexion\" es esencial para garantizar la disponibilidad y fiabilidad de la información almacenada en la base de datos, ya que proporciona una forma de mantener y gestionar las conexiones a los sistemas de gestión de bases de datos relacionales. Además, esta tabla también puede utilizarse para auditar el acceso a las bases de datos y garantizar el cumplimiento de las políticas de seguridad establecidas por la organización.");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("identity");

                entity.Property(e => e.ActualizacionFirma)
                    .HasColumnName("actualizacion_firma")
                    .HasComment("tiempo (en minutos) para actualizar la firma del dte");

                entity.Property(e => e.ActualizacionFirmaDte)
                    .HasColumnType("datetime")
                    .HasColumnName("actualizacion_firma_dte")
                    .HasComment("ultima fecha y hora en la que se actualizo el dte");

                entity.Property(e => e.Base)
                    .HasMaxLength(50)
                    .HasColumnName("base")
                    .HasComment("nombre de la base de datos");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.CorreoAsunto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("correo_asunto");

                entity.Property(e => e.CorreoContra)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("correo_contra");

                entity.Property(e => e.CorreoCuerpo)
                    .IsUnicode(false)
                    .HasColumnName("correo_cuerpo")
                    .HasComment("en el titulo, asunto y cuerpo del documento, se pueden agregar solamente objetos del json o campos de la cabecera, no arreglos");

                entity.Property(e => e.CorreoIp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("correo_ip");

                entity.Property(e => e.CorreoPdf)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("correo_pdf")
                    .HasComment("apartado de contactenos");

                entity.Property(e => e.CorreoPuerto).HasColumnName("correo_puerto");

                entity.Property(e => e.CorreoTitulo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("correo_titulo");

                entity.Property(e => e.FacebookPdf)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("facebook_pdf")
                    .HasComment("apartado de contactenos");

                entity.Property(e => e.FirmaDte)
                    .IsUnicode(false)
                    .HasColumnName("firma_dte")
                    .HasComment("la firma del dte en uso");

                entity.Property(e => e.InstagramPdf)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("instagram_pdf")
                    .HasComment("apartado de contactenos");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ip")
                    .HasComment("ip de bdd");

                entity.Property(e => e.LogoPdf)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("logo_pdf")
                    .HasComment("direccion de la imagen para que aparezca el logo en el pdf (puede ser local o url)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre")
                    .HasComment("nombre para mostrar");

                entity.Property(e => e.NrcPdf)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nrc_pdf")
                    .HasComment("NRC por el guion faltante");

                entity.Property(e => e.Puerto)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("puerto")
                    .HasComment("puerto que utiliza");

                entity.Property(e => e.WhatsappPdf)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("whatsapp_pdf")
                    .HasComment("apartado de contactenos");
            });

            modelBuilder.Entity<Controlador>(entity =>
            {
                entity.ToTable("controlador", "conf");

                entity.HasComment("Comportamientos específicos del aplicativo, que son configurables mediante claves y valores. Cada registro en la tabla \"Controlador\" contiene una clave que identifica el comportamiento específico del aplicativo que se está configurando, una descripción del mismo y un valor que indica cómo se debe comportar el aplicativo en relación a ese comportamiento.\r\n\r\nLa tabla \"Controlador\" es esencial para garantizar la flexibilidad y adaptabilidad del aplicativo, ya que proporciona una forma de configurar y personalizar el comportamiento del sistema sin necesidad de realizar cambios en el código fuente. Además, esta tabla también puede utilizarse para auditar y controlar los cambios en el comportamiento del aplicativo y para garantizar el cumplimiento de las políticas de seguridad establecidas por la organización.");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("identity");

                entity.Property(e => e.Bandera)
                    .HasColumnName("bandera")
                    .HasComment("campo booleano para activar o desactivar el controlador");

                entity.Property(e => e.Cero)
                    .HasMaxLength(100)
                    .HasColumnName("cero")
                    .HasComment("indica el valor del cero");

                entity.Property(e => e.Correlativo).HasColumnName("correlativo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(999)
                    .HasColumnName("descripcion")
                    .HasComment("descripcion de la accion a controlar");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(25)
                    .HasColumnName("nombre")
                    .HasComment("nombre de la accion a controlar");

                entity.Property(e => e.Uno)
                    .HasMaxLength(100)
                    .HasColumnName("uno")
                    .HasComment("indica el valor del numero uno");
            });

            modelBuilder.Entity<Correo>(entity =>
            {
                entity.ToTable("correo", "conf");

                entity.HasComment("correos a los que se les enviara distintas acciones al momento de realizar alguna tarea en los aplicativos");

                entity.HasIndex(e => e.Valor, "correo_UN")
                    .IsUnique();

                entity.HasIndex(e => e.Valor, "correo_valor_unic")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Valor)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<CorreoXAccion>(entity =>
            {
                entity.ToTable("correo_x_accion", "conf");

                entity.HasComment("el correo que se le enviara individualmente a cada usuario por accion realizada");

                entity.HasIndex(e => new { e.IdCorreo, e.IdAccion }, "correo_x_accion_vals_unic")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activado).HasColumnName("activado");

                entity.Property(e => e.IdAccion).HasColumnName("id_accion");

                entity.Property(e => e.IdCorreo).HasColumnName("id_correo");

                entity.HasOne(d => d.IdAccionNavigation)
                    .WithMany(p => p.CorreoXAccions)
                    .HasForeignKey(d => d.IdAccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_accion_correo_x_accion");

                entity.HasOne(d => d.IdCorreoNavigation)
                    .WithMany(p => p.CorreoXAccions)
                    .HasForeignKey(d => d.IdCorreo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_correo_correo_x_accion");
            });

            modelBuilder.Entity<CorreoXAccion1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("correo_x_accion");

                entity.Property(e => e.Accion).HasColumnName("accion");

                entity.Property(e => e.Correo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<DatosDte>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Datos_DTE");

                entity.Property(e => e.Bd)
                    .HasMaxLength(50)
                    .HasColumnName("BD");

                entity.Property(e => e.Error).IsUnicode(false);

                entity.Property(e => e.Estado).HasMaxLength(500);

                entity.Property(e => e.Idcontrol)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("IDControl");

                entity.Property(e => e.Log).IsUnicode(false);

                entity.Property(e => e.TipoDoc)
                    .HasMaxLength(50)
                    .HasColumnName("Tipo_Doc");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.ToTable("departamento");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<Detalle>(entity =>
            {
                entity.ToTable("detalle");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApendiceCampo)
                    .IsUnicode(false)
                    .HasColumnName("Apendice_Campo");

                entity.Property(e => e.ApendiceEtiqueta)
                    .IsUnicode(false)
                    .HasColumnName("Apendice_Etiqueta");

                entity.Property(e => e.ApendiceValor)
                    .IsUnicode(false)
                    .HasColumnName("Apendice_Valor");

                entity.Property(e => e.Creacion)
                    .HasColumnType("datetime")
                    .HasColumnName("creacion");

                entity.Property(e => e.CuerpoDocumentoCantidad)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_Cantidad");

                entity.Property(e => e.CuerpoDocumentoCodTributo)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_CodTributo");

                entity.Property(e => e.CuerpoDocumentoCodigo)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_Codigo");

                entity.Property(e => e.CuerpoDocumentoCodigoRetencionMh)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_CodigoRetencionMH")
                    .HasComment("Comprobante de Retención Electrónica");

                entity.Property(e => e.CuerpoDocumentoCompra)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_Compra")
                    .HasComment("Factura de Sujeto Excluido Electrónica");

                entity.Property(e => e.CuerpoDocumentoDepreciacion)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_Depreciacion")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.CuerpoDocumentoDescripcion)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_Descripcion");

                entity.Property(e => e.CuerpoDocumentoFechaEmision)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_FechaEmision");

                entity.Property(e => e.CuerpoDocumentoIvaItem)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_IvaItem");

                entity.Property(e => e.CuerpoDocumentoIvaRetenido)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_IvaRetenido")
                    .HasComment("Comprobante de Retención Electrónica");

                entity.Property(e => e.CuerpoDocumentoMontoDescu)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_MontoDescu");

                entity.Property(e => e.CuerpoDocumentoMontoSujetoGrav)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_MontoSujetoGrav");

                entity.Property(e => e.CuerpoDocumentoNoGravado)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_NoGravado");

                entity.Property(e => e.CuerpoDocumentoNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_NumDocumento");

                entity.Property(e => e.CuerpoDocumentoNumItem)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_NumItem");

                entity.Property(e => e.CuerpoDocumentoNumeroDocumento)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_NumeroDocumento");

                entity.Property(e => e.CuerpoDocumentoPrecioUni)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_PrecioUni")
                    .HasComment("Comprobante de Crédito Fiscal Electrónica");

                entity.Property(e => e.CuerpoDocumentoPsv)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_Psv");

                entity.Property(e => e.CuerpoDocumentoTipoDoc)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_TipoDoc");

                entity.Property(e => e.CuerpoDocumentoTipoDonacion)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_TipoDonacion")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.CuerpoDocumentoTipoDte)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_TipoDte");

                entity.Property(e => e.CuerpoDocumentoTipoItem)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_TipoItem");

                entity.Property(e => e.CuerpoDocumentoTributos).HasColumnName("CuerpoDocumento_Tributos");

                entity.Property(e => e.CuerpoDocumentoUniMedida)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_UniMedida");

                entity.Property(e => e.CuerpoDocumentoValor)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_Valor")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.CuerpoDocumentoValorUni)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_ValorUni")
                    .HasComment("Comprobante de Donación Electrónica");

                entity.Property(e => e.CuerpoDocumentoVentaExenta)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_VentaExenta");

                entity.Property(e => e.CuerpoDocumentoVentaGravada)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_VentaGravada");

                entity.Property(e => e.CuerpoDocumentoVentaNoSuj)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_VentaNoSuj");

                entity.Property(e => e.DocumentoRelacionadoFechaEmision)
                    .IsUnicode(false)
                    .HasColumnName("DocumentoRelacionado_FechaEmision");

                entity.Property(e => e.DocumentoRelacionadoNumeroDocumento)
                    .IsUnicode(false)
                    .HasColumnName("DocumentoRelacionado_NumeroDocumento");

                entity.Property(e => e.DocumentoRelacionadoTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("DocumentoRelacionado_TipoDocumento");

                entity.Property(e => e.DocumentoRelacionadoTipoGeneracion)
                    .IsUnicode(false)
                    .HasColumnName("DocumentoRelacionado_TipoGeneracion");

                entity.Property(e => e.OtrosDocumentosCodDocAsociado)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_CodDocAsociado");

                entity.Property(e => e.OtrosDocumentosDescDocumento)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_DescDocumento");

                entity.Property(e => e.OtrosDocumentosDetalleDocumento)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_DetalleDocumento");

                entity.Property(e => e.OtrosDocumentosMedicoDocIdentificacion)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_Medico_DocIdentificacion");

                entity.Property(e => e.OtrosDocumentosMedicoNit)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_Medico_Nit");

                entity.Property(e => e.OtrosDocumentosMedicoNombre)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_Medico_Nombre");

                entity.Property(e => e.OtrosDocumentosMedicoTipoServicio)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_Medico_TipoServicio");

                entity.Property(e => e.OtrosDocumentosModoTransp)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_ModoTransp")
                    .HasComment("Factura de Exportación Electrónica");

                entity.Property(e => e.OtrosDocumentosNombreConductor)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_NombreConductor")
                    .HasComment("Factura de Exportación Electrónica");

                entity.Property(e => e.OtrosDocumentosNumConductor)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_NumConductor")
                    .HasComment("Factura de Exportación Electrónica");

                entity.Property(e => e.OtrosDocumentosPlacaTrans)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_PlacaTrans")
                    .HasComment("Factura de Exportación Electrónica");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("uuid");
            });

            modelBuilder.Entity<DetalleAlert>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("detalle_alert");

                entity.Property(e => e.ApendiceCampo)
                    .IsUnicode(false)
                    .HasColumnName("Apendice_Campo");

                entity.Property(e => e.ApendiceEtiqueta)
                    .IsUnicode(false)
                    .HasColumnName("Apendice_Etiqueta");

                entity.Property(e => e.ApendiceValor)
                    .IsUnicode(false)
                    .HasColumnName("Apendice_Valor");

                entity.Property(e => e.CeroComaCero)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Cero_Coma_Cero");

                entity.Property(e => e.Creacion)
                    .HasColumnType("datetime")
                    .HasColumnName("creacion");

                entity.Property(e => e.CuerpoDocumentoCantidad)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_Cantidad");

                entity.Property(e => e.CuerpoDocumentoCodTributo)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_CodTributo");

                entity.Property(e => e.CuerpoDocumentoCodigo)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_Codigo");

                entity.Property(e => e.CuerpoDocumentoCodigoRetencionMh)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_CodigoRetencionMH");

                entity.Property(e => e.CuerpoDocumentoCompra)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_Compra");

                entity.Property(e => e.CuerpoDocumentoDepreciacion)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_Depreciacion");

                entity.Property(e => e.CuerpoDocumentoDescripcion)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_Descripcion");

                entity.Property(e => e.CuerpoDocumentoFechaEmision)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_FechaEmision");

                entity.Property(e => e.CuerpoDocumentoIvaItem)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_IvaItem");

                entity.Property(e => e.CuerpoDocumentoIvaRetenido)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_IvaRetenido");

                entity.Property(e => e.CuerpoDocumentoMontoDescu)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_MontoDescu");

                entity.Property(e => e.CuerpoDocumentoMontoSujetoGrav)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_MontoSujetoGrav");

                entity.Property(e => e.CuerpoDocumentoNoGravado)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_NoGravado");

                entity.Property(e => e.CuerpoDocumentoNumDocumento)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_NumDocumento");

                entity.Property(e => e.CuerpoDocumentoNumItem)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_NumItem");

                entity.Property(e => e.CuerpoDocumentoNumeroDocumento)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_NumeroDocumento");

                entity.Property(e => e.CuerpoDocumentoPrecioUni)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_PrecioUni");

                entity.Property(e => e.CuerpoDocumentoPsv)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_Psv");

                entity.Property(e => e.CuerpoDocumentoTipoDoc)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_TipoDoc");

                entity.Property(e => e.CuerpoDocumentoTipoDocumentoDte)
                    .HasMaxLength(50)
                    .HasColumnName("CuerpoDocumento_TipoDocumentoDte");

                entity.Property(e => e.CuerpoDocumentoTipoDonacion)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_TipoDonacion");

                entity.Property(e => e.CuerpoDocumentoTipoDte)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_TipoDte");

                entity.Property(e => e.CuerpoDocumentoTipoItem)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_TipoItem");

                entity.Property(e => e.CuerpoDocumentoTributos).HasColumnName("CuerpoDocumento_Tributos");

                entity.Property(e => e.CuerpoDocumentoUniMedida)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_UniMedida");

                entity.Property(e => e.CuerpoDocumentoUnidadMedida)
                    .HasMaxLength(250)
                    .HasColumnName("CuerpoDocumento_UnidadMedida");

                entity.Property(e => e.CuerpoDocumentoValor)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_Valor");

                entity.Property(e => e.CuerpoDocumentoValorUni)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_ValorUni");

                entity.Property(e => e.CuerpoDocumentoVentaExenta)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_VentaExenta");

                entity.Property(e => e.CuerpoDocumentoVentaGravada)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_VentaGravada");

                entity.Property(e => e.CuerpoDocumentoVentaNoSuj)
                    .IsUnicode(false)
                    .HasColumnName("CuerpoDocumento_VentaNoSuj");

                entity.Property(e => e.DocumentoRelacionadoFechaEmision)
                    .IsUnicode(false)
                    .HasColumnName("DocumentoRelacionado_FechaEmision");

                entity.Property(e => e.DocumentoRelacionadoNumeroDocumento)
                    .IsUnicode(false)
                    .HasColumnName("DocumentoRelacionado_NumeroDocumento");

                entity.Property(e => e.DocumentoRelacionadoTipoDocumento)
                    .IsUnicode(false)
                    .HasColumnName("DocumentoRelacionado_TipoDocumento");

                entity.Property(e => e.DocumentoRelacionadoTipoDocumentoPdf)
                    .HasMaxLength(50)
                    .HasColumnName("DocumentoRelacionado_TipoDocumento_Pdf");

                entity.Property(e => e.DocumentoRelacionadoTipoGeneracion)
                    .IsUnicode(false)
                    .HasColumnName("DocumentoRelacionado_TipoGeneracion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OtrosDocumentosCodDocAsociado)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_CodDocAsociado");

                entity.Property(e => e.OtrosDocumentosDescDocumento)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_DescDocumento");

                entity.Property(e => e.OtrosDocumentosDetalleDocumento)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_DetalleDocumento");

                entity.Property(e => e.OtrosDocumentosMedicoDocIdentificacion)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_Medico_DocIdentificacion");

                entity.Property(e => e.OtrosDocumentosMedicoNit)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_Medico_Nit");

                entity.Property(e => e.OtrosDocumentosMedicoNombre)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_Medico_Nombre");

                entity.Property(e => e.OtrosDocumentosMedicoTipoServicio)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_Medico_TipoServicio");

                entity.Property(e => e.OtrosDocumentosModoTransp)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_ModoTransp");

                entity.Property(e => e.OtrosDocumentosNombreConductor)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_NombreConductor");

                entity.Property(e => e.OtrosDocumentosNumConductor)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_NumConductor");

                entity.Property(e => e.OtrosDocumentosPlacaTrans)
                    .IsUnicode(false)
                    .HasColumnName("OtrosDocumentos_PlacaTrans");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("uuid");

                entity.Property(e => e.VaCio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Va_Cio");
            });

            modelBuilder.Entity<DetallePropiedad>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("detalle_propiedad");

                entity.Property(e => e.Llave)
                    .HasMaxLength(128)
                    .HasColumnName("llave");
            });

            modelBuilder.Entity<DetalleRegistro>(entity =>
            {
                entity.ToTable("detalle_registro", "log");

                entity.HasComment("Está relacionada con la tabla anterior \"Registro\" y se utiliza para registrar la fecha de creación de cada registro en la tabla \"Registro\" y el evento que se utilizó en ese momento. Cada registro en la tabla \"Linea_Registro\" contiene una clave foránea que hace referencia al registro correspondiente en la tabla \"Registro\", así como la fecha y hora en que se creó ese registro.\r\n\r\nLa tabla \"Linea_Registro\" es esencial para el seguimiento y análisis del comportamiento de la aplicación, ya que proporciona una forma de rastrear la creación de cada registro en la tabla \"Registro\" y el evento asociado que se utilizó en ese momento. Además, esta tabla también puede utilizarse para auditar y controlar el rendimiento de la aplicación y para garantizar el cumplimiento de las políticas de seguridad y privacidad establecidas por la organización.");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("identity");

                entity.Property(e => e.Creacion)
                    .HasColumnType("datetime")
                    .HasColumnName("creacion")
                    .HasComment("fecha y hora de creacion");

                entity.Property(e => e.Descripcion)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.IdErrorAplicacion)
                    .HasColumnName("id_error_aplicacion")
                    .HasComment("referencia con el posible error que este registro pueda tener");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("id_registro")
                    .HasComment("referencia con el tipo de registro que se ha creado");

                entity.HasOne(d => d.IdErrorAplicacionNavigation)
                    .WithMany(p => p.DetalleRegistros)
                    .HasForeignKey(d => d.IdErrorAplicacion)
                    .HasConstraintName("id_error_aplicacion_detalle_registro");

                entity.HasOne(d => d.IdRegistroNavigation)
                    .WithMany(p => p.DetalleRegistros)
                    .HasForeignKey(d => d.IdRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_registro_linea_registro");
            });

            modelBuilder.Entity<ErrorAplicacion>(entity =>
            {
                entity.ToTable("error_aplicacion", "log");

                entity.HasComment("Almacenar información detallada sobre los errores que se producen en la aplicación. Cuando ocurre un error, se crea un nuevo registro en la tabla \"Error_Aplicacion\" que contiene información sobre la fecha y hora del error, la descripción del error y cualquier otra información relevante que pueda ayudar a identificar la causa del problema.\r\n\r\nLa tabla \"Error_Aplicacion\" es esencial para el monitoreo y resolución de problemas en la aplicación, ya que proporciona una forma de registrar y analizar los errores que se producen en el sistema. Además, esta tabla también puede utilizarse para auditar y controlar el rendimiento de la aplicación y para garantizar el cumplimiento de las políticas de seguridad y privacidad establecidas por la organización.");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("identity");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(999)
                    .HasColumnName("codigo")
                    .HasComment("codigo de error de acuerdo a c#");

                entity.Property(e => e.Creacion)
                    .HasColumnType("datetime")
                    .HasColumnName("creacion")
                    .HasComment("hora y fecha de creacion");

                entity.Property(e => e.Valor)
                    .IsUnicode(false)
                    .HasColumnName("valor")
                    .HasComment("descripcion de la excepcion desde el backend");

                entity.Property(e => e.Voz)
                    .IsUnicode(false)
                    .HasColumnName("voz");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.ToTable("estado", "conf");

                entity.HasComment("Respuestas de la API, proporcionando detalles sobre el estado de la conexión, los errores HTTP, los errores internos de la API, entre otros. Cada registro en la tabla estado contiene un código de respuesta que identifica el tipo de respuesta, una descripción amigable para el usuario y detalles técnicos adicionales, como el código de estado HTTP, el mensaje de error y cualquier otra información relevante.\r\n\r\nLa tabla \"estado\" es esencial para garantizar la calidad y fiabilidad de las respuestas de la API, ya que proporciona una forma de registrar y analizar los resultados de las solicitudes enviadas a la API. Además, esta tabla también puede utilizarse para auditar y controlar el rendimiento de la API y para garantizar el cumplimiento de las políticas de seguridad y privacidad establecidas por la organización.");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("identity");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .HasColumnName("descripcion")
                    .HasComment("descripcion, significado, explicacion de este error que este apareciendo");

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasComment("codigo de respuesta, generalmente represetado por un numero");

                entity.Property(e => e.IdColor).HasColumnName("id_color");

                entity.Property(e => e.IdTipoEstado)
                    .HasColumnName("id_tipo_estado")
                    .HasComment("tipo de estado, descripcion mas general de lo que esta pasando inidcando si es respuesta de haciendao simplemente estatus http");

                entity.HasOne(d => d.IdColorNavigation)
                    .WithMany(p => p.Estados)
                    .HasForeignKey(d => d.IdColor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estado_color");

                entity.HasOne(d => d.IdTipoEstadoNavigation)
                    .WithMany(p => p.Estados)
                    .HasForeignKey(d => d.IdTipoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_tipo_estado_estado");
            });

            modelBuilder.Entity<FormaPago>(entity =>
            {
                entity.ToTable("forma_pago");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<Json>(entity =>
            {
                entity.ToTable("json", "opc");

                entity.HasComment("tabla pibote para saber que json usare dependiendo de la parametrizacion en la tabla parametro");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("identity");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasComment("con este campo se indicara que version de json para cada tipo de factura esta activo. CUIDADO con tener dos JSON de facturas activos ya que el aplicativo ordenara de forma ascendente los registros de esta tabla y podria ser que no se actualice la version que se esta tratando de tomar en cuenta.");

                entity.Property(e => e.Arreglo)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("arreglo")
                    .HasComment("arreglos normales []");

                entity.Property(e => e.ArregloObjeto)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("arreglo_objeto")
                    .HasComment("arreglos de objetos [{}]");

                entity.Property(e => e.EliminarExcedente)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("eliminar_excedente")
                    .HasComment("escribiras el path del json que deseas que se elimine\r\npor ejemplo \r\n\r\nresumen.pagos hara que la propiedad pagos dentro del objeto resumen se remueva del json\r\n\r\nresumen[n].pagos es diferente\r\nse hace referencia a un arreglo que puede tener esa propiedad pagos dentro de algun objeto en el, esto, eliminaria (de todos los objetos dentro de resumen) la propiedad pagos");

                entity.Property(e => e.ErrorJson).HasColumnName("error_json");

                entity.Property(e => e.IdTipoDocumento)
                    .HasColumnName("id_tipo_documento")
                    .HasComment("relacionado con tipo de documento");

                entity.Property(e => e.Ruta)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("ruta")
                    .HasComment("ruta exacta del archivo");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasComment("relacionado con version");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Jsons)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("json_tipo_documento");
            });

            modelBuilder.Entity<ModeloFacturacion>(entity =>
            {
                entity.ToTable("modelo_facturacion");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.ToTable("municipio");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdDepartamento).HasColumnName("id_departamento");

                entity.Property(e => e.Valores).HasMaxLength(250);

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Municipios)
                    .HasForeignKey(d => d.IdDepartamento)
                    .HasConstraintName("fk_id_departamento_municipio");
            });

            modelBuilder.Entity<OtrosDocumentosAsociado>(entity =>
            {
                entity.ToTable("otros_documentos_asociados");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<Pai>(entity =>
            {
                entity.ToTable("pais");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<Parametro>(entity =>
            {
                entity.ToTable("parametro", "conf");

                entity.HasComment("parametros clave, valor y su descripcion para diferentes configuraciones en el sistema y para guardados en memoria desde una base de datos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("identity");

                entity.Property(e => e.Clave)
                    .HasMaxLength(100)
                    .HasColumnName("clave")
                    .HasComment("nombre descriptivo sobre lo que se esta guardando");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(999)
                    .HasColumnName("descripcion")
                    .HasComment("descripcion sobre a lo que se regiere esta clave");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasComment("valor, cantidad de la clave, se utilizara para las diferentes configuraciones en el sistema ETL o CORE");
            });

            modelBuilder.Entity<Pdf>(entity =>
            {
                entity.ToTable("pdf", "opc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Clave)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("clave");

                entity.Property(e => e.ClaveNegrita).HasColumnName("clave_negrita");

                entity.Property(e => e.Correlativo).HasColumnName("correlativo");

                entity.Property(e => e.Decimales).HasColumnName("decimales");

                entity.Property(e => e.IdCapitalizaicon).HasColumnName("id_capitalizaicon");

                entity.Property(e => e.IdPdfSeccion).HasColumnName("id_pdf_seccion");

                entity.Property(e => e.IdTipado).HasColumnName("id_tipado");

                entity.Property(e => e.OrientacionTexto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("orientacion_texto");

                entity.Property(e => e.Posicion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("posicion")
                    .HasComment("c: centro(o sin formato), i: izquierda, d: derecha, (para que el registro no aparezca simulando una desactivacion, puede colocar cualquier otra letra) j: justificado (a la izquierda) sin fields del 50% entre derecha e izquierda\r\n\r\nsi la orientacion se genera en un objeto, es:\r\n|--------------------|\r\n|              c                  |\r\n| i                             d |\r\n|      j                           |\r\n|--------------------|\r\nno alinea el texto en los objetos como en las tablas");

                entity.Property(e => e.TextoAOmitir)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("texto_a_omitir")
                    .HasComment("separar las palabras por dos puntos y comas");

                entity.Property(e => e.TextoAReemplazar)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("texto_a_reemplazar")
                    .HasComment("separar el reemplazar asi: si tenemos tomate ajo y cebolla como cadena de texto y queremos reemplazar cebolla por lechuga: cebolla::lechuga;;cebolla::lechuga");

                entity.Property(e => e.TextoAgregadoAntes)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("texto_agregado_antes");

                entity.Property(e => e.TextoAgregadoDespues)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("texto_agregado_despues");

                entity.Property(e => e.Valor)
                    .IsUnicode(false)
                    .HasColumnName("valor");

                entity.Property(e => e.ValorNegrita).HasColumnName("valor_negrita");

                entity.HasOne(d => d.IdCapitalizaiconNavigation)
                    .WithMany(p => p.Pdfs)
                    .HasForeignKey(d => d.IdCapitalizaicon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_id_capitalizacion");

                entity.HasOne(d => d.IdPdfSeccionNavigation)
                    .WithMany(p => p.Pdfs)
                    .HasForeignKey(d => d.IdPdfSeccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pdf_id_conf_pdf_seccion");

                entity.HasOne(d => d.IdTipadoNavigation)
                    .WithMany(p => p.Pdfs)
                    .HasForeignKey(d => d.IdTipado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_id_tipado_pdf");
            });

            modelBuilder.Entity<PdfSeccion>(entity =>
            {
                entity.ToTable("pdf_seccion", "conf");

                entity.HasIndex(e => new { e.IdJson, e.IdPdfVinculacion }, "unique_seccion_vinculacion_json")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EliminarVacios).HasColumnName("eliminar_vacios");

                entity.Property(e => e.IdJson).HasColumnName("id_json");

                entity.Property(e => e.IdPdfVinculacion).HasColumnName("id_pdf_vinculacion");

                entity.Property(e => e.IdTipado).HasColumnName("id_tipado");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdJsonNavigation)
                    .WithMany(p => p.PdfSeccions)
                    .HasForeignKey(d => d.IdJson)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_id_json_pdf_seccion");

                entity.HasOne(d => d.IdPdfVinculacionNavigation)
                    .WithMany(p => p.PdfSeccions)
                    .HasForeignKey(d => d.IdPdfVinculacion)
                    .HasConstraintName("pdf_vinculacion_seccion");

                entity.HasOne(d => d.IdTipadoNavigation)
                    .WithMany(p => p.PdfSeccions)
                    .HasForeignKey(d => d.IdTipado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pdf_seccion_id_tipado");
            });

            modelBuilder.Entity<PdfVinculacion>(entity =>
            {
                entity.ToTable("pdf_vinculacion", "conf");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Plazo>(entity =>
            {
                entity.ToTable("plazo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<RecintoFiscal>(entity =>
            {
                entity.ToTable("recinto_fiscal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<Regiman>(entity =>
            {
                entity.ToTable("regimen");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<Registro>(entity =>
            {
                entity.ToTable("registro", "conf");

                entity.HasComment("Distintos eventos que pueden surgir en la aplicación, como el inicio o la detención de ciertos procesos. Cada registro en la tabla \"Evento\" contiene información detallada sobre el evento, incluyendo su tipo, el momento en que ocurrió, la duración del evento, el estado de la aplicación antes y después del evento, entre otros detalles relevantes.\r\n\r\nLa tabla \"Evento\" es esencial para el monitoreo y análisis del comportamiento de la aplicación, ya que proporciona una forma de registrar y analizar los eventos clave que ocurren en el sistema. Además, esta tabla también puede utilizarse para auditar y controlar el rendimiento de la aplicación y para garantizar el cumplimiento de las políticas de seguridad y privacidad establecidas por la organización.");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("Identity");

                entity.Property(e => e.Descripcion)
                    .IsUnicode(false)
                    .HasColumnName("descripcion")
                    .HasComment("Una descripcion sobre a lo que se referira");

                entity.Property(e => e.IdColor).HasColumnName("id_color");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre")
                    .HasComment("Nombre para el tipo de registro");

                entity.Property(e => e.Nota)
                    .HasColumnType("text")
                    .HasColumnName("nota")
                    .HasComment("Una descripcion mucho mas detallada y explicativa");

                entity.HasOne(d => d.IdColorNavigation)
                    .WithMany(p => p.Registros)
                    .HasForeignKey(d => d.IdColor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_registro_color");
            });

            modelBuilder.Entity<RetencionIvaMh>(entity =>
            {
                entity.ToTable("retencion_iva_mh");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<Tabla>(entity =>
            {
                entity.ToTable("tabla", "opc");

                entity.HasComment("La ubicación lógica de los datos que se han extraído y transformado mediante el proceso ETL. Cada registro en la tabla \"Tabla\" describe una tabla específica en una base de datos y proporciona información sobre la ubicación física de los datos que se han extraído y transformado.\r\n\r\nCada registro en la tabla \"Tabla\" contiene información sobre la base de datos y la tabla de origen, así como información sobre la ubicación física de los datos transformados en el sistema de destino. Esta información se utiliza para realizar un seguimiento de los datos a lo largo del proceso ETL y para garantizar que se estén utilizando los datos correctos en el sistema de destino.\r\n\r\nLa tabla \"Tabla\" es esencial para el monitoreo y control de calidad del proceso ETL, ya que proporciona una forma de rastrear la ubicación y el origen de los datos transformados en el sistema de destino. Además, esta tabla también puede utilizarse para auditar y controlar el rendimiento del proceso ETL y para garantizar el cumplimiento de las políticas de seguridad y privacidad establecidas por la organización.");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("identity");

                entity.Property(e => e.ConexionId).HasColumnName("conexion_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre")
                    .HasComment("nombre de la tabla");

                entity.Property(e => e.NombreId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre_id");

                entity.HasOne(d => d.Conexion)
                    .WithMany(p => p.Tablas)
                    .HasForeignKey(d => d.ConexionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tabla_conexion_id");
            });

            modelBuilder.Entity<Tipado>(entity =>
            {
                entity.ToTable("tipado", "opc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TipoContingencium>(entity =>
            {
                entity.ToTable("tipo_contingencia");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.ToTable("tipo_documento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alias)
                    .HasMaxLength(5)
                    .HasColumnName("alias");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(25)
                    .HasColumnName("codigo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TipoDocumentoContingencium>(entity =>
            {
                entity.ToTable("tipo_documento_contingencia");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<TipoDocumentoIdentificacionReceptor>(entity =>
            {
                entity.ToTable("tipo_documento_identificacion_receptor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<TipoEstablecimiento>(entity =>
            {
                entity.ToTable("tipo_establecimiento");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<TipoEstado>(entity =>
            {
                entity.ToTable("tipo_estado", "opc");

                entity.HasComment("Representacion de un termino mas general para los diferentes tipos de estado que se puedenrepresentar en la base de datos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("identity");

                entity.Property(e => e.Hacienda)
                    .HasColumnName("hacienda")
                    .HasComment("booleano si la respuesta pertenece a hacienda o si simplemente es un estatus http");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre")
                    .HasComment("nombre de estado general");
            });

            modelBuilder.Entity<TipoGeneracionDocumento>(entity =>
            {
                entity.ToTable("tipo_generacion_documento");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<TipoInvalidacion>(entity =>
            {
                entity.ToTable("tipo_invalidacion");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<TipoItem>(entity =>
            {
                entity.ToTable("tipo_item");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<TipoJson>(entity =>
            {
                entity.ToTable("tipo_json", "opc");

                entity.HasComment("parseo, tipos de datos que se pueden configurar en el detalle del json");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("identity");

                entity.Property(e => e.Alias)
                    .HasMaxLength(3)
                    .HasColumnName("alias")
                    .HasComment("nombre del tipo de dato");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(25)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TipoPersona>(entity =>
            {
                entity.ToTable("tipo_persona");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<TipoServicioMedico>(entity =>
            {
                entity.ToTable("tipo_servicio_medico");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<TipoTransmision>(entity =>
            {
                entity.ToTable("tipo_transmision");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<TituloRemitenBiene>(entity =>
            {
                entity.ToTable("titulo_remiten_bienes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<Tributo>(entity =>
            {
                entity.ToTable("tributos");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Objeto).HasMaxLength(100);

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<UnidadMedidum>(entity =>
            {
                entity.ToTable("unidad_medida");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valores).HasMaxLength(250);
            });

            modelBuilder.Entity<ValorDefecto>(entity =>
            {
                entity.ToTable("valor_defecto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cabecera).HasColumnName("cabecera");

                entity.Property(e => e.Columna)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("columna");

                entity.Property(e => e.Descripcion)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.IdTipado).HasColumnName("id_tipado");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("id_tipo_documento");

                entity.Property(e => e.Valor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("valor");

                entity.HasOne(d => d.IdTipadoNavigation)
                    .WithMany(p => p.ValorDefectos)
                    .HasForeignKey(d => d.IdTipado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_valor_defecto_tipado");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.ValorDefectos)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .HasConstraintName("id_tipo_documento_valor_defecto");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
