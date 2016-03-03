using ObjCRuntime;

[assembly: LinkWith ("libssl.a", SmartLink = true, ForceLoad = true)]
