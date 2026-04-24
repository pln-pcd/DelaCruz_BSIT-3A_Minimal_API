# Product Management System API

**Student:** Paulina C. Dela Cruz  
**Section:** BSIT-3A  
**Course:** Web API Development  

---

## Overview

A RESTful API built with **ASP.NET Core** and **Entity Framework Core** that manages a simple Product Management System. The API connects to a **SQL Server** database and exposes full CRUD operations for four models.

---

## Models

### Product
| Field | Type |
|---|---|
| Id | int |
| Name | string |
| Price | decimal |
| CategoryId | int (FK) |
| SupplierId | int (FK) |

### Category
| Field | Type |
|---|---|
| Id | int |
| Name | string |
| Description | string |

### Supplier
| Field | Type |
|---|---|
| Id | int |
| Name | string |
| ContactEmail | string |
| Phone | string |

### Customer
| Field | Type |
|---|---|
| Id | int |
| FullName | string |
| Email | string |
| Phone | string |
| Address | string |

---

## Relationships

- One **Category** can have many **Products**
- One **Supplier** can have many **Products**
- One **Product** belongs to one **Category**
- One **Product** belongs to one **Supplier**
- **Customer** is independent

---

## Technologies Used

- ASP.NET Core 8.0
- Entity Framework Core 8.0
- SQL Server
- Swagger / OpenAPI

---

## How to Run

### 1. Clone the repository
```bash
git clone https://github.com/your-username/DelacruzP_BSIT3A_Minimal_API.git
cd DelacruzP_BSIT3A_Minimal_API
```

### 2. Update the database
```bash
dotnet ef database update
```

### 3. Run the API
```bash
dotnet run
```

### 4. Open Swagger
```
http://localhost:5233/swagger
```

---

## API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | /api/products | Get all products |
| GET | /api/products/{id} | Get product by ID |
| POST | /api/products | Create a product |
| PUT | /api/products/{id} | Update a product |
| DELETE | /api/products/{id} | Delete a product |
| GET | /api/categories | Get all categories |
| GET | /api/categories/{id} | Get category by ID |
| POST | /api/categories | Create a category |
| PUT | /api/categories/{id} | Update a category |
| DELETE | /api/categories/{id} | Delete a category |
| GET | /api/suppliers | Get all suppliers |
| GET | /api/suppliers/{id} | Get supplier by ID |
| POST | /api/suppliers | Create a supplier |
| PUT | /api/suppliers/{id} | Update a supplier |
| DELETE | /api/suppliers/{id} | Delete a supplier |
| GET | /api/customers | Get all customers |
| GET | /api/customers/{id} | Get customer by ID |
| POST | /api/customers | Create a customer |
| PUT | /api/customers/{id} | Update a customer |
| DELETE | /api/customers/{id} | Delete a customer |

