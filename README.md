App42 Unity SDK
===============

[![OverView](http://www.shephertz.com/images/logo/app42_cloud.png)](http://api.shephertz.com/)

For App42 Unity3D library , You simply need to download latest version of Unity SDK which contain the App42_Unity_Api.x.x.x.dll and import it as an Asset into your Unity project 
and you are all set!

# Steps to use sample : 

1. [Register] (https://apphq.shephertz.com/register) with App42 platform
2. Create an app once you are on Quick start page after registration.
3. If you are already registered, login to [AppHQ] (http://apphq.shephertz.com/register/app42Login) console and create an app from App Manager Tab
4. [Download](https://github.com/shephertz/App42_Unity3D_SDK/archive/master.zip) the unity 3d sdk .
5. Open the App42_Unity_Sample.unity from  **/sample/App42_Unity_Sample/Assets/** folder. it contains your App42_Unity_SDK_x.x.dll & App42_Unity_Sample.cs.
6. App42_Unity_Sample.cs contain your sample code.
7. Pass your apiKey and secretKey.
8. Save the source code and run on unity.


# Design Details:

__Initialize Services:__

```
ServiceAPI sp = new ServiceAPI("YOUR_API_KEY", "YOUR_SECRET_KEY");
UserService userService = sp.BuildUserService();
```

__Create user:__

This is done to create user and its parameters are :
1. userName
2. password
3. emailId

```
User user = userService.CreateUser(userName, password, emailId);
         
```

__Get user:__

This is done to get user and its parameter is :
1. userName

```
User response = userService.GetUser(userName);
         
```

__Get input from user:__

This is done to create the text area and get the input from user.

```
txt_user = GUI.TextField(new Rect(50, 10, 200, 20), txt_user);
txt_pass = GUI.TextField(new Rect(50, 40, 200, 20), txt_pass);
txt_email = GUI.TextField(new Rect(50, 70, 200, 20), txt_email);
txt_name = GUI.TextField(new Rect(400, 10, 200, 20), txt_name);
```


__create label:__

This is done to create the label which shows what value has to enter in text field.

```
GUI.Label(new Rect(260, 10, 200, 20),"Username");
GUI.Label(new Rect(260, 40, 200, 20),"Password");
GUI.Label(new Rect(260, 70, 200, 20),"Email");
GUI.Label(new Rect(610, 10, 200, 20),"Username");
      
```


Visit our [Unity Developer home page](http://api.shephertz.com/app42-dev/unity3d-backend-apis.php) to learn more about App42 Unity SDK and using our App42 SDK.
