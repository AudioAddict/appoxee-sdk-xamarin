using System;
using ObjCRuntime;

[assembly: LinkWith ("libAppoxee_ios_32bit_64bit_sdk.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64, SmartLink = true, ForceLoad = true)]
