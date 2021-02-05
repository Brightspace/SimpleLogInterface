param (
    [switch] $Publish
)

$ErrorActionPreference = 'Stop'

if( Test-Path .\output ) {
    Remove-Item -recurse .\output
}

msbuild .\SimpleLogInterface.sln /t:Rebuild /v:m
if( $LASTEXITCODE -ne 0 ) {
    throw "MSBuild failed with exit code $LASTEXITCODE"
}

foreach( $project in ( Get-ChildItem .\src -Directory ).Name ) {
    nuget pack -NonInteractive .\src\$project\$project.csproj -OutputDirectory .\output
    if( $LASTEXITCODE -ne 0 ) {
        throw "nuget pack failed with exit code $LASTEXITCODE"
    }
}

if( $Publish ) {
    foreach( $package in ( Get-ChildItem .\output\*.nupkg ).Name ) {
        nuget push ".\output\$package" -Source d2l/private -APiKey aws -NonInteractive
        if( $LASTEXITCODE -ne 0 ) {
            throw "nuget push failed with exit code $LASTEXITCODE"
        }
    }
}