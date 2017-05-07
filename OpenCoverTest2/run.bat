cd /d %~dp0

packages\OpenCover.4.6.519\tools\OpenCover.Console.exe -target:"bin\Debug\OpenCoverTest2.exe" -register:user "-targetargs:0" -output:results0.xml
packages\OpenCover.4.6.519\tools\OpenCover.Console.exe -target:"bin\Debug\OpenCoverTest2.exe" -register:user "-targetargs:1" -output:results1.xml
packages\ReportGenerator.2.5.7\tools\ReportGenerator.exe --reports:results*.xml --targetdir:html
