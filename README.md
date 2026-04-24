# Quantum Car Factory - Fawry Internship Challenge 🚗💨

This repository contains my solution for the **Fawry Quantum Internship Challenge**. The project demonstrates a flexible car manufacturing system using **C#** and **Object-Oriented Programming (OOP)** principles.

## 📌 Project Overview
The "Quantum Car" project is a simulation of a car factory where cars can have different engine types (Gas, Electric, or Hybrid). The design focuses on high flexibility, allowing engines to be replaced easily and ensuring cost-optimized performance for hybrid models.

## 🛠️ Key Features
- **Engine Interchangeability:** Engines can be swapped at any time as long as the car is at zero speed.
- **Mixed Hybrid Logic:** A smart hybrid engine that switches between electric and gasoline components based on speed (Threshold: 50 km/h) for cost optimization.
- **Factory Pattern:** Implementation of a `CarFactory` to manage car creation and engine replacement.
- **Type Safety:** Used `Enums` for engine types to prevent errors and ensure clean code.
- **Strategy-like Design:** The car "advises" the engine of speed changes, allowing the engine to manage its internal state.

## 📊 Class Diagram (UML)
Below is the architectural design of the system:

<img width="4032" height="5670" alt="uml diagram" src="https://github.com/user-attachments/assets/cfc04812-4037-4263-8fcd-ce1467d9d6ad" />

## 🚀 How it Works
1. **Start:** Car starts at 0 speed.
2. **Accelerate:** Increases speed by 20 km/h (Max 200 km/h).
3. **Brake:** Decreases speed by 20 km/h.
4. **Hybrid Logic:** - Speed < 50 km/h → **ElectronicEngine**
   - Speed >= 50 km/h → **GasolineEngine**

## 💻 Technologies Used
- C#
- OOP Principles (Inheritance, Polymorphism, Encapsulation)
- Factory Design Pattern

## 📝 Notes
- This solution adheres to the "Simple Design" constraint while maintaining professional code standards.
- All engine operations (`Increase`, `Decrease`, `UpdateSpeed`) are fully implemented and synchronized.
