call echo " tạo forel"
call "mkdir C:\Users\Administrator\Desktop\AutoDeploywindow"
call echo "delete"
call "C:\Users\Administrator\Desktop\AutoDeploywindow\*.*/s /q
call "rmdir C:\Users\Administrator\Desktop\AutoDeploywindow /s /q
call echo "build"
call "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe"  "C:\Users\Administrator\Desktop\AutoDeploywindow\AutoDeploywindow.sln"
call "build ok"
pause
