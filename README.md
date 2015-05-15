App42 Unity3D SDK
=================

[![OverView](http://api.shephertz.com/images/0.1/logo.png)](http://api.shephertz.com/)

App42 Unity3D SDK can be used to add backend to Unity3D application which can run on different platforms like Android/iOS/Windows phone/Web player/WebGL etc. App42 Unity3D SDK consists of seperate dll to be used for building on __Windows Store__ and is available under __4.x/App42-Unity3D-SDK-WinRT__ folder of downloaded zip. However for rest of the platform is available inside __4.x/App42-Unity3D-SDK__ folder.

###Integrating App42 Unity3D SDK in your app :
Import App42-Unity3D-SDK-X.X in your Assets directory or in the Assets/plugins directory.


###Setting Up Windows Store Environment :
Creating apps for __Windows Store__ platform you have to use both the dlls (i.e __App42-Unity3D-SDK-X.X__ and __App42-Unity3D-SDK-WinRT-X.X__).


###Set Up :
**1.** Create __plugins__ directory in your Assets directory (i.e. Assets/plugins). 
Put the **App42-Unity3D-SDK-X.X** in plugins directory.

![Windows Store SetUp](https://raw.githubusercontent.com/AkshayMShepHertz/App42_ScreenShots/master/ScreenShots/pluginsFolder.png)


**2.** Click on __App42-Unity3D-SDK-X.X.dll__ then you will see the checklist of __Select platforms for plugin__ in your inspector window (By default it is cheked for __Any Platform__).


**3.** You have to manually check the platforms for which you want to build the app. Do not check __WSAPlayer__ and must check __Editor__.


![Windows Store SetUp](https://raw.githubusercontent.com/AkshayMShepHertz/App42_ScreenShots/master/ScreenShots/allChecked.png)


**4.** Now create a directory __metro__ in __plugins__ directory (i.e. Assets/plugins/metro).Put the __App42-Unity3D-SDK-WinRT-X.X__ in __metro__ directory.


![Windows Store SetUp](https://raw.githubusercontent.com/AkshayMShepHertz/App42_ScreenShots/master/ScreenShots/metroFolder.png)


**5.** Now Click on __App42-Unity3D-SDK-WinRT-X.X.dll__ then you will see the checklist again of __Select platforms for plugin__ in your inspector window (By default it is cheked for __WSAPlayer__) and leave it as it is.


![Windows Store SetUp](https://raw.githubusercontent.com/AkshayMShepHertz/App42_ScreenShots/master/ScreenShots/metroChecked.png)


**6.** At last just check the capabilities for __Windows Store__ in Windows Store's __Player Settings__. Check __InternetClient__, __InternetClientServer__ and __PrivateNetworkClientServer__.


![Windows Store SetUp](https://raw.githubusercontent.com/AkshayMShepHertz/App42_ScreenShots/master/ScreenShots/capabilities.png)


Your setup for __Windows Store__ is completed. You are ready to build and run your app.

__Note:-__ The Synchronous APIs are removed from the SDK version 4.0 onwards. 

##Below Unity version 4.5

If you are using Unity version below 4.5 then you have to use App42 Unity3D SDK version below 4.0 (i.e 3.3.1 and earlier)  which consists of seperate dll to be used for building on Windows Phone and is available under __x.x/App42-Unity3D-SDK-WP8__ folder of downloaded zip. However for rest of the platform it is available inside __x.x/App42-Unity3D-SDK__ folder. 

If you are building an app for WP8, then you have to use our App42_Unity3D_SDK_WP8_x.x.dll.
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

Third Party binaries and respective licenses used in App42 Unity3D SDK are listed below.

[LitJson] (http://lbv.github.io/litjson/)

- This library and its documentation are dedicated to the public domain. It may be used by anyone, for any purpose, without restrictions.

[SimpleJSON] (http://wiki.unity3d.com/index.php/SimpleJSON)
- From http://wiki.unity3d.com/

Visit our [Unity Developer home page](http://api.shephertz.com/app42-dev/unity3d-backend-apis.php) to learn more about App42 Unity SDK and using our App42 SDK.

__Note:__ Kindly raise a new issue [here](https://github.com/shephertz/App42-Issue-Tracker/issues), if you find any bug using App42 Unity SDK.
