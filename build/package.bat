msbuild ..\SimpleLogInterface.sln /target:Clean
msbuild ..\SimpleLogInterface.sln /property:Configuration=Release
..\.nuget\nuget pack ..\SimpleLogInterface\SimpleLogInterface.csproj -Prop Configuration=Release
..\.nuget\nuget pack ..\SimpleLogInterface.Log4Net\SimpleLogInterface.Log4Net.csproj -Prop Configuration=Release
@pause