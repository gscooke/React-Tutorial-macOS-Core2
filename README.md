# React-Tutorial-macOS-Core2
The ReactJS.Net tutorial refactored to work using Visual Studio for macOS and .net core 2

I have followed the steps and found various bits of information to ensure the tutorial now works.

Firstly we've had to force .net core 2 support in the macOS environment by installing the .net core 2.0 preview 1, and then modifying the csproj file for the 1.1 application appopriately according to this guide:
https://gist.github.com/mrward/70b8132003ef77d893111ecbea3e2225

Secondly, we've had to abandon the standard Vroom JavaScript engine that is used and replace it with Jint. It's slower (apparently) but at least it works. I have noted the changes in the startup.cs file so they can be commented if this is ported to Windows. Or maybe we can sense the environment at some point.
Again, this was achieved after some research and this thread:
https://github.com/reactjs/React.NET/issues/338

That's about it
