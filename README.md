# Arabic Letters Support For Unity
This plugin allows you to use accurate and correct Arabic text in your game or 3D application. Supports Tashkeel and Hindu numbers. Supports 4 Persian Characters.

You can find it in the Unity Asset Store here: https://www.assetstore.unity3d.com/en/#!/content/2674

Also, check out [UPersian](https://github.com/ElectroGryphon/EGGA/tree/master/UPersian). It uses this plugin to create these GUI items: 
1. RTL Text 
2. RTL Input field
3. RTL Buton
4. RTL Checkbox

Assalamu Alaikum! (Peace upon you all!)
This asset will enable you to use Arabic Words in your game. 
There are two main problems to address here:
1.	Arabic Letters orders. It's like reading "Hello" as "olleH".
السلام  is displayed as:  م ا ل س ل ا
2.	Arabic Letters connectivity. As seen here: “السلام  is displayed as:  م ا ل س ل ا” the letters are no disconnected.

# Building The Project
You only need to use ArabicSupport.cs file in your project. So there is no real need for building. The rest of the files there are just for demonstration in a Unity Project in expectation of developers wanting to demo the extra features they add to the plugin.

The project should work on most unity versions for now until we start adding features that are available only in later unity versions.

# Testing The Project
Usually the project is updated once a flaw is discovered, or something new needs to be added.
In the scenes folder there is "Test Cases.unity" file that includes all previous tested words. 
## Follow the following steps:
1. Make changes.
2. Go and see the test case scene and check if something broke. (Sadly you'll have to know basic Arabic writing to know this)
3. Add new words to the scene that you found that broke so others can also test it.

You can add your own test cases scene if it makes sense to you.

# Notes
1.	You'll need to use a font that got Arabic letters in it.
2.	You'll need to modify the text attribute through script. This does not fix the problem if you write directly in a text field.
3.	The script is written in C#.
4.	The code is a little messy so please excuse me.

# Steps
1.	To use the Unity Arabic Support asset inside a script, use: "using ArabicSupport;"
2.	After using the using statement, use the following method (returns a string):	ArabicFixer.Fix(textToBeFixed);
3.	And you're done! You can use the alternative: ArabicFixer(string, tashkeel, hindoNumbers) for more customization options.

# Extras
1.	You can now show Harakat such as ًٌٍَُِ~ّْ using the plugin. Also, you have option to remove the Harakat realtime by setting the plugin to ignore the Harakat by using the ShowHarakat() HideHarakat() Methods. Please note that not all fonts support the Harakat well. Arial font and Arabic Typesetting font were tested and words well. The default is to show the Harakat.
2.	You can now use hindu numbers instead of the default of the font if needed. (٠	١	٢	٣	٤	٥	٦	٧	٨	٩) Use the UseHinduNumbers() and UseDeafultNumbers() method to switch your settings. The default value is not to use hindu numbers.
3.	4 Persian characters have been added (3.0): چژ گپ
4. Multiple lines are supported. However, you have to supply the breaklines to the Fix method yourself.

# Issues
## The text is not showing on your build?
1. Click on the font you are using in the project field.
2. In the inspector, find the "Character" field.
3. Change it from dynamic to unicode.

I hope you'll find this asset useful and enjoy using it!

# Contact
If you need any help with the asset, please contact me at: abdullah.konash@gmail.com or https://twitter.com/Konash

I'll be very happy if you showed me the game you used the plugin with! I don't mind a free copy of it either! 

Abdullah Konash
