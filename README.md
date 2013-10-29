App42 BPaaS Unity3D SDK
========================

App42 BPaaS Cloud API Client SDK JAR files for Unity3D 

- Download the App42 BPaaS UNITY3D SDK
- Unzip the file and open **App42 Unity3D Sample** project.
- Open the App42_Unity_Sample.unity from  **/sample/App42_Unity3D_Sample/Assets/** folder. it contains your App42_BPaaS_Unity_SDK_x.x.dll.
- Initialize the library using
```
ServiceAPI sp = new ServiceAPI("<YOUR_API_KEY>","<YOUR_SECRET_KEY>");
sp.SetBaseURL("<YOUR_API_SERVER_URL>");
```
- Instantiate the service that one wants to use in the App, e.g. using User service one has to do the following
```
UserService userService = sp.BuildUserService();
```

- Now one can call associated method of that service e.g. user creation can be done with the following snipped

```
String userName = "Nick";
String pwd = "********";
String emailId = "nick@shephertz.co.in";
App42Log.SetDebug(true);		//Print output in your editor console
userService.CreateUser(userName, pwd, emailId,new UnityCallBack()); 
public class UnityCallBack : App42CallBack
{
	public void OnSuccess(object response)
	{
		User user = (User) response;
		App42Log.Console("userName is " + user.GetUserName());
		App42Log.Console("emailId is " + user.GetEmail()); 
	}

	public void OnException(Exception e)
	{
		App42Log.Console("Exception : " + e);
	}
}
```

- Save the source code and run on unity.
