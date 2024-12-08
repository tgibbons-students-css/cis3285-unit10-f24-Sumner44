﻿ < Project Sdk = "Microsoft.NET.Sdk" >

  < PropertyGroup >
    < OutputType > Exe </ OutputType >
    < TargetFramework > net8.0 </ TargetFramework >
    < ImplicitUsings > enable </ ImplicitUsings >
    < Nullable > enable </ Nullable >
  </ PropertyGroup >

  < ItemGroup >
    < None Remove = "trades.txt" />
    < None Remove = "trades4.txt" />
  </ ItemGroup >

  < ItemGroup >
    < EmbeddedResource Include = "trades.txt" />
    < EmbeddedResource Include = "trades4.txt" />
  </ ItemGroup >

  < ItemGroup >
    < ProjectReference Include = "..\SingleResponsibilityPrinciple.AdoNet\SingleResponsibilityPrinciple.AdoNet.csproj" />
    < ProjectReference Include = "..\SingleResponsibilityPrinciple.Contracts\SingleResponsibilityPrinciple.Contracts.csproj" />
  </ ItemGroup >

</ Project >