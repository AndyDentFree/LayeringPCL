# LayeringPCL
Investigating layering PCL to call native code especially Xamarin mobile.

Initial context is working on the [Realm Xamarin Product](https://realm.io/docs/xamarin/latest/) support for PCL.

I am a multi-platform developer who's shipped a couple of native IOS projects (Swift and Objective-C) but mostly comes from a desktop background with over 20 years of C++.

That perspective may affect my understanding, choice of idioms and anecdotes. I will try to avoid too many references to MFC.


## ThreeLayerXF
Created in VS2015 using _Xamarin Forms Portable_ template

Diving into giving PCL layering a full workout.

* `ThreeLayerXF` UI Layer of common Xamarin Forms UI
* `PurePCLViewModel` Sandwich filling invoked by `ThreeLayerXF`
* `NativeCallingBottom` layer which will invoke native code from PCL (somehow)

`PurePCLViewModel` and `NativeCallingBottom` both created using the VS2015 template _Class Library (Portable)_ with default targets to match the Xamarin Forms PCL default:

* .Net Framework 4.5
* Windows 8
* Windows Phone Silverlight 8
* Windows Phone 8.1
* Xamarin.Android
* Xamarin.iOS
* Xamarin.iOS (Classic)

