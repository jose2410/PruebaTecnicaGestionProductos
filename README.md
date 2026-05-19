# Prueba Técnica - Gestión de Productos (Angular + .NET 8 + SQL Server)

Este proyecto corresponde a una prueba técnica donde se implementa una solución completa con:

- **Base de datos SQL Server**
- **Backend API REST en .NET 8**
- **Frontend en Angular**
- Funcionalidades:
  - Listar productos (GET)
  - Registrar productos (POST)

---

## 📂 Estructura del Proyecto

El repositorio contiene dos proyectos principales:

- `BackendProductos/` → API REST desarrollada en .NET 8
- `frontend-productos/` → Aplicación Angular (Frontend)

---

# ✅ Requisitos Previos

Antes de ejecutar el proyecto asegúrate de tener instalado:

### Base de Datos
- SQL Server (Express / Developer / Standard)
- SQL Server Management Studio (SSMS)

### Backend
- .NET SDK 8 o superior
- Visual Studio 2022 (opcional)

### Frontend
- Node.js
- Angular CLI
- Visual Studio Code (opcional)

---

# 🛠️ Versiones utilizadas en este proyecto

## Backend (.NET)
- **.NET 8**
- **ASP.NET Core Web API**

### NuGet Packages instalados
- `Microsoft.AspNetCore.OpenApi` **8.0.14**
- `Microsoft.EntityFrameworkCore.SqlServer` **8.0.27**
- `Microsoft.EntityFrameworkCore.Tools` **8.0.27**

---

## Frontend (Angular)
- **Angular CLI 21.2.11**
- **Node.js 24.15.0**
- **npm 11.12.1**

---

# 🗄️ Configuración Base de Datos (SQL Server)

1. Abrir SSMS y conectarse a la instancia de SQL Server.
2. Ejecutar el siguiente script:

```sql
CREATE DATABASE PruebaProductosDB;
GO

USE PruebaProductosDB;
GO

CREATE TABLE Productos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Precio DECIMAL(18,2) NOT NULL,
    FechaCreacion DATETIME NOT NULL
);
GO
