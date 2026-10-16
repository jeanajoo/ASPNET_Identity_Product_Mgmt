**ASP.NET Core MVC Identity & Product Management System**

An enterprise-grade role-based access control (RBAC) and product catalog administration platform built in C# using ASP.NET Core 8.0 MVC, ASP.NET Core Identity, and Entity Framework Core. 

**Project Overview**

The Identity & Product Management application provides a secure, administrative interface for managing user authentication, authorization roles, and inventory catalogs. By integrating ASP.NET Core Identity with Entity Framework Core, the platform enforces strict security boundaries between standard customers, administrative staff, and system managers while managing complex relational product schemas.

Tech Stack & Architecture
- Backend: C#, ASP.NET Core 8.0 MVC
- Authentication & Authorization: ASP.NET Core Identity (Role-Based Access Control)
- ORM & Database: Entity Framework Core (Code-First), Azure SQL Database / Microsoft SQL Server
- Frontend: Razor Views, HTML5, CSS3, Bootstrap 5
- Tools & Environment: Visual Studio, Git & GitHub, Azure App Service

Key Features & System ArchitectureRole-Based Access Control (RBAC) & Security
- Multi-Tier Authorization: Implements granular user roles (Customers, Employees, Managers) restricting access to administrative controllers and sensitive views.
- Identity Workflow: Secure user registration, password hashing, account lockout policies, claims-based authorization, and profile management.
- Administrative User Management: Enables managers to modify user roles, activate or disable accounts, and adjust permissions without database intervention.

Relational Product Catalog Administration
- Full CRUD Functionality: Complete Create, Read, Update, and Delete capabilities across multi-entity product catalogs, categories, and inventory items.
- Data Annotations & Validation: Model-level validation enforcing pricing bounds, required attributes, dynamic field formatting, and concurrent edit protections.
- Soft Delete Architecture: Implements status flags to prevent orphan records and retain audit histories when items or accounts are deactivated.
