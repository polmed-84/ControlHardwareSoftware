# Sistema de Gestión de Hardware y Software (S.G.H.S)

Este proyecto es una solución integral desarrollada en **Blazor Web App** para el control y administración de activos tecnológicos, licencias y mantenimientos preventivos/correctivos dentro de una organización.

## 👥 Elaborado por:

El desarrollo de este sistema fue realizado por el equipo de Ingeniería de Sistemas integrado por:

*   **Eliazar Salomón Polanco Medina**
*   **Evert Isaí Amador Martínez**
*   **Isaac David Ramirez Zamora**

---

## 🚀 Características Principales

- **Gestión de Equipos:** Inventario detallado de hardware, asignación de usuarios y áreas físicas.
- **Control de Software:** Catálogo de programas instalados, gestión de licencias y seriales.
- **Historial de Actualizaciones:** Registro cronológico de cambios de versiones por equipo.
- **Gestión de Mantenimientos:** Seguimiento de reparaciones, servicios técnicos y costos asociados.
- **Reportes Dinámicos:** Generación de informes de inventario y gastos en formato PDF.
- **Interfaz Moderna:** Diseño responsivo utilizando Bootstrap 5 y Bootstrap Icons.

## 🛠️ Tecnologías Utilizadas

- **Frontend:** Blazor (Server-side) .NET 8
- **Backend:** Entity Framework Core
- **Base de Datos:** Microsoft SQL Server
- **Estilos:** Bootstrap 5 & CSS3
- **Iconografía:** Bootstrap Icons (SVG)



## ⚙️ Configuración del Proyecto

1. **Base de Datos:** Ejecutar el script SQL proporcionado en la documentación para crear las tablas y datos de prueba.
2. **Connection String:** Actualizar el archivo `appsettings.json` con las credenciales de su servidor local de SQL Server:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=TU_SERVIDOR;Database=ControlHardwareSoftware;Trusted_Connection=True;TrustServerCertificate=True;"
   }
   ```
3. **Ejecución:** Abrir la solución en Visual Studio 2022 y presionar `F5`.

---
© 2026 - Proyecto Académico de Ingeniería
