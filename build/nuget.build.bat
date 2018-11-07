REM This file should not be run directly.
REM It is run by the Visual Studio buld process.

SET NUGET=..\packages\NuGet.CommandLine.4.4.1\tools\NuGet.exe
SET VER=%1
SET CONFIG=%2

@ECHO ====== Creating NuGet Package to %OUTDIR% from %cd%
%NUGET% pack Rhythm.Html.csproj -outputdirectory ..\..\dist -version %VER% -Properties Configuration=%CONFIG%