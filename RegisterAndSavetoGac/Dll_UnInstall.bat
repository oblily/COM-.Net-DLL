echo off
cd C:\DLL\RegisterAndSavetoGac

C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe /u NetDllForCom.dll
gacutil.exe /u NetDllForCom

echo �o�^�I�����܂��B

pause