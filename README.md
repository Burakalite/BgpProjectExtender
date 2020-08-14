# BgpProjectExtender

A DriveWorks Project Extender adding the new custom function "PopulateMasterFileProperty" for use within DriveWorks Administrator. 

The function is used directly within the base rules found under the **Model Rules** tab in the Task Explorer, and allows population of all file name, configuration, and user-assigned custom properties for all master parts, drawings, and assemblies - with a single rule. 

The function achieves this with use of a calculation table and the DriveWorks myName() function, written in the single form: 

`PopulateMasterFileProperty(CalcTable, myName())`

The above rule can replace all of the mentioned base Model Rules, simplyfying project maintainability by consolidating these rules in an informative calculation table, and eliminating the set of unique rules under Model Rules that would otherwise be required for each custom property, file name, configuration, and custom property rule.

The calculation table used must include the master part/assembly/drawing names in the first column, and the associated custom properties for myName() to find within the header row, example:

![CalcTable](https://user-images.githubusercontent.com/43711346/90264322-eb857a80-de1e-11ea-9e3f-966d881bb909.png)

To use, place release .dll file in the same file path as your DriveWorks project, and change the name to match the DriveWorks project as well.
