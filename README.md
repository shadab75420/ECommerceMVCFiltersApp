# E-Commerce Platform with Advanced MVC Filters

## Project Name
ECommerceMVCFiltersApp

---

# Scenario Overview

This project demonstrates the implementation of Advanced MVC Filters in ASP.NET Core MVC for an E-Commerce platform.

The application includes:

- Logging Filters
- Authentication Filters
- Global Exception Handling
- Dependency Injection
- Filter Testing and Debugging

---

# User Stories

| User Story ID | Description |
|---|---|
| US-101 | Create custom filters with dependencies |
| US-102 | Implement filters for logging and error handling |
| US-103 | Test and debug custom filters |

---

# Technologies Used

- ASP.NET Core MVC
- C#
- Visual Studio
- Dependency Injection

---

# Project Structure

```text
ECommerceMVCFiltersApp
│
├── Controllers
│     └── ProductController.cs
│
├── Filters
│     ├── LoggingFilter.cs
│     ├── AuthFilter.cs
│     └── GlobalExceptionFilter.cs
│
├── Services
│     ├── LoggingService.cs
│     └── AuthService.cs
│
├── Views
│     └── Shared
│           └── Error.cshtml
│
├── Program.cs
│
└── appsettings.json
```

---

# Features Implemented

## 1. Logging Filter

The logging filter records:

- HTTP Request Method
- Request URL
- Response Status Code

This helps monitor incoming requests and outgoing responses.

---

## 2. Authentication Filter

The authentication filter checks whether the user is logged in before accessing protected pages.

It restricts unauthorized access to secure sections of the application.

---

## 3. Global Exception Filter

The global exception filter:

- Catches unhandled exceptions
- Logs error details
- Displays a user-friendly error page

This improves application stability and user experience.

---

## 4. Dependency Injection

All services and filters are managed using Dependency Injection for better modularity and maintainability.

---

# Controllers

## Product Controller

The Product Controller demonstrates:

- Product Listing
- Product Details
- Exception Testing

Filters are applied to this controller for logging and authentication.

---

# Example URLs

| URL | Description |
|---|---|
| /Product/Index | Product List Page |
| /Product/Details | Product Details Page |
| /Product/ErrorTest | Tests Global Exception Filter |

---

# Error Handling

When an exception occurs, the application redirects to a user-friendly error page instead of crashing.

---

# Testing and Debugging

The application verifies:

- Logging functionality
- Authentication checks
- Exception handling
- Filter execution
- Dependency Injection integration

---

# Best Practices Followed

- Reusable filter structure
- Proper dependency injection
- Centralized error handling
- Clean project organization
- Secure access management
- Modular service implementation

---

# Assignment Outcome

This project successfully demonstrates advanced MVC Filters in ASP.NET Core MVC including:

- Logging Filters
- Authentication Filters
- Global Exception Filters
- Dependency Injection
- Error Handling
- Filter Testing and Debugging

The implementation improves maintainability, security, monitoring, and exception management within the e-commerce platform.
