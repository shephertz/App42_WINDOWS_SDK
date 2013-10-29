App42_WINDOWS_SDK
================

App42 BPaaS Cloud API Client SDK files for WINDOWS

- Download the App42 BPaaS WINDOWS SDK
- Unzip the file and open **App42 WINDOWS Sample** project.
- Add the **App42_BPaaS_WINDOWS_SDK_x.x.x.dll** into refrence. (**Add Reference -> Select Your dll path)**
- Initialize the library using
```
ServiceAPI sp = new ServiceAPI("<YOUR_API_KEY>","<YOUR_SECRET_KEY>");
sp.SetBaseURL("<YOUR_API_SERVER_URL>");
```
- Instantiate the service that one wants to use in the App, e.g. using User service one has to do the following
```
UserService userService = sp.BuildUserService();
```

- Now one can call associated method of that service e.g. user creation can be done with the following snippet

```
public class Callback : App42Callback  
{  
	public CallBack(){
		String userName = "Nick";   
		String pwd  = "*****";
		String emailId = "nick@shephertz.co.in";
		userService.CreateUser(userName,pwd,emailId, this);  
	}
	void App42Callback.OnException(App42Exception exception)  
	{  
		Console.WriteLine("Exception Message");  
	}  
	void App42Callback.OnSuccess(Object response)  
	{  
		User user = (User) response;
		Console.WriteLine("userName is " + user.GetUserName());
		Console.WriteLine("emailId is " + user.GetEmail());     
		String jsonResponse = user.ToString();  
	}  
}  

```

- Build the project and run.
