echo off
cd C:\DLL\RegisterAndSavetoGac

C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe NetDllForCom.dll

echo -start gacutil

gacutil.exe /i NetDllForCom.dll

echo ìoò^èIóπÇµÇ‹Ç∑ÅB

pause