# SimpleGlobalHotKeys
This class that I made will allow you to make hotkeys with ease without the need to use win32 at all, it works for c#,.Net framework(which is for windows from my understanding).
all you need to do is:
1) Add this class to your project or downlaod and use the namespace.
2) Click on project --> add reference -->system.windows.forms in case you don't have it.

* If you don't see a tab called assemblies in "add reference"/don't find the reference, do the following:
1) Open the visual studio installer.
2) Press on "more" in the installed tab near your version of visual studio --> modify --> mark .Net desktop development.
3) Press modify and you are done, just wait for it to make the changes.

After step 2 do the following to use the class in your program(look at example.cs, it will clarify things):
1) Make a new class which will inherit from hotkey.
2) Make a constructor that will inherit from base(hotkey,toggle) or in other words, will inherit the base class constructor.
3) Override the function whenPressed and put in it whatever you want to happen once the hotkey gets pressed.
Then, whenever you will make an instance of your class the hotkey will be set with your action.
* If you want to toggle between calling the function endlessly to not calling it with when the button is pressed, when making the instance give true as the value of toggle.
* If you only want your function to be executed once every press, when making the instance give false as the value of toggle.

#SimpleMacro
It's a simple way to make a macro, look at the description for more info about usage
