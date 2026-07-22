# 🏆 Achievement Unlocked!

A tiny, self-contained **.NET 10 web app**: an addictive achievement/clicker game with a slick gold-on-dark theme, toast pop-ups, confetti, and a trophy case. Click the big button, rack up clicks, and unlock 17+ achievements.

It's also the sample app used in the **"Building & Using MCP Servers in Visual Studio"** talk to demo multiple MCP servers working together.

## ✨ Features

- **One big button.** Click it. Good things happen.
- **17+ achievements** — First Click, Speed Demon, Night Owl, Completionist, and more — with confetti and toast celebrations.
- **Trophy case** with a live progress bar.
- **💾 Save Your Progress signup** *(on the `feature/save-progress-signup` branch)* — create an account to save your trophy case and sync across devices, backed by [FluentValidation](https://docs.fluentvalidation.net/). Unlocking it earns the "Welcome Aboard" achievement.
- No database, no build tooling, no Aspire — just static files plus a minimal API.

## 🚀 Getting started

Requires the [.NET 10 SDK](https://dotnet.microsoft.com/download).

```bash
git clone https://github.com/leslierichardson95/AchievementUnlocked.git
cd AchievementUnlocked
dotnet run
```

Then open **http://localhost:5147**.

## 🗂️ Project structure

| Path | Purpose |
| --- | --- |
| `Program.cs` | Minimal web host — serves static files (and, on the signup branch, the `/api/signup` endpoint). |
| `wwwroot/index.html` | The entire game: HTML, CSS, and vanilla JS (achievements, confetti, toasts). |
| `Models/` · `Validation/` | Signup request model and FluentValidation rules *(signup branch)*. |

## 🧩 MCP demo

This repo backs a live demo showing GitHub + Context7 + Playwright MCP servers composing to fix a real bug: a password-validation defect in the **Save Your Progress** signup is described in an issue, fixed with docs grounded via Context7, verified in the browser with Playwright, and shipped as a PR.

## 📄 License

MIT — do whatever, have fun. 🎉
