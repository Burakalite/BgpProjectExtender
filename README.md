# BgpProjectExtender

A DriveWorks Project extender adding the new custom function "PopulateMasterFileProperty" for use within DriveWorks Administrator. 

The function can be used directly within the base rules found under the **Model Rules** tab in the task explorer, and allows population of all file name, configuration, and user-assigned custom properties for all master parts, drawings, and assemblies - with a singular rule. 

The function achieves this with use of a calculation table and the DriveWorks myName() function, written in the single form: 

`<PopulateMasterFileProperty(CalcTable, myName())>`

The above rule can replace all of the mentioned base Model Rules with this one rule, simplyfying project maintainability by consolidating these rules in an informative calculation table, and eliminating the set of unique rules under Model Rules that would otherwise be required for each custom property, file name, configuration, etc.

The Calculation table used must include the master part/assembly/drawing names in the first column, and the associated custom properties in the header row, example:

![GitHub Logo](/calctable.png)
Format: ![Alt Text](url)