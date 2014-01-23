# Steps to use sample : 

1. [Register] (https://apphq.shephertz.com/register) with App42 platform.
2. Create an app once you are on Quick start page after registration.
3. If you are already registered, login to [AppHQ] (http://apphq.shephertz.com/register/app42Login) console and create an app from App Manager Tab.
4. [Download the App42 Windows Phone SDK] (https://github.com/shephertz/App42_WINDOWS_SDK/archive/master.zip)
5. Unzip the downloded file on your local system.
5. Open the project App42Sample in Visual Studio Editor. 
6. Add the App42 latest library in your project refrence(Downloaded SDK/App42-Windows-SDK/x.x.version/App42_WINDOWS_API_x.x.x.dll)
7. Open the Constants.cs file add put the required credentials for running the App42Sample e.g. apiKey, secretKey, gameName, dbName, collectionName etc.
8. Build your project and run.

# Design Details 

# Initialize App42 Instance
 
```
App42API.Initialize("API_KEY", "SECRET_KEY");
```

# Build App42 Services

```
StorageService storageService = App42API.BuildStorageService();
```

# Insert Your JSON Document

```
String dbName = "<Your_DataBase_Name>";
String collectionName = "<Your_Collection_Name>";   
String json = "{\"name\":\"Nick\",\"age\":30,\"phone\":\"xxx-xxx-xxx\"}";  
storageService.InsertJSONDocument(dbName,collectionName,json, new Callback());    
public class Callback : App42Callback    
{    
    public void OnException(App42Exception exception)    
    {    
        Console.WriteLine("Exception Message : " + exception);    
    }    
    public void OnSuccess(Object response)    
    {    
        Storage storage = (Storage) response;  
        IList<Storage.JSONDocument> jsonDocList = storage.GetJsonDocList();   
        for(int i=0;i <jsonDocList.Count;i++)  
        {     
            Console.WriteLine("DocId is : " + jsonDocList[i].GetDocId());  
            Console.WriteLine("JSONDoc is : " + jsonDocList[i].GetJsonDoc());  
            Console.WriteLine("CreatedAt is : " + jsonDocList[i].GetCreatedAt());  
            Console.WriteLine("UpdatedAt is : " + jsonDocList[i].GetUpdatedAt());  
        }    
    }    
}           
```

# Find Document By Key Value

```
String dbName = "<Your_DataBase_Name>";
String collectionName = "<Your_Collection_Name>"; 
String key = "name"; 
String value = "Nick"; 
storageService.FindDocumentByKeyValue(dbName,collectionName,key,value, new Callback());  
public class Callback : App42Callback  
{  
	public void OnException(App42Exception exception)  
	{  
		Console.WriteLine("Exception Message : " + exception);  
	}  
	public void OnSuccess(Object response)  
	{  
		Storage storage = (Storage) response;
		IList<Storage.JSONDocument> jsonDocList = storage.GetJsonDocList(); 
		for(int i=0;i <jsonDocList.Count;i++)
		{   
			Console.WriteLine("DocId is : " + jsonDocList[i].GetDocId());
			Console.WriteLine("JSONDoc is : " + jsonDocList[i].GetJsonDoc());
			Console.WriteLine("CreatedAt is : " + jsonDocList[i].GetCreatedAt());
			Console.WriteLine("UpdatedAt is : " + jsonDocList[i].GetUpdatedAt());
		} 
	}  
}  
```

Visit our [Windows Developer home page](http://api.shephertz.com/app42-dev/windows-phone-backend-apis.php) to learn more about App42 Windows SDK.
