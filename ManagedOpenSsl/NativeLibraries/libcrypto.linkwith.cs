using ObjCRuntime;

[assembly: LinkWith ("libcrypto.a", SmartLink = true, ForceLoad = true)]
