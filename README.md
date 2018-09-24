# ActOnShapeSelection

The purpose of this project is explained in detail at https://www.codeproject.com/Articles/1228441/Creating-a-Visio-Add-In-in-VS.

How can I in Visio change the color to a previously selected color just by selecting a shape?
Sounds simple enough, but there are some caveats, so here is my attempt to tackle this problem. The main caveats were:
* hooking up the SelectionChanged event
* keeping and accessing the state in the Ribbon (for the default color)
* setting the color of the selected shape
