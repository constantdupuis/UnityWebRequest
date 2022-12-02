Get-ChildItem .\ -include bin,obj,Library,Logs,Temp,Builds,Build,build,builds -Recurse | ForEach-Object ($_) { remove-item $_.fullname -Force -Recurse }
