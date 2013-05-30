properties {
	$ProductVersion = "1.0"
	$PatchVersion = "0"
	$BuildNumber = if($env:BUILD_NUMBER -ne $null) { $env:BUILD_NUMBER } else { "0" }
	$PreRelease = ""
}

$baseDir = Split-Path (Resolve-Path $MyInvocation.MyCommand.Path)
$toolsDir = "$baseDir\tools"
$setupProjectFile = "$baseDir\Setup\Studio.aip"
$setupModuleOutPutDir = "$baseDir\Setup\Output Package"

include $toolsDir\psake\buildutils.ps1

task default -depends Init, BuildSetup

task Init {

    # Install path for Advanced Installer
    $AdvancedInstallerPath = ""
    $AdvancedInstallerPath = Get-RegistryValue "HKLM:\SOFTWARE\Wow6432Node\Caphyon\Advanced Installer\" "Advanced Installer Path" 
    $script:AdvinstCLI = $AdvancedInstallerPath + "\bin\x86\AdvancedInstaller.com"
    
}

task BuildSetup {  
    
	if($PreRelease -eq "") {
		$archive = "Particular.ServiceMatrix-$ProductVersion.$PatchVersion" 
        $preReleaseName = ""
	} else {
		$archive = "Particular.ServiceMatrix-$ProductVersion.$PatchVersion-$PreRelease$BuildNumber"
        $preReleaseName = "-$PreRelease$BuildNumber"
	}

	# edit Advanced Installer Project	  
	exec { &$script:AdvinstCLI /edit $setupProjectFile /SetVersion "$ProductVersion.$PatchVersion" -noprodcode }	
	exec { &$script:AdvinstCLI /edit $setupProjectFile /SetPackageName "$archive.exe" -buildname DefaultBuild }
	exec { &$script:AdvinstCLI /edit $setupProjectFile /SetOutputLocation -buildname DefaultBuild -path "$baseDir\Setup\Output Package" }
    
    exec { &$script:AdvinstCLI /edit $setupProjectFile /SetProperty OPT_PRERELEASE_NAME="$preReleaseName" }
    
	# Build setup with Advanced Installer	
	exec { &$script:AdvinstCLI /rebuild $setupProjectFile }
}

