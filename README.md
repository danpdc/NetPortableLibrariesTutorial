# NetPortableLibrariesTutorial
This is a very brief tutorial on how to create your own C# libraries targeting the .Net Standard.
You can package these libraries as NuGet packages (either local ora on nuget.org) and easily reuse them in other projects.
For demo purposes the libraries will just return a Fibonacci sequence as a string

# How to run this sample

This sample is very easy to run. Just clone or download this repository and build the solution. 
You'll find several projects. 

* Dummy1 - is a library that targets the .Net Standard
* Dumm2 (sorry for the spelling mistake) - targets .Net Core
* FibConsoleCore - is a .Net Core console application
* FibConsoleFramework - is a .Net Framework console application

By default, both console apps have Dummy1 as a dependency. 

# Play around

To play around you can go to the console apps, right click the project and choose "Manage NuGet packages". There you can uninstall the existing package, which will remove the reference.
You can then go to Dummy 1 and Dumm2 and build you own local NuGet packages. To do this, follow these steps on each project: 

1. Right click the project and choose "Properties";
2. On the left menu choose "Package"
3. Fill out the package information fields and check the "Generate NuGet package at build" checkbox;
4. In the Visual Studio menu bar, choose "Release", instead of "Debug";
5. Right click he project again and choose "Build"

A NugetPackage will be created in the default target folder for release. You can now go to the console apps and install your brand new packages

You will notice that you won't be able to install Dumm2 in FibConsoleFramework, since it targets .Net Core and the console app targets .Net Framework
You will however be able to install Dummy1 in both console applications, since Dummy1 targets the .Net Stadard. 
That's the whole idea behind this tutorial. If you want to create your own libraries that shoul be reusable in all projects, you should target the .Net Standard. 
