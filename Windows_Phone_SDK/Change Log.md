* [Release Version 2.3](https://github.com/shephertz/App42_WINDOWS_SDK/blob/master/Windows_Phone_SDK/Change%20Log.md#version-23)
* [Release Version 2.2](https://github.com/shephertz/App42_WINDOWS_SDK/blob/master/Windows_Phone_SDK/Change%20Log.md#version-22)
* [Release Version 2.1](https://github.com/shephertz/App42_WINDOWS_SDK/blob/master/Windows_Phone_SDK/Change%20Log.md#version-21)
* [Release Version 2.0](https://github.com/shephertz/App42_WINDOWS_SDK/blob/master/Windows_Phone_SDK/Change%20Log.md#version-20)
* [Release Version 1.9.1](https://github.com/shephertz/App42_WINDOWS_SDK/blob/master/Windows_Phone_SDK/Change%20Log.md#version-191)
* [Release Version 1.9](https://github.com/shephertz/App42_WINDOWS_SDK/blob/master/Windows_Phone_SDK/Change%20Log.md#version-19)
* [Release Version 1.8.1](https://github.com/shephertz/App42_WINDOWS_SDK/blob/master/Windows_Phone_SDK/Change%20Log.md#version-181)
* [Release Version 1.8](https://github.com/shephertz/App42_WINDOWS_SDK/blob/master/Windows_Phone_SDK/Change%20Log.md#version-18)
* [Release Version 1.7](https://github.com/shephertz/App42_WINDOWS_SDK/blob/master/Windows_Phone_SDK/Change%20Log.md#version-17)
* [Release Version 1.5](https://github.com/shephertz/App42_WINDOWS_SDK/blob/master/Windows_Phone_SDK/Change%20Log.md#version-15)
 
## Version 2.3

**Release Date:** 18-04-2014

**Release Version:** 2.3

**SDK ReStructured**


## Version 2.2

**Release Date:** 24-03-2014

**Release Version:** 2.2

**The following features have been changed :**

```
If you are upgrading from previous version of App42_WINDOWS_SDK and have used SetQuery method on any service, you have to set App42API.SetDbName instead of passing it in method parameter.

**OlD Code Snippet:
SetQuery("dbName","collectionName","query");

**New Code Snippet :
App42API.SetDbName("dbName");
SetQuery("collectionName","query");
```

**The following features have been pushed to the services :**

**STORAGE SERVICE**

```
1.AddOrUpdateKeys.
2.AddAttachmentToDocs.
3.InsertJSONDocument(With Attached File).
```

**User SERVICE**

```
1.AddJSONObject(Add Extra Information while creating user).
2.CreateUserWithProfile.
3.GetUsersByGroup.
```

**PUSH NOTIFICATION SERVICE**
```
1.UnSubscribeDevice.
2.ReSubscribeDevice.
```

**REVIEW SERVICE**
```
1.GetAllReviewsByUser.
```

**SCOREBOARD SERVICE**
```
1.AddJSONObject(Add Extra Information of user while saving score).
```


**This release contains the following bug fix:**

```
None.
```


## Version 2.1

**Release Date:** 07-02-2014

**Release Version:** 2.1

**The following features have been pushed  :**

```
MetaInfo in UserService (GetUser, GetUsersByRole, GetUserByEmailId) and ScoreBoardService(GetTopNRankers, GetTopNTargetRankers).
```

**The following features have been pushed to the services :**

**STORAGE SERVICE**
```
1.Inlist Support for storage query.
2.UpdateDocumentByQuery.
```

**PHOTO SERVICE**
```
1.UpdatePhoto.
```

**PUSH NOTIFICATION SERVICE**
```
1.SendMessageToInactiveUsers.
2.ScheduleMessageToUser.
```

**REVIEW SERVICE**
```
1.DeleteReviewByReviewId.
2.DeleteCommentByCommentId.
```

**SCOREBOARD SERVICE**
```
1.GetTopNTargetRankers.
```

**BUDDY SERVICE**
```
1.Unfriend.
2.DeleteMessageById.
3.DeleteMessageByIds.
```

**This release contains the following bug fix:**

```
None.
```

## Version 2.0

**Release Date:** 22-01-2014

**Release Version:** 2.0

**The following features have been pushed to the services :**

**PUSH SERVICE**

```
SendPushTileMessageToUser
```

**This release contains the following bug fix:**

```
None
```

## Version 1.9.1

**Release Date:** 22-12-2013

**Release Version:** 1.9.1

**The following features have been pushed to the services :**

**SCOREBOARD SERVICE**

```
GetTopNRankersFromFacebook(including rankers in specified date range).
```

**This release contains the following bug fix:**

```
1. AlbumService bug fix.
2. CatalogueService AddItem bug fix.
3. CartService GetQuantity bug fix.
4. CustomCodeService RunJavaCode bug fix.
5. GeoService GetAllStorage bug fix.
6. ReviewService Unmute bug fix.
7. Max Offset bug fix.
```


## Version 1.9

**Release Date:** 25-11-2013

**Release Version:** 1.9

**The following features have been pushed to the services :**

**PUSH SERVICE**

```
SendPushToTargetUsers
```

**STORAGE SERVICE**

```
SaveOrUpdateDocumentByKeyValue
```

**This release contains the following bug fix:**

```
None
```

## Version 1.8.1

**Release Date:** 7-11-2013

**Release Version:** 1.8.1

**The following Services have been pushed to the latest :**

```
None
```

**This release contains the following bug fix:**

```
Duplicate SessionId bug fixed. 
```


## Version 1.8

**Release Date:** 23-10-2013

**Release Version:** 1.8

**The following Services have been pushed to the latest :**

```
AB Test Service
```

**This release contains the following bug fix:**

```
None
```

## Version 1.7

**Release Date:** 23-09-2013

**Release Version:** 1.7

**The following Services have been pushed to the latest :**

```
Achievement Service
```

**The following features have been pushed to the services :**

**SOCIAL SERVICE**

```
facebookPublishStream
facebookLinkPost
facebookLinkPostWithCustomThumbnail
getFacebookProfile
```

**PUSHNOTIFICATION SERVICE**

```
sendPushMessageToGroup
deleteDeviceToken
```


**This release contains the following bug fix:**

```
None
```

## Version 1.5

**Release Date:** 07-08-2013

**Release Version:** 1.5

**The following feature have been pushed to the latest :**




**REWARD SERVICE**

```
GetTopNRewardEarners
GetAllRewardsByUser
GetTopNRewardEarnersByGroup
GetUserRankingOnReward
```

**SCOREBOARD SERVICE**

```
GetTopNRankers
EditScoreValueById
GetTopRankersFromBuddyGroup
```

**STORAGE SERVICE**

```
DeleteAllDocuments
FindDocumentsByLocation
DeleteDocumentsByKeyValue
```

**USER SERVICE**

```
LogOut
```

**PUSHNOTIFICATION SERVICE**

```
UnsubscribeDeviceToChannel
SubscribeToChannel
```

**UPLOAD SERVICE**

```
UploadFileForFriend
UploadFileForFriendS
UploadFileForGroup
```

**BUDDY SERVICE**

```
SendMessageToGroup
SendMessageToFriend
SendMessageToFriends
GetAllMessages
GetAllMessagesFromBuddy
GetAllMessagesFromGroup
```


**This release contains the following bug fix:**

```
None
```
