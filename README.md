# SOAP - Gestión de Disponibilidad

## Requisitos Previos

Antes de ejecutar el SOAP, asegúrate de cumplir con los siguientes requisitos:

1. **.NET 8 SDK**: Asegúrate de tener instalado .NET 8 en tu computadora. Puedes descargarlo desde [aquí](https://dotnet.microsoft.com/download/dotnet/8.0).
2. **Base de Datos**: Se requiere que ejecutes el script SQL para crear la tabla `Availability` antes de ejecutar el servicio SOAP.
3. **Cadena de Conexión**: Actualiza la cadena de conexión en el archivo appsettings.json para que apunte a tu base de datos local.

## Configuración de la Base de Datos

Ejecuta el script SQL incluido en este repositorio para configurar la base de datos. Este script crea la tabla `Availability` necesaria para que la API funcione correctamente.

1. Abre tu herramienta de gestión de bases de datos (como SQL Server Management Studio).
2. Abre el docuemtno en el aula virtual y pega el script que se encuentra al final del docuemnto y ejecutalo.
