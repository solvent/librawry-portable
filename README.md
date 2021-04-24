# librawry-portable
Playing around with portable netstandard libraries and nuget packaging

# How to use
1. Add GitHub package source into `nuget.conf` (located in your project's root)
```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
	<packageSources>
		<clear />
		<add key="nuget" value="https://api.nuget.org/v3/index.json" />
		<add key="github" value="https://nuget.pkg.github.com/solvent/index.json" />
	</packageSources>
	<packageSourceCredentials>
		<github>
			<add key="Username" value="YOUR_GITHUB_LOGIN" />
			<add key="ClearTextPassword" value="YOUR_GITHUB_PERSONAL_ACCESS_TOKEN" />
		</github>
	</packageSourceCredentials>
</configuration>
```
2. Add package reference to your project
```
dotnet add package Solvent.Librawry.Portable
```
