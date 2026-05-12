@echo off
:loop
echo Checking for changes...
git add .
git commit -m "Auto-update: New changes saved"
git push
echo Waiting for next update...
timeout /t 300
goto loop