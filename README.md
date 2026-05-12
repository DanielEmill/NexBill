<div align="center">

# 🚀 NexBill

### Sistema moderno de gestión de pagos recurrentes y facturación

Desarrollado con **C#**, **.NET 10**, **WinForms** y **Entity Framework Core**

</div>

---

# 📌 Descripción General

NexBill es una aplicación de escritorio diseñada para automatizar la gestión de pagos recurrentes, balances pendientes y facturación de clientes.

El sistema permite:

✅ Registrar clientes  
✅ Crear contratos recurrentes  
✅ Generar facturas automáticamente  
✅ Registrar pagos y abonos parciales  
✅ Controlar balances pendientes  
✅ Mantener historial financiero organizado  

---

# ✨ Funcionalidades Principales

## 👥 Gestión de Clientes

- Crear clientes
- Editar clientes
- Eliminar clientes
- Buscar clientes
- Historial de clientes

---

## 📄 Gestión de Contratos

- Contratos recurrentes
- Frecuencia:
  - Mensual
  - Semanal
  - Quincenal
- Configuración de intereses
- Suspensión y cancelación

---

## 💸 Facturación Automática

- Generación automática de cuotas
- Facturas pendientes/pagadas
- Acumulación automática de deuda
- Balance actualizado automáticamente

---

## 💰 Gestión de Pagos

- Registro manual de pagos
- Abonos parciales
- Historial de pagos
- Control automático de balances

---

## 📊 Reportes

- Clientes con deuda
- Facturas pendientes
- Resumen mensual
- Historial financiero

---

# 🏗 Arquitectura

El proyecto sigue una arquitectura limpia (**Clean Architecture**) para facilitar mantenimiento, escalabilidad y organización del código.

```txt
NexBill.sln
│
├── NexBill.UI
├── NexBill.Application
├── NexBill.Domain
└── NexBill.Infrastructure
```

---

# 📂 Estructura de Capas

| Capa | Responsabilidad |
|------|----------------|
| 🖥 UI | Interfaz de usuario |
| ⚙️ Application | Lógica de negocio |
| 🧠 Domain | Entidades y reglas |
| 🗄 Infrastructure | Base de datos y EF Core |

---

# 🛠 Tecnologías Utilizadas

<div align="center">

| Tecnología | Uso |
|------------|-----|
| C# | Lenguaje principal |
| .NET 10 | Framework |
| Windows Forms | Interfaz de escritorio |
| Entity Framework Core | ORM |
| SQLite | Base de datos local |
| Dependency Injection | Inyección de dependencias |

</div>

---

# 🧩 Modelo Base de Datos

## Clientes

```txt
Id
Nombre
Teléfono
Dirección
Estado
FechaRegistro
```

## Contratos

```txt
Id
ClienteId
Monto
Frecuencia
FechaCorte
Interés
Estado
```

## Facturas

```txt
Id
ContratoId
FechaGenerada
FechaVencimiento
Monto
Balance
Estado
```

## Pagos

```txt
Id
FacturaId
MontoPagado
FechaPago
MétodoPago
```

---


---

# 🎯 Objetivo

Automatizar la administración de cobros recurrentes y balances pendientes de manera simple, moderna y escalable.

---

# 🔮 Planes Futuros

- 🔐 Sistema de autenticación
- 👥 Multiusuario
- ☁️ Sincronización en la nube
- 📱 Aplicación móvil
- 🌐 API REST con ASP.NET Core
- 📈 Dashboard administrativo
- 🔔 Notificaciones y recordatorios

---

# 👨‍💻 Autor

<div align="center">

### Emill Daniel

Ingeniero en Sistemas • .NET Developer

</div>

---

<div align="center">

### ⭐ Proyecto en desarrollo ⭐

</div>
