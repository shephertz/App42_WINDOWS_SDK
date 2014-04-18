App42_WINDOWS_PHONE_SDK
=======================

1. [Register] (https://apphq.shephertz.com/register) with App42 platform.
2. Create an app once you are on Quick start page after registration.
3. If you are already registered, login to [AppHQ] (http://apphq.shephertz.com/register/app42Login) console and create an app from App Manager Tab.

__Download And Set Up SDK :-__

1). [Download] (https://github.com/shephertz/App42_WINDOWS_SDK/archive/master.zip) Windows SDK

2). Unzip downloaded Zip file. Unzip folder contains two seperate folders for Windows-Phone and Windows-RT(8.1), and each folder contains version folder(ie. 1.0, 1.1 etc).

3). In  Windows_Phone_SDK's version folder will contain App42_WINDOWS_PHONE_SDK_x.x.x.dll and Newtonsoft.Json.WindowsPhone.dll.

4). Then add App42_WINDOWS_PHONE_SDK_x.x.x.dll and Newtonsoft.Json.WindowsPhone.dll in your reference.

__Initializing SDK :-__
You have to instantiate App42API by putting your ApiKey/SecretKey to initialize the SDK.

```
App42API.Initialize("API_KEY", "SECRET_KEY");
```

__Using App42 Services :-__
 you have to build target service that you want to use in your app. For example, User Service can be build with following snippet. Similarly you can build other service also with same notation.
 
```
UserService userService = App42API.BuildUserService();
//Similarly you can build other services like App42API.BuildXXXXService()
```


