# Azure Functions demo for Unity
Contains a Unity 2017 project featuring Azure Functions demo scene.

## External dependencies
**First download the required dependencies and extract the contents into your Unity project "Assets" folder.**
* [RESTClient](https://github.com/Unity3dAzure/RESTClient)
* [AppServices](https://github.com/Unity3dAzure/AppServices)

## :octocat: Download instructions
This project contains git submodule dependencies so use:
    `git clone --recursive https://github.com/Unity3dAzure/AzureFunctionsDemo.git`

Or if you've already done a git clone then use:
    `git submodule update --init --recursive`

## How to setup Azure Functions with a new Unity project
1. Use the git CLI to download submodules into project or manually download dependencies [AppServices](https://github.com/Unity3dAzure/AppServices/archive/master.zip) and [REST Client](https://github.com/Unity3dAzure/RESTClient/archive/master.zip) into your Unity project's `Assets` folder.
2. Create an [Azure Function App](https://portal.azure.com)
	* Create an HTTP Trigger function.
  ![Azure 'hello' function](https://user-images.githubusercontent.com/1880480/32570569-5f750ce6-c4bc-11e7-9666-e7386c06c7ac.png)
3. Copy & paste your Azure Function details into the Unity.
	* Enter your account, name and code.
	![Azure Function details in Unity](https://user-images.githubusercontent.com/1880480/32570888-86b9fb9e-c4bd-11e7-84e7-3252208759d5.png)

## Minimum Requirements
Requires Unity v5.3 or greater as [UnityWebRequest](https://docs.unity3d.com/Manual/UnityWebRequest.html) and [JsonUtility](https://docs.unity3d.com/ScriptReference/JsonUtility.html) features are used. Unity will be extending platform support for UnityWebRequest so keep Unity up to date if you need to support these additional platforms.

## Supported platforms
Intended to work on all the platforms [UnityWebRequest](https://docs.unity3d.com/Manual/UnityWebRequest.html) supports including:
* Unity Editor (Mac/PC) and Standalone players
* iOS
* Android
* Windows

## Beta version
This is a work in progress so stuff may change frequently.

Questions or tweet [@deadlyfingers](https://twitter.com/deadlyfingers)
