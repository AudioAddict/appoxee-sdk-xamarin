using System;
using ObjCRuntime;

[assembly: LinkWith ("libAppoxee_ios_32bit_64bit_sdk_v3.2.5.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64, SmartLink = true, ForceLoad = true)]
