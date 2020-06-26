# SimpleGlobalHotKeys
This class that I made will allow you to make hotkeys with ease without the need to use win32 at all.
all you need to do is:
1) add this class to your project or downlaod and use the namespace
2) click on project --> add reference -->system.windows.forms in case you don't have it
3) make a new class which will inherit from hotkey
4) make a constructor that will inherit from base(hotkey,toggle) or in other words, will inherit the base class constructor
5) override the function whenPressed and put in it whatever you want to happen once the hotkey gets pressed
* if you want to toggle calling the function endlessly to not calling it with a button press then when making the instance give true as the value of toggle
* if you want the function to happen only once give false as the value of toggle
then, whenever you will make an instance of your class the hotkey will be set with your action
