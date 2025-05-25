# 🧾 Company Portal – CMS + E-commerce System

A comprehensive ASP.NET Core MVC project combining a CMS with a simple internal product ordering system. Divided into a public-facing portal (`PortalWWW`) and an admin dashboard (`Intranet`), the project supports content management, product orders, and full CRUD operations.

---

## 🔧 Technologies Used

- **Framework:** ASP.NET Core MVC (.NET 8)
- **Database:** SQL Server with Entity Framework Core (EF Core)
- **Frontend:** Razor Views, Bootstrap 5, Responsive Design
- **Icons:** Bootstrap Icons, Unicons
- **Tools:** EF Core Migrations, Data Seeding

---

## 🌐 Public Portal Features (`PortalWWW`)

- Dynamic **homepage news** loaded from the database
- Navigation & footer texts retrieved from a `ContentText` database table
- Product views by category: **Mac**, **iPhone**, **iPad**, **Watch**
- Order overview with styled **cart display**
- Contact form for **Support**
- Fully responsive interface for all devices

---

## 🔐 Admin Dashboard Features (`Intranet`)

- Full **CRUD operations** for:
  - News
  - Pages (CMS)
  - Products
  - Users
  - Orders (linked to products)
  - Reports
  - Support
- Relational data: e.g. Orders include selected Product
- Auto-generated order number and default values
- Input validation using `DataAnnotations`

---

## ✨ Key Highlights

- Dynamic content (e.g. menu items, footer links) managed from the database
- Modular architecture: multiple projects within a single solution
- Consistent, mobile-friendly UI with icons and modern styling
- Effective use of EF Core: migrations, seeding, relationships

---

## 🚀 Getting Started

1. Clone the repository
2. Configure your database connection string in `appsettings.json`
3. Run EF Core migrations:

4. Launch the solution

---

## 📂 Project Structure

- `Firma.PortalWWW` – Public-facing website
- `Firma.Intranet` – Admin dashboard
- `Firma.Data` – Data models, DbContext, and configuration

---

## 📄 License

This project is for educational and portfolio purposes.

