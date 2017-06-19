@echo off

md YYX.CSharp

::公共文件
FOR %%i in (
    YYX.CSharp.dll,
    YYX.Test.exe
) ^
Do Copy %%i YYX.CSharp\