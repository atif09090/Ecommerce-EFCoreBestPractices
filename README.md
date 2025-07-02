# 🛒 SmartCart – Order Management API

---

A real-world .NET API project demonstrating **smart and efficient usage of Entity Framework Core (EF Core)**. This project avoids beginner-level mistakes and applies best practices for performance, scalability, and maintainability in a production-grade system.

---

## 📌 Features

- Users, Orders, Products, and Order Items domain models
- Efficient data access using EF Core
- Eager loading to prevent the N+1 problem
- Pagination with `Skip()` / `Take()`
- Optimized read-only queries with `AsNoTracking()`
- Database-level filtering
- Indexing for performance-critical queries

---

## 🧱 Tech Stack

- **.NET 8**
- **Entity Framework Core**
- **SQL Server** (can be swapped for other providers)
- **Minimal API (ASP.NET Core)**

---

### 🧠 EF Core Best Practices Used

✅ Filter queries at the database level
✅ Use eager loading with Include()
✅ Prevent N+1 query issues
✅ Implement pagination
✅ Use AsNoTracking() for read-only operations
✅ Add indexes via Fluent API
✅ Avoid fetching unnecessary data

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- SQL Server or any EF Core-supported database
- Visual Studio or VS Code

### Setup

1. Clone the repository:

```bash
git clone https://github.com/your-username/smartcart-api.git
cd smartcart-api

---
