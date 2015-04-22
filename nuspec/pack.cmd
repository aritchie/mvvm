@echo off
del *.nupkg
nuget pack Acr.Mvvm.nuspec
nuget pack Acr.XamForms.nuspec
pause