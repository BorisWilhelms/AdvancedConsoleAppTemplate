Compress-Archive src/* AdvancedConsoleApp.zip -Force
$path = "$Env:USERPROFILE\Documents\Visual Studio 2017\Templates\ProjectTemplates\Visual C#\.NET Core\"
if (-Not (Test-Path $path))
{
    mkdir $path -Force
}

cp AdvancedConsoleApp.zip $path