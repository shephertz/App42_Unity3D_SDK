App42 Unity3D SDK
=================

[![OverView](http://api.shephertz.com/images/0.1/logo.png)](http://api.shephertz.com/)

App42 Unity3D SDK can be used to add backend to Unity3D application which can run on different platforms like Android/iOS/Windows phone/Web browser etc. App42 Unity3D SDK consists of seperate dll to be used for building on Windows Phone and is available under __x.x/App42-Unity3D-SDK-WP8__ folder of downloaded zip. However for rest of the platform it is available inside __x.x/App42-Unity3D-SDK__ folder. 

__Note:-__ The Synchronous APIs are removed from the version 4.0 onwards.
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
