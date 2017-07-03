@ECHO OFF
start /w "" "%~dp0\dotNetFx40_Full_x86_x64.exe" /q /norestart
IF %ERRORLEVEL% == 3010 EXIT /B 0
EXIT /B %ERRORLEVEL%
