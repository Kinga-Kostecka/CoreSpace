CoreSpace by Kinga Kostecka 99730

# CoreSpace | Enterprise Room Reservation System
**Student:** Kinga Kostecka | **ID:** 99730

---

## EN (English Version)

CoreSpace is a cloud-native, 3-tier web application designed for efficient management of corporate meeting spaces. The system allows users to browse availability and book rooms in real-time, leveraging modern cloud architecture.

### ☁️ Architecture & Azure Mapping
The project follows the **PaaS (Platform as a Service)** model for high scalability and cost-efficiency.

| Layer | Local Component | Azure Service | Status |
| :--- | :--- | :--- | :--- |
| **Presentation** | React 19 (Vite) | Azure Static Web Apps | ✅ Dockerized |
| **Application** | ASP.NET Core (.NET 9) | Azure App Service | ✅ Dockerized |
| **Data** | EF Core / SQL Server | Azure SQL (Serverless) | ✅ Connected |

### 🚀 Key Features (Artifact 4 Update)
* **Live API:** Fully functional REST API with CRUD operations for Reservations.
* **Database Integration:** Seamless connection with Azure SQL Database.
* **Modern UI:** Interactive Dashboard built with React and TypeScript.
* **Containerization:** Orchestrated with Docker Compose for consistent environments.

### 🏗 Project Roadmap
* [x] **Phase 1:** C4 diagrams and architecture design.
* [x] **Phase 2:** Docker Compose environment setup.
* [x] **Phase 3:** Backend API & Azure SQL Database integration.
* [x] **Phase 4:** Frontend Dashboard & Validation logic.
* [x] **Phase 5:** Advanced Features (Building/Room selection, Auth, Azure Deployment).

### 🛠 Quick Start (Docker)
```bash
docker-compose up --build
```

## 🛠 Tech Stack
* **Frontend:** React, TypeScript, Vite, Tailwind CSS / MUI
* **Backend:** C#, .NET 9 Web API, Entity Framework Core
* **Infrastructure:** Docker, Docker Compose, GitHub Actions
* **Cloud:** Microsoft Azure

---
*This project is part of a semester-long Cloud Computing course. It focuses on clean code, iterative development, and professional cloud architecture.*



--------------------------------------------------------------------------------------------
PL
# CoreSpace - Corporate Room Reservation System
 
Projekt natywnej aplikacji chmurowej realizowany w architekturze 3-warstwowej, inspirowany systemami klasy EMS.

## ☁️ Deklaracja Architektury (Mapowanie Azure)
Aplikacja została zaprojektowana w modelu PaaS (Platform as a Service), co zapewnia skalowalność i łatwość wdrożenia.

| Warstwa | Komponent Lokalny | Usługa Azure |
| :--- | :--- | :--- |
| **Presentation (Frontend)** | React 19 (Vite) | Azure Static Web Apps |
| **Application (Backend)** | ASP.NET Core Web API (.NET 9) | Azure App Service |
| **Data (Baza danych)** | SQL Server / Docker | Azure SQL Database (Serverless) |
| **Identity (Opcjonalnie)** | Local Auth | Microsoft Entra ID (Azure AD) |

## 🏗 Status Projektu
* [x] **Deklaracja tematu:** CoreSpace - System rezerwacji sal konferencyjnych.
* [x] **Artefakt 1:** Zaplanowano strukturę 3-warstwową i mapowanie usług Azure.
* [X] **Artefakt 2:** Konfiguracja środowiska Docker & Docker Compose.
* [X] **Artefakt 3:** Warstwa prezentacji (React +Vite)
* [X] **Artefakt 4:** Logika backendu (.NET 9 + Azure SQL).
* [X] **Artefakt 5:** Przygotowanie systemu pod wdrozenie w chmurze (w moim projekcie juz od poczatku pracy nad projektem wdrozenie istnialo)
* [X] **Artefakt 6:** Wdrozenie do Azure (gotowe częściowo na wczesniejszym etapie)

## 🛠 Stos Technologiczny
* **Frontend:** React + TypeScript + Vite
* **Backend:** .NET 9 Web API (C#)
* **Baza danych:** Azure SQL (Entity Framework Core)
* **Infrastruktura:** Docker, GitHub Actions

---
> **Informacja:** Ten plik będzie aktualizowany wraz z postępem prac. Wkrótce pojawi się sekcja 'Instrukcja uruchomienia lokalnego'.