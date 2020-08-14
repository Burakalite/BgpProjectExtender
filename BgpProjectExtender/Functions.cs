using System;
using DriveWorks.Extensibility;
using Titan.Rules.Common;
using Titan.Rules.Execution;

namespace BlueGiant
{
    public class Functions : ProjectExtender
    {
        [Udf(true)]
        [FunctionInfo("A universal function to populate all file name, configuration, and user assigned custom properties for all captured master parts, drawings, and assemblies. Requires calculation table with master file names in first column, and master property names in header row - as given by the MyName() function.", "SDK Function")]
        public object PopulateMasterFileProperty([ParamInfo("CalcTable", "The calculation table with the file property rules.")] IArrayValue calcTable, [ParamInfo("MyName() return", "Always use myName() function here.")] string myName)
        {
            if (myName.StartsWith("DWVariable")) return "Cannot apply function inside variable rules, use function directly within Model Rules";

            string[] myNameSplitList = myName.Split('\\');

            string masterFileName = myNameSplitList[myNameSplitList.Length - 2];
            string filePropertyName = myNameSplitList[myNameSplitList.Length - 1];

            int columnIndex = (int)TableFunctions.TableGetColumnIndexByName(calcTable, filePropertyName, true) - 1;

            string firstColumnPipebarList = (string)TableFunctions.ListAll(calcTable, 1);
            string[] firstColumnSplitList = firstColumnPipebarList.Split('|');
            int rowIndex = Array.IndexOf(firstColumnSplitList, masterFileName) + 1;

            return calcTable.GetElement(rowIndex, columnIndex);
        }
    }
}