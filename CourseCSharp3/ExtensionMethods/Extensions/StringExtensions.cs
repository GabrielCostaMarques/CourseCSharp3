namespace System;

internal static class StringExtensions
{

    //método estende o string e coloca o int count como parâmetro
    public static string Cut(this string thisObj, int count)
    {
        if (thisObj.Length <= count)
        {
            return thisObj;
        }
        else
        {
            //
            return thisObj.Substring(0, count)+"...";
        }
    }
}
