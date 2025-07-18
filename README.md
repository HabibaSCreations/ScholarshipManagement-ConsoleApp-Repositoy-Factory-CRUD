
# 🎓 ScholarshipManagement-ConsoleApp-Repositoy-Factory-CRUD

## 🏫 Overview
**ScholarshipManagement-ConsoleApp-Repositoy-Factory-CRUD** is a C# Console Application that demonstrates how to manage student data using Repository and Factory design patterns. The application is designed to maintain a clean, modular, and scalable architecture for handling various types of students and their data efficiently.

## 🎯 Key Features
- Implements **Repository Pattern** to abstract data access logic.
- Uses **Factory Pattern** for creating different types of student objects.
- Structured and modular codebase following **SOLID principles**.
- Easy to extend for adding new student types or logic.

## 📁 Project Structure
```
ScholarshipManagementSln/
│
├── Agreements/
│   └── IStudent.cs – Interface defining student contract
│
├── Entities/
│   └── Student.cs – Base entity for students
│
├── Enums/
│   ├── StudentType.cs – Defines types of students
│   └── StudentStatus.cs – Defines status of student (Active/Inactive)
│
├── Factory/
│   ├── BaseStudentFactory.cs – Abstract factory class
│   ├── LocalStudentFactory.cs – Factory for local students
│   └── ForeignStudentFactory.cs – Factory for foreign students
│
├── Manager/
│   ├── StudentManager.cs – Business logic for students
│   ├── LocalStudentManager.cs – Handles local student logic
│   └── ForeignStudentManager.cs – Handles foreign student logic
│
├── Repository/
│   └── StudentRepository.cs – In-memory data source for students
│
├── App.config – Application configuration
├── Program.cs – Console application entry point
└── README.md – Project documentation
```

## 🧱 Technologies Used
- C#
- .NET Console Application
- Object-Oriented Programming (OOP)
- Design Patterns: Repository, Factory

## 🚀 How to Run
1. Clone this repository:  
   ```bash
   git clone https://github.com/HabibaSCreations/ScholarshipManagement-ConsoleApp-Repositoy-Factory-CRUD.git
   ```
2. Open the solution file (`ScholarshipManagementSln.sln`) in **Visual Studio**.
3. Set the startup project if required and run the application.

## ✅ Example Output
The application will display a list of student records (local and foreign), including student details, types, and related data. The data is generated through factory classes and managed using repository patterns.

## 🧩 Extending the Application
You can easily extend this project by:
- Adding new student types in `StudentType.cs`.
- Creating new factory or manager classes inheriting from base classes.
- Connecting to an external database or API instead of in-memory data.

## 📄 License
This project is open source and available under the [MIT License](LICENSE).

---

Made with ❤️ and ⚙️ by **[HabibaSCreations](https://github.com/HabibaSCreations)** using clean architecture principles.
