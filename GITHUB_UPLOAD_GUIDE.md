# Expense Splitter - GitHub Upload Guide

## Step 1: Create a GitHub Repository

1. Go to https://github.com/new
2. Fill in:
   - **Repository name**: `ExpenseSplitter` (or any name you prefer)
   - **Description**: "Expense Splitter for Friends/Trips - ASP.NET Core MVC"
   - **Public** (recommended for portfolio)
   - Check "Add a README file" (optional, we already have one)
3. Click **Create repository**
4. Copy the HTTPS URL from the green "Code" button (looks like: `https://github.com/yourusername/ExpenseSplitter.git`)

## Step 2: Upload to GitHub

Once Git is installed on your system, open PowerShell and run these commands:

```powershell
cd c:\Users\Amit\Programming\ExpenseSplitter

# Configure Git (one time)
git config --global user.name "Your Name"
git config --global user.email "your.email@example.com"

# Initialize repository
git init

# Add all files
git add .

# Create initial commit
git commit -m "Initial commit: Expense Splitter ASP.NET Core MVC application"

# Add remote (replace URL with your GitHub repo URL)
git remote add origin https://github.com/yourusername/ExpenseSplitter.git

# Rename branch to main if needed
git branch -M main

# Push to GitHub
git push -u origin main
```

## Authentication

When prompted for credentials:
- **Username**: Your GitHub username
- **Password**: Use a Personal Access Token (better than password)
  - Go to GitHub Settings → Developer settings → Personal access tokens → Tokens (classic)
  - Click "Generate new token (classic)"
  - Select `repo` scope
  - Copy and use as password

## What Gets Uploaded

✅ **Uploaded:**
- All source code (Controllers, Models, Views)
- Configuration files (appsettings.json, .csproj)
- Database migrations
- README.md
- .gitignore

❌ **Ignored (not uploaded):**
- bin/ and obj/ directories
- *.db (local database files)
- .vs/ (Visual Studio cache)
- node_modules/ (if any)

## After Upload

Once uploaded to GitHub:
1. Share the repository link in interviews
2. Use it for your portfolio/resume
3. Potential employers can see your code quality and practices

## Quick Reference

If Git is installed but not recognized, restart PowerShell or use Git Bash:
- Right-click in ExpenseSplitter folder
- Select "Open Git Bash here"
- Run the same commands above

---

**Need help?** Once you create the GitHub repo and have the URL, let me know and I can help you complete the upload!
