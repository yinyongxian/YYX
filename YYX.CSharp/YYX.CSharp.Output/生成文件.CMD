@echo off

md YYX.CSharp

::�����ļ�
FOR %%i in (
    YYX.CSharp.dll,
    YYX.Test.exe
) ^
Do Copy %%i YYX.CSharp\