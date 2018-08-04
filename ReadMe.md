# Jering.IocServices.System.Net.Http
[![Build status](https://ci.appveyor.com/api/projects/status/wawhrh1nvy5fae2s?svg=true)](https://ci.appveyor.com/project/JeremyTCD/IocServices-System-Net-Http)
[![License](https://img.shields.io/badge/license-Apache%202.0-blue.svg)](https://github.com/Pkcs11Interop/Pkcs11Interop/blob/master/LICENSE.md)
[![NuGet](https://img.shields.io/nuget/vpre/Jering.IocServices.System.Net.Http.svg?label=nuget)](https://www.nuget.org/packages/Jering.IocServices.System.Net.Http/)

## Table of Contents
[Overview](#overview)  
[Target Frameworks](#target-frameworks)  
[Installation](#installation)  
[Usage](#usage)  
[Building](#building)  
[Related Projects](#related-projects)  
[Contributing](#contributing)  
[About](#about)  

## Overview
This is a generated library that provides inversion of control services for types in the `System.Net.Http` namespace. **This library and its generator are both incomplete and under construction.**

## Target Frameworks
- .NET Standard 1.1
 
## Installation
Using Package Manager:
```
PM> Install-Package Jering.IocServices.System.Net.Http
```
Using .Net CLI:
```
> dotnet add package Jering.IocServices.System.Net.Http
```

## Usage
```csharp
var services = new ServiceCollection();
services.AddSingleton<IHttpClientService, HttpClientService>();
ServiceProvider serviceProvider = services.BuildServiceProvider();
IHttpClientService httpClientService = serviceProvider.GetRequiredService<IHttpClientService>();
```

## Building
This project can be built using Visual Studio 2017.

## Related Projects
#### Projects Using this Library
[Jering.JavascriptUtils.NodeJS](https://github.com/JeremyTCD/JavascriptUtils.NodeJS) - A Tool for Invoking Javascript from C#.

## Contributing
Contributions are welcome!  

## About
Follow [@JeremyTCD](https://twitter.com/JeremyTCD) for updates and more.