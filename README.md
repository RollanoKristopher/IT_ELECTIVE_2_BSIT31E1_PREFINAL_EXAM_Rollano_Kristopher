# Kristopher Rj Rollano &mdash; IT Elective 2 (BSIT31E1)

**Name:** Kristopher Rj Rollano
**Class / Subject:** IT Elective 2 &mdash; Web System and Technologies
**Section:** BSIT31E1

---

## 📟 SYSTEM.MVC — Prefinal Exam Terminal

A retro CRT-terminal-themed **ASP.NET Core MVC** web app that displays all 20
multiple-choice questions from the IT Elective 2 Prefinal Examination
(ASP.NET Core MVC + Entity Framework Core topics), along with my chosen
answer for each item. No database is used — the questions and answers live
in an in-memory `List<ExamQuestion>` (see `Data/ExamData.cs`), per the exam
requirements.

Each question is rendered as a glowing green "log entry" on a scanline CRT
background. Clicking `> RUN answer.exe` reveals the answer inline, or you can
open a full-screen "record" view for any single question.

### 🖥️ Tech / Architecture (MVC)

| Layer | File(s) |
|---|---|
| **Model** | `Models/ExamQuestion.cs` |
| **Data (in-memory, no DB)** | `Data/ExamData.cs` |
| **Controllers** | `Controllers/HomeController.cs`, `Controllers/ExamController.cs` |
| **Views** | `Views/Home/Index.cshtml` (full log), `Views/Exam/Details.cshtml` (single record) |
| **Theme** | `wwwroot/css/terminal.css`, `wwwroot/js/terminal.js` |

### ▶️ How to run

```bash
cd ExamMVC
dotnet restore
dotnet run
```

Then open the URL shown in the console (e.g. `https://localhost:5001`).

### 📋 Coverage

All 20 items from the exam's Multiple Choice section (ASP.NET Core MVC,
Entity Framework Core, DbContext, migrations, relationships, ViewModels,
validation, and error handling) are answered inside the app.

### 🗂️ Commit history

This repository was built with one commit per exam question answered
(Q1 → Q20), plus setup and documentation commits, for a minimum of 20 commits
as required by the exam instructions.
