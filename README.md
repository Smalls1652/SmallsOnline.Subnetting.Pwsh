# `SmallsOnline.Subnetting.Pwsh`

_**A C#-based subnet calculator for PowerShell.**_

This repository is for a PowerShell module to perform subnetting of IPv4 address spaces. It is currently a work-in-progress. Core development is done through a C# class library I am working on called [`SmallsOnline.Subnetting.Lib`](https://github.com/Smalls1652/SmallsOnline.Subnetting).

## Related projects

| Name | Link |
| ---- | ---- |
| **C# Class Library** | [@Smalls1652/SmallsOnline.Subnetting](https://github.com/Smalls1652/SmallsOnline.Subnetting) |

## 🧱 Build Status

| Branch | Status |
| ------ | ------ |
| **`SmallsOnline.Subnetting.Lib`** | [![Build](https://github.com/Smalls1652/SmallsOnline.Subnetting/actions/workflows/build.yml/badge.svg?branch=main&event=push)](https://github.com/Smalls1652/SmallsOnline.Subnetting/actions/workflows/build.yml) |
| **`SmallsOnline.Subnetting.Pwsh`** | [![Build](https://github.com/Smalls1652/SmallsOnline.Subnetting.Pwsh/actions/workflows/build.yml/badge.svg?branch=main)](https://github.com/Smalls1652/SmallsOnline.Subnetting.Pwsh/actions/workflows/build.yml) |

## 💾 Installation

### 🧰 Prerequisites

These are the supported versions of PowerShell:

| Version | Operating Systems | Is Supported |
| ------- | ----------------- | ------------ |
| **Windows PowerShell 5 or lower** | Windows | ⛔ |
| **Windows PowerShell 5.1**<sup>1</sup> | Windows | ✅ |
| **PowerShell 6 or higher** | Windows, macOS, Linux | ✅ |

<sup>1</sup> _Windows PowerShell 5.1 is installed on Windows 10 by default._

### 🖼️ PowerShell Gallery

The best place to get this module is from the [PowerShell Gallery listing](https://www.powershellgallery.com/packages/SmallsOnline.Subnetting.Pwsh).

From a PowerShell console, run this command:

```powershell
Install-Module -Name "SmallsOnline.Subnetting.Pwsh" -AllowPrerelease
```

⚠️ **Note:** If you're using Windows PowerShell 5.1, please ensure that `PowerShellGet` is up-to-date. For more details, [view this doc](https://docs.microsoft.com/en-us/powershell/scripting/gallery/installing-psget?view=powershell-5.1).