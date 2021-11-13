param(
	[string]$config = "Debug",
	[switch]$help = $false
)

Write-Output "Using [$config] configuration"

$folders = Get-ChildItem -Directory src*

if(-not($help))
{
    foreach($folder in $folders)
    {
        Write-Output ">>>> building solution in $($folder) <<<<"

        Push-Location -Path $folder

        $solution_files = Get-ChildItem "*.sln"

        foreach($solution_file in $solution_files)
        {	
            Write-Output "Building binaries for $solution_file ..."
                
            dotnet build -c $config $solution_file -nowarn:CS8034,RS1022,AD0001,RAZORSDK1006 *>&1
        }

        Pop-Location
    }
}
else 
{
	Write-Output "usage: Build-All2 [options]"
	Write-Output "options:"
	Write-Output ""
	Write-Output "-config [Debug|Release]     build configuration"
	Write-Output "-help                       show this help"
	Write-Output ""
}