for /f "delims=" %a in ('echo.%cd%') do mkdir "%a\%~nxa"
cd ShTasks
dotnet new console