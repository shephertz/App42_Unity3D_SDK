App42 Unity SDK Sample
======================

# Steps to use sample : 

1. [Register] (https://apphq.shephertz.com/register) with App42 platform.
2. Create an app once you are on Quick start page after registration.
3. If you are already registered, login to [AppHQ] (http://apphq.shephertz.com/register/app42Login) console and create an app from App Manager Tab.
4. [Download](https://github.com/shephertz/App42_Unity3D_SDK/archive/master.zip)  __App42 Unity3D SDK__ and unzip it on your local machine.
5. Open the project in your Unity Editor by opening the unity scene file __(App42-Unity3D-SDK-Sample.unity)__ from  `../sample/App42-Unity3D-SDK-Sample/Assets/scenes/` folder. Or you can simply import the __App42-Unity3D-SDK-Sample__ project from __Unity's "Open project..."-File menu item__ , then click on __"Open Other"__ button and select the path for __App42-Unity3D-SDK-Sample__ folder (e.g `...\Downloads\App42_Unity3D_SDK-master\sample\App42-Unity3D-SDK-Sample`).
6. In your Unity Editor's project tab, select Assets it contains __App42_Unity3D_SDK_x.x.dll__, in case of running this sample for WP8(Windows Phone 8), you must have to replace above dll (__App42_Unity3D_SDK_x.x.dll__) with __App42_Unity3D_SDK_WP8_x.x.dll__, it is available under __x.x/App42-Unity3D-SDK-WP8__ folder of downloaded zip.
7. Then select scripts folder it contains __Constant.cs__.
8. Open __Constant.cs__ file and just copy the __api-Key__ and __secret-Key__ that you have recieved in step 2 or 3 from AppHq console and paste it in Constant.cs file as shown below : 

```
public string apiKey  = "<YOUR_API_KEY>";
public string secretKey = "<YOUR_SECRET_KEY>";
```

9 . Constant.cs file contains all the constants used in scripts (e.g username, email, password, gamename, dbname etc.) edit the variables as your requirements.

10 . Save the source code and go to unity editor, select hierarchy, then select main camera, select any script which you wish to run lets say StorageTest(Script), click run.

Visit our [Unity Developer home page](http://api.shephertz.com/app42-dev/unity3d-backend-apis.php) to learn more about App42 Unity SDK and using our App42 SDK.
