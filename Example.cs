using System;
using SimpleHotKeys;
using System.Windows.Forms;
namespace Example
{
    public class example : HotKey
    {
        string text;
        public example(string text, Keys hotkey, bool toggle) : base(hotkey, toggle)//here I made a constructor which inherits from the base constructor aka part 4 of README, it is neccesery. also remeber to make it public for you to be able to access it
        {
            this.text = text;
        }
        public override void whenPressed()//you HAVE TO override this function for this class to work, what is inside here will be the code you want to execute once the hotkey was pressed
        {
            //whatever you want to happen once the key was pressed, don't forget about toggle which toggles calling this function or untoggles calling it whenever the key is pressed
        }
    }
}
