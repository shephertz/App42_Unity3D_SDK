App42 Unity SDK
===============

[![OverView](http://www.shephertz.com/images/logo/app42_cloud.png)](http://api.shephertz.com/)

App42 Unity SDK can be used to add backend to Unity application which can run on different platforms like Android/iOS/Windows phone/Web browser etc. App42 Unity SDK consists of seperate dll to be used for building on Windows Phone and is available under __2.0/App42-Unity3D-SDK-WP8__ folder of downloaded zip. However for rest of the platform it is available inside __2.0/App42-Unity3D-SDK__ folder. 

__Note:__ If you are building an app for WP8, then you have to use our App42_Unity3D_SDK_WP8_x.x.dll.
If you want to test your script in UNITY_EDITOR, then use a X509Certificates validator like this :-
```
#if UNITY_EDITOR
public static bool Validator (object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
         {return true;}
#endif
void Start ()
{
#if UNITY_EDITOR
   ServicePointManager.ServerCertificateValidationCallback = Validator;
#endif
}
```

# Steps to use sample : 

1. [Register] (https://apphq.shephertz.com/register) with App42 platform.
2. Create an app once you are on Quick start page after registration.
3. If you are already registered, login to [AppHQ] (http://apphq.shephertz.com/register/app42Login) console and create an app from App Manager Tab.
4. [Download](https://github.com/shephertz/App42_Unity3D_SDK/archive/master.zip)  __App42 Unity3D SDK__ and unzip it on your local machine.
5. Open the project in your Unity Editor by opening the unity scene file __(App42-Unity3D-SDK-Sample.unity)__ from  `../sample/App42-Unity3D-SDK-Sample/Assets/scenes/` folder. Or you can simply import the __App42-Unity3D-SDK-Sample__ project from __Unity's "Open project..."-File menu item__ , then click on __"Open Other"__ button and select the path for __App42-Unity3D-SDK-Sample__ folder (e.g `...\Downloads\App42_Unity3D_SDK-master\sample\App42-Unity3D-SDK-Sample`).
6. In your Unity Editor's project tab, select Assets it contains __App42_Unity3D_SDK_x.x.dll__, in case of running this sample for WP8(Windows Phone 8), you must have to replace above dll (__App42_Unity3D_SDK_x.x.dll__) with __App42_Unity3D_SDK_WP8_x.x.dll__, it is available under __2.0/App42-Unity3D-SDK-WP8__ folder of downloaded zip.
7. Then select scripts folder it contains __Constant.cs__.
8. Open __Constant.cs__ file and just copy the __api-Key__ and __secret-Key__ that you have recieved in step 2 or 3 from AppHq console and paste it in Constant.cs file as shown below : 

```
public string apiKey  = "<YOUR_API_KEY>";
public string secretKey = "<YOUR_SECRET_KEY>";
```

9 . Constant.cs file contains all the constants used in scripts (e.g username, email, password, gamename, dbname etc.) edit the variables as your requirements.

10 . Save the source code and go to unity editor, select hierarchy, then select main camera, select any script which you wish to run lets say StorageTest(Script), click run.


Visit our [Unity Developer home page](http://api.shephertz.com/app42-dev/unity3d-backend-apis.php) to learn more about App42 Unity SDK and using our App42 SDK.
