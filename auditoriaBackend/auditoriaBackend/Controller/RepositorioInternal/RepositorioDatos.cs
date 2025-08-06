using System;
using System.Collections.Generic;

public class RepositorioDatos
{
    private static readonly Lazy<RepositorioDatos> instancia = new Lazy<RepositorioDatos>(() => new RepositorioDatos());
    public static RepositorioDatos Instancia => instancia.Value;

    private RepositorioDatos() { }

    public List<Ubicacion> ListaUbicacions { get; } = new List<Ubicacion>
    {
        new Ubicacion { IdUbicacion = 1, Nombre = "Campus Central" },
        new Ubicacion { IdUbicacion = 2, Nombre = "Campus Norte" },
        new Ubicacion { IdUbicacion = 3, Nombre = "Campus Sur" },
        new Ubicacion { IdUbicacion = 4, Nombre = "Campus Este" },
    };

    public List<Facultad> ListaFacultads { get; } = new List<Facultad>
    {
        new Facultad { IdFacultad = 1, Nombre = "Ingeniería" },
        new Facultad { IdFacultad = 2, Nombre = "Ciencias Económicas" },
        new Facultad { IdFacultad = 3, Nombre = "Salud" },
        new Facultad { IdFacultad = 4, Nombre = "Artes" },
    };

    public List<Departamento> ListaDepartamentos { get; } = new List<Departamento>
    {
        new Departamento { IdDepartamento = 1, Nombre = "Sistemas" },
        new Departamento { IdDepartamento = 2, Nombre = "Contabilidad" },
        new Departamento { IdDepartamento = 3, Nombre = "Enfermería" },
        new Departamento { IdDepartamento = 4, Nombre = "Música" },
    };

    public List<Rol> ListaRols { get; } = new List<Rol>
    {
        new Rol { IdRol = 1, Nombre = "Administrador" },
        new Rol { IdRol = 2, Nombre = "Supervisor" },
        new Rol { IdRol = 3, Nombre = "Auditor" },
        new Rol { IdRol = 4, Nombre = "Usuario" },
    };

    public List<Persona> ListaPersonas { get; } = new List<Persona>
    {
        new Persona { IdPersona = 1, Nombre = "Ana Pérez", Correo = "ana.perez@ejemplo.com", IdRol = 1 },
        new Persona { IdPersona = 2, Nombre = "Luis Gómez", Correo = "luis.gomez@ejemplo.com", IdRol = 2 },
        new Persona { IdPersona = 3, Nombre = "Sofía Díaz", Correo = "sofia.diaz@ejemplo.com", IdRol = 3 },
        new Persona { IdPersona = 4, Nombre = "Carlos Ruiz", Correo = "carlos.ruiz@ejemplo.com", IdRol = 4 },
    };

    public List<Seccion> ListaSeccions { get; } = new List<Seccion>
    {
        new Seccion { IdSeccion = 1, Nombre = "Infraestructura" },
        new Seccion { IdSeccion = 2, Nombre = "Seguridad" },
        new Seccion { IdSeccion = 3, Nombre = "Limpieza" },
        new Seccion { IdSeccion = 4, Nombre = "Equipamiento" },
    };

    public List<Pregunta> ListaPreguntas { get; } = new List<Pregunta>
    {
        new Pregunta { IdPregunta = 1, Texto = "¿Las instalaciones están limpias?", IdSeccion = 3 },
        new Pregunta { IdPregunta = 2, Texto = "¿Se cuenta con salidas de emergencia?", IdSeccion = 2 },
        new Pregunta { IdPregunta = 3, Texto = "¿Los equipos están operativos?", IdSeccion = 4 },
        new Pregunta { IdPregunta = 4, Texto = "¿El edificio presenta daños estructurales?", IdSeccion = 1 },
    };

    public List<Item> ListaItems { get; } = new List<Item>
    {
        new Item { IdItem = 1, Descripcion = "Pisos limpios", IdPregunta = 1 },
        new Item { IdItem = 2, Descripcion = "Extintores disponibles", IdPregunta = 2 },
        new Item { IdItem = 3, Descripcion = "Computadoras funcionales", IdPregunta = 3 },
        new Item { IdItem = 4, Descripcion = "Paredes sin grietas", IdPregunta = 4 },
    };

