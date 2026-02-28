CoreSpace by Kinga Kostecka 99730

EN
# CoreSpace | Enterprise Room Reservation System

CoreSpace is a cloud-native, 3-tier web application designed for efficient management of corporate meeting spaces and resources. Inspired by enterprise-grade EMS (Enterprise Management Systems), it simplifies the booking process for internal and client meetings.

## ☁️ Architecture & Azure Mapping
The project is built with a **Cloud-First** approach, leveraging Azure's Platform as a Service (PaaS) offerings for scalability and maintainability.

| Layer | Local Component | Azure Service |
| :--- | :--- | :--- |
| **Presentation (Frontend)** | React 19 (Vite) | Azure Static Web Apps |
| **Application (Backend)** | ASP.NET Core Web API (.NET 9) | Azure App Service |
| **Data (Database)** | SQL Server (Docker) | Azure SQL Database (Serverless) |
| **Identity & Security** | JWT / Local Auth | Microsoft Entra ID (Planned) |

## 🚀 Key Features (MVP)
* **Resource Management:** Full CRUD operations for meeting rooms (capacity, equipment, location).
* **Real-time Availability:** Smart filtering and booking validation to prevent scheduling conflicts.
* **User Roles:** Distinct permissions for standard employees and office administrators.
* **Cloud Integration:** Ready for seamless deployment via Azure DevOps/GitHub Actions.

## 🏗 Project Roadmap
* [x] **Phase 1:** Project initialization, architecture design, and C4 diagrams.
* [X] **Phase 2:** Dockerization and local environment setup.
* [ ] **Phase 3:** Backend API development (Core logic & DB migrations).
* [ ] **Phase 4:** Frontend implementation and Azure deployment.

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

## 🛠 Stos Technologiczny
* **Frontend:** React + TypeScript + Vite
* **Backend:** .NET 9 Web API (C#)
* **Baza danych:** Azure SQL (Entity Framework Core)
* **Infrastruktura:** Docker, GitHub Actions

---
> **Informacja:** Ten plik będzie aktualizowany wraz z postępem prac. Wkrótce pojawi się sekcja 'Instrukcja uruchomienia lokalnego'.