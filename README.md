![NClassDotNetCore](/src/GUI/icons/nclass_small.png)

# NClassDotNetCore

This is an attempt to port [NClass v2.4](http://nclass.sourceforge.net/index.html) by Balazs Tihanyi to .NET Core.

.NET Core is a cross-platform framework and now supports WinForms but .NET Core + WinForms will only work on a Windows operating system. Since NClass is based on WinForms technology, therefore this project will only work on Windows. We curently have no plans to port or convert NClass to a modern UI frameworks such as [WinUI3](https://blogs.windows.com/windowsdeveloper/2020/07/07/a-deep-dive-into-winui-3-in-desktop-apps/) or [.NET Maui](https://docs.microsoft.com/en-us/dotnet/maui/what-is-maui).

![screenshot](/images/screenshot1.PNG)

# Overview

NClass is a free tool to easily create UML class diagrams with full C# and Java language support. The user interface is designed to be simple and user-friendly for easy and fast development. Properties, enums, delegates and other language specific elements are fully supported with strict syntactical and semantical verification.

Design your application with just a few clicks - the main goal is to provide a simple but powerful class designer that is very intuitive to use. Diagram styles help you to create professional looking diagrams, just like in Visual Studio or other commercial products. Furthermore, you can generate code from your models or you can also import classes from existing .NET assemblies.
Please note, NClass is far from complete. There are many missing features that are planned for future versions. But if you have an idea, please share your thoughts in one of the way listed on the [support](http://nclass.sourceforge.net/support.html) page.

# Features
* Full C# and Java support with many language specific elements
* Simple and easy to use user interface
* Inline class editors with syntactic parsers for easy and fast editing
* Source code generation
* Reverse engineering from .NET assemblies (thanks to Malte Ried)
* Configurable diagram styles
* Printing / saving to image
* Multilingual user interface

# Other NClass Projects

Here are other NClass projects on [GitHub](https://github.com/search?q=nclass+uml&type=Repositories).

# How to build

* Use [Visual Studio 2019 Community Edition](https://visualstudio.microsoft.com/vs/older-downloads/) or [Visual Studio 2022 Community Edition](https://visualstudio.microsoft.com/vs/community/)

* Run PowerShell script

```
Build-Sources.ps1
```

# Visual Studio Extensions (recommended)

The following additional Visual Studio Extensions are recommended:

* [ResXManager](https://marketplace.visualstudio.com/items?itemName=TomEnglert.ResXManager)
* [Microsoft Visual Studio Installer Projects](https://marketplace.visualstudio.com/items?itemName=visualstudioclient.MicrosoftVisualStudio2017InstallerProjects)
