@echo off
npm run dev
if errorlevel 1 (
    exit /b 1
)
