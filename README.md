AssemblyInfoTT
==============

Assembly info same for multiple projects

Let’s suppose you have a medium-big application and you have several dll-assemblies-component that the main application references( DAL, BLL). You have several deployments of the application at clients and , when a client , you must find each version of each assembly deployed.

 I have developed a simple .tt file to  ensure that every component that you compile have the same version – you can run on the server on the automatic build(http://www.olegsych.com/2010/04/understanding-t4-msbuild-integration/) or by hand.

More, with this .tt file you can 

Have the date /time ( with minute) of the compile of the dll embedded into version information
Read a text file and add same copyright to all projects( left as an exercise to the user) .




You can see the demo at http://youtu.be/PudBWl16308 .

You can download the project at http://msprogrammer.serviciipeweb.ro/2013/08/19/tt-files-to-maintain-assembly-version-in-sync

Steps:
1. Download the .tt file
2. Add to your project
3. Delete from folder Properties the AssemlbyInfo.cs file
4. Move the .tt file into folder Properties 

That's all!


