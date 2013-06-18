App42 Unity SDK
===============

[![OverView](http://www.shephertz.com/images/logo/app42_cloud.png)](http://api.shephertz.com/)

For App42 Unity3D library , You simply need to download latest version of [Unity SDK](https://github.com/shephertz/App42_Unity3D_SDK/raw/master/1.0/App42_Unity_SDK_1.0.zip) which contain the App42_Unity_Api.dll and import it as an Asset into your Unity project 
and you are all set!

# Steps to use sample : 

1. [Register] (https://apphq.shephertz.com/register) with App42 platform
2. Create an app once you are on Quick start page after registration.
3. f you are already registered, login to [AppHQ] (http://apphq.shephertz.com) console and create an app from App Manager Tab
4. Download the unity 3d sdk .
5. open the project in unity and add assest into it.
6. Double click on the project(script) sample code will open..
7. Initailize your apiKey and secretKey in ServiceAPI
8. Save the project and run on utity.


# Design Details:

__Initialize Services:__

```

            ServiceAPI sp = new ServiceAPI("YOUR_API_KEY", "YOUR_SECRET_KEY");
            UserService userService = sp.BuildUserService();

```

__Create user:__

This is done to create user and its parameters are :
1. UserName
2. Password
3. EmailId

```
            User user = userService.CreateUser(userName, password, emailId);
         
```

__Create user:__

This is done to get user and its parameter is :
1. UserName

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


Visit our [Unity Developer home page](https://github.com/shephertz/App42_Unity3D_SDK/wiki/Unity-Home) to learn more about App42 Unity SDK and using our App42 SDK.
