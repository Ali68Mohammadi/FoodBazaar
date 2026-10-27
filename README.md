# 🍔 FoodBazaar

A full-stack food ordering and management web application built with **ASP.NET Core (Blazor Server)**. 
The application directly communicates with a SQL Server database using Entity Framework Core, following the Repository Pattern for clean data access.

## 🚀 Key Features

- **Product & Category Management:** Complete CRUD operations.
- **Modern UI/UX:** Built with Bootstrap 5, featuring Toastr notifications and Bootstrap Modals for safe delete confirmations.
- **Image Handling:** Secure file upload and management for product images.
- **Server-Side Interaction:** Real-time UI updates using Blazor Server and SignalR.

## 🛠️ Tech Stack

- **Framework:** .NET 10 (ASP.NET Core & Blazor Server)
- **Database:** SQL Server, Entity Framework Core
- **Patterns:** Repository Pattern, Dependency Injection
- **Frontend:** HTML, CSS, Bootstrap 5, Bootstrap Icons, Bootastrap Modal, Javascript
- **Libraries:** Toastr.js (for notifications)

## 📁 Project Structure

- **FoodBazaar.Data:** EF Core DbContext and Migrations.
- **FoodBazaar.Repository:** Data access layer implementing the Repository Pattern.
- **FoodBazaar.Services:** Application services (e.g., file handling, extensions).
- **FoodBazaar.Utility:** Helper classes and constants (e.g., Role names).
- **FoodBazaar.ViewModels:** Models used for data transfer and form validation.
- **FoodBazaar.Components:** Blazor components (Pages, Shared, Layouts).


1. **Clone the repository:**
   ```bash
   git clone https://github.com/Ali68Mohammadi/FoodBazaar.git