    public List<Auditoria> ListaAuditorias { get; } = new List<Auditoria>
    {
        new Auditoria { IdAuditoria = 1, Titulo = "Auditoría General 2025", IdUbicacionInstitucional = 1, Fecha = new DateTime(2025, 8, 1) },
        new Auditoria { IdAuditoria = 2, Titulo = "Revisión de Seguridad", IdUbicacionInstitucional = 2, Fecha = new DateTime(2025, 8, 2) },
        new Auditoria { IdAuditoria = 3, Titulo = "Inspección de Equipos", IdUbicacionInstitucional = 3, Fecha = new DateTime(2025, 8, 3) },
        new Auditoria { IdAuditoria = 4, Titulo = "Control de Limpieza", IdUbicacionInstitucional = 4, Fecha = new DateTime(2025, 8, 4) },
    };

    public List<Encuesta> ListaEncuestas { get; } = new List<Encuesta>
{
    new Encuesta { IdEncuesta = 1, IdAuditoria = 1, IdPersona = 1, FechaRealizacion = new DateTime(2025, 8, 1) },
    new Encuesta { IdEncuesta = 2, IdAuditoria = 2, IdPersona = 2, FechaRealizacion = new DateTime(2025, 8, 2) },
    new Encuesta { IdEncuesta = 3, IdAuditoria = 3, IdPersona = 3, FechaRealizacion = new DateTime(2025, 8, 3) },
    new Encuesta { IdEncuesta = 4, IdAuditoria = 4, IdPersona = 4, FechaRealizacion = new DateTime(2025, 8, 4) },
};

    public List<Respuesta> ListaRespuestas { get; } = new List<Respuesta>
{
    new Respuesta { IdRespuesta = 1, IdEncuesta = 1, IdItem = 1, Marcado = true, PorcentajeCumplimiento = "100%" },
    new Respuesta { IdRespuesta = 2, IdEncuesta = 1, IdItem = 2, Marcado = false, PorcentajeCumplimiento = "50%" },
    new Respuesta { IdRespuesta = 3, IdEncuesta = 2, IdItem = 3, Marcado = true, PorcentajeCumplimiento = "90%" },
    new Respuesta { IdRespuesta = 4, IdEncuesta = 2, IdItem = 4, Marcado = false, PorcentajeCumplimiento = "60%" },
};

    public List<Seguimiento> ListaSeguimientos { get; } = new List<Seguimiento>
{
    new Seguimiento
    {
        IdSeguimiento = 1,
        IdRespuesta = 1,
        Estado = "En proceso",
        Descripcion = "Revisión de limpieza en curso",
        Supervisor = "Luis Gómez",
        ResponsableTratamiento = "Carlos Ruiz",
        ResponsableImplementacion = "Ana Pérez",
        Evidencia = "Foto de pisos",
        FechaInicio = new DateTime(2025, 8, 5),
        FechaFin = new DateTime(2025, 8, 10),
        ObservacionEstado = "Se está limpiando el área"
    },
    new Seguimiento
    {
        IdSeguimiento = 2,
        IdRespuesta = 2,
        Estado = "Pendiente",
        Descripcion = "No se encontraron extintores",
        Supervisor = "Sofía Díaz",
        ResponsableTratamiento = "Luis Gómez",
        ResponsableImplementacion = "Carlos Ruiz",
        Evidencia = "Informe de inspección",
        FechaInicio = new DateTime(2025, 8, 6),
        FechaFin = new DateTime(2025, 8, 12),
        ObservacionEstado = "Falta adquisición"
    },
    new Seguimiento
    {
        IdSeguimiento = 3,
        IdRespuesta = 3,
        Estado = "Completado",
        Descripcion = "Equipos revisados y funcionando",
        Supervisor = "Ana Pérez",
        ResponsableTratamiento = "Sofía Díaz",
        ResponsableImplementacion = "Luis Gómez",
        Evidencia = "Informe técnico",
        FechaInicio = new DateTime(2025, 8, 1),
        FechaFin = new DateTime(2025, 8, 3),
        ObservacionEstado = "Todo conforme"
    },
    new Seguimiento
    {
        IdSeguimiento = 4,
        IdRespuesta = 4,
        Estado = "En revisión",
        Descripcion = "Daños estructurales en análisis",
        Supervisor = "Carlos Ruiz",
        ResponsableTratamiento = "Ana Pérez",
        ResponsableImplementacion = "Sofía Díaz",
        Evidencia = "Fotos de grietas",
        FechaInicio = new DateTime(2025, 8, 2),
        FechaFin = new DateTime(2025, 8, 7),
        ObservacionEstado = "Esperando peritaje"
    },
};

}
