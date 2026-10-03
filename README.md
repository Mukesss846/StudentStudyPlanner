# \# Student Study Planner \& Assignment Tracker

# 

# \*\*Author:\*\* Mukesh Singh Thakuri (S2600359)

# \*\*Unit:\*\* ITS203 Object-Oriented Design and Programming, NAPS

# 

# \## Description

# A C# Windows Forms desktop application that helps university students keep track of their assignments and plan their study sessions in one place. Instead of using a notebook, a calendar and separate apps, students can record deadlines, update their progress and see everything coming up on a single dashboard.

# 

# \## Features

# \- Add, edit and delete assignments (subject, title, due date, priority and status)

# \- Add and delete study sessions (subject, date, start time, duration and notes)

# \- Dashboard showing assignment progress (completed vs total, with a progress bar)

# \- Combined "upcoming" list of all assignments and study sessions

# \- Input validation with clear error messages (e.g. empty title, duration of 0)

# \- Data is saved automatically to JSON files and loaded again when the app starts

# 

# \## How to Run

# 1\. Clone or download this repository

# 2\. Open `StudentStudyPlanner.slnx` in Visual Studio 2022 or later

# 3\. Press F5 to build and run

# 

# \## Requirements / Setup

# \- Windows 10 or 11

# \- .NET 10 SDK with Windows Forms

# \- No database is needed. Data is stored in `assignments.json` and `sessions.json` in the same folder as the program and is created automatically on first save.

# 

# \## Project Structure

# \- `PlannerItem.cs`: abstract base class (Id, Subject, abstract GetSummary)

# \- `Assignment.cs`: assignment details, validated Title property

# \- `StudySession.cs`: study session details, validated Duration property

# \- `DataStorage.cs`: saves and loads lists as JSON

# \- `Form1.cs`: user interface and event handling

# 

# \## OOP Concepts Used

# \- \*\*Abstraction:\*\* `PlannerItem` is an abstract class with an abstract `GetSummary()` method

# \- \*\*Inheritance:\*\* `Assignment` and `StudySession` inherit `Id` and `Subject` from `PlannerItem`

# \- \*\*Polymorphism:\*\* both classes override `GetSummary()`; the dashboard loops through a `List<PlannerItem>` and calls it on each item

# \- \*\*Encapsulation:\*\* private fields with validated properties (`Assignment.Title`, `StudySession.Duration`)

# \- \*\*Exception handling:\*\* try-catch in `Form1` for invalid input (`ArgumentException`) and for loading/saving data (`JsonException`, `IOException`)

# 

# \## Project Documents

# \- \[Milestone 1 Proposal](docs/Milestone1\_Proposal\_S2600359.docx)

# 

# \## References and Tools Used

# \- Microsoft Learn documentation (C#, Windows Forms, System.Text.Json)

# \- Claude (Anthropic): step-by-step guidance, debugging help, example code for parts of the base class, dashboard and JSON storage, and help drafting this README. I integrated and tested all code and can explain how it works.

