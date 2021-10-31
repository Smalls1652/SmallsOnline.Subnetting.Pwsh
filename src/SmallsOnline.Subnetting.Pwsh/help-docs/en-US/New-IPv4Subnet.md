---
external help file: SmallsOnline.Subnetting.Pwsh.dll-Help.xml
Module Name: SmallsOnline.Subnetting.Pwsh
online version:
schema: 2.0.0
---

# New-IPv4Subnet

## SYNOPSIS

Calculate an IPv4 network subnet.

## SYNTAX

### Default

```
New-IPv4Subnet [-IPAddress] <IPAddress> [[-CidrNotation] <Double>] [<CommonParameters>]
```

### SubnetString

```
New-IPv4Subnet [-NetworkString] <String> [<CommonParameters>]
```

## DESCRIPTION

Calculate an IPv4 network subnet based off an existing IP address (Either a host or network address) and the CIDR notation or the subnet mask.

## EXAMPLES

### Example 1

```powershell
PS C:\> New-IPv4Subnet -IPAddress "192.168.10.0" -CidrNotation 24

NetworkAddress   : 192.168.10.0
SubnetMask       : 255.255.255.0
CidrMask         : 24
BroadcastAddress : 192.168.10.255
TotalAddresses   : 256
UsableAddresses  : 254
UsableHostRange  : 192.168.10.1 - 192.168.10.254
```

Calculate the subnet info for an IP address of 192.168.10.0 and a CIDR notation of 24.

### Example 2

```powershell
PS C:\> New-IPv4Subnet -NetworkString "172.19.15.6/22"           

NetworkAddress   : 172.19.12.0
SubnetMask       : 255.255.252.0
CidrMask         : 22
BroadcastAddress : 172.19.15.255
TotalAddresses   : 1024
UsableAddresses  : 1022
UsableHostRange  : 172.19.12.1 - 172.19.15.254
```

Calculate the subnet info from a string.

## PARAMETERS

### -CidrNotation

The CIDR notation of the subnet.

```yaml
Type: System.Double
Parameter Sets: Default
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IPAddress

An IP address in a subnet. Can be any host address within a subnet.

```yaml
Type: System.Net.IPAddress
Parameter Sets: Default
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkString

A string representing a subnet.

```yaml
Type: System.String
Parameter Sets: SubnetString
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters

This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### SmallsOnline.Subnetting.Lib.Models.IPv4Subnet

## NOTES

## RELATED LINKS
