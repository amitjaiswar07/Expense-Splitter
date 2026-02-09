# Expense Splitter - ASP.NET Core MVC

## What This Project Does
A web application where friends create a group, add shared expenses, and the system calculates who owes whom.

## Features
- Create expense groups/trips
- Add multiple expenses to a group
- Track who paid for each expense
- View expense summary with equal split calculation
- Simple, clean UI with Bootstrap styling

## How to Run

### Prerequisites
- .NET 7 SDK or later
- SQL Server (LocalDB is included with SQL Server Express)

### Setup Steps

1. **Navigate to project directory**
   ```bash
   cd c:\Users\Amit\Programming\ExpenseSplitter
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Create database**
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Open in browser**
   Navigate to `http://localhost:5000`

## Project Structure
```
ExpenseSplitter/
├── Models/                 # Data models (Group, Member, Expense)
├── Controllers/            # MVC controllers
├── Views/                  # Razor view pages
├── Data/                   # Entity Framework context
├── wwwroot/                # Static files (CSS, JS, images)
├── Program.cs              # Main configuration
├── appsettings.json        # App settings and connection string
└── ExpenseSplitter.csproj  # Project file
```

## User Flow
1. **Create Group** - Start a new trip/expense group
2. **Add Expenses** - Add individual expenses with amount and who paid
3. **View Summary** - See total expenses and equal split per person

## Key Technologies
- ASP.NET Core 7.0 MVC
- Entity Framework Core 7.0
- SQL Server
- Bootstrap 5 for UI

## HR Explanation
"It's an ASP.NET Core MVC application that helps friends manage shared trip expenses. Users create a group, add expenses, and the system calculates how much each person should pay. I used Entity Framework for data access, implemented basic CRUD operations, and kept the logic simple for clarity and usability."
