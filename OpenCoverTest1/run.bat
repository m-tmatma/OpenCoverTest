cd /d %~dp0

packages\OpenCover.4.6.519\tools\OpenCover.Console.exe -target:"bin\Debug\OpenCoverTest1.exe" -register:user "-targetargs:test1 test2" -output:results0.xml
packages\ReportGenerator.2.5.7\tools\ReportGenerator.exe --reports:results0.xml --targetdir:html
