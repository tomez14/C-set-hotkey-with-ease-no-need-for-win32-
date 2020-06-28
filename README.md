# SimpleGlobalHotKeys
This class that I made will allow you to make hotkeys with ease without the need to use win32 at all, it works for c#,.Net framework(which is for windows from my understanding).
all you need to do is:
1) add this class to your project or downlaod and use the namespace
2) click on project --> add reference -->system.windows.forms in case you don't have it

*if you don't see a tab called assemblies, do the following:
1)open the visual studio installer
2) press on "more" in the installed tab near your version of visual studio --> modify --> mark .Net desktop development
3)press modify and you are done, just wait for it to make the changes.

3) make a new class which will inherit from hotkey
4) make a constructor that will inherit from base(hotkey,toggle) or in other words, will inherit the base class constructor
5) override the function whenPressed and put in it whatever you want to happen once the hotkey gets pressed

then, whenever you will make an instance of your class the hotkey will be set with your action
* if you want to toggle between calling the function endlessly to not calling it with when the button is pressed, when making the instance give true as the value of toggle.
* if you only want your function to be executed once every press, when making the instance give false as the value of toggle.
