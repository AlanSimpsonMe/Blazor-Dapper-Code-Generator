using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
// Used https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings for this.
// Gets the .NET type for a SQL Server data type.
static class TypeMapper
{
    public static readonly Dictionary<string, string> _dict = new Dictionary<string, string>
    {
        {"bigint", "int"},
        {"binary", "Byte[]"},
        {"bit", "bool"},
        {"char", "string"},
        {"date", "DateTime"},
        {"datetime", "DateTime"},
        {"datetime2", "DateTime"},
        {"datetimeoffset", "DateTimeOffset"},
        {"decimal", "decimal"},
        {"float", "double"},
        {"image", "byte[]"},
        {"int", "int"},
        {"money", "decimal"},
        {"nchar", "string"},
        {"ntext", "string"},
        {"numeric", "decimal"},
        {"nvarchar", "string"},
        {"nvarcharmax", "string"},
        {"real", "decimal"},
        {"rowversion", "byte[]"},
        {"smalldatetime", "DateTime"},
        {"smallint", "int"},
        {"smallmoney", "decimal"},
        {"sql_variant", "object"},
        {"text", "string"},
        {"time", "TimeSpan"},
        {"timestamp", "byte[]"},
        {"tinyint", "int"},
        {"uniqueidentifier", "string"},
        {"varbinary", "byte[]"},
        {"varbinarymax", "byte[]"},
        {"varchar", "string"},
        {"varcharmax", "string"},
        {"xml", "string"},
    };

    // Access the Dictionary from external sources
    public static string GetNetType(string word)
    {
        // Try to get the result in the static Dictionary
        string result;
        if (_dict.TryGetValue(word, out result))
        {
            return result;
        }
        else
        {
            return null;
        }
    }

    public static readonly Dictionary<string, string> _htmltypes = new Dictionary<string, string>
            {
        {"byte","text" },
        {"byte[]","file" },
        {"int", "number"},
        {"float", "number"},
        {"decimal", "number"},
        {"double", "number"},
        {"bool", "checkbox"},
        {"string", "text"},
        {"Date", "date"},
        {"DateTime","date"},
        {"DateTimeOffset","datetime-local"},
        {"image", "image"},
        {"object", "file"},
        {"TimeSpan", "time"},
        {"TimeStamp", "time"},
        {"xml", "string"}
    };

    // Access the Dictionary from external sources
    public static string GetHtmlType(string word)
    {
        // Try to get the result in the static Dictionary
        string result;
        if (word != null && _htmltypes.TryGetValue(word, out result))
        {
            return result;
        }
        else
        {
            return null;
        }

    }

    // Using https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings again
    public static readonly Dictionary<string, string> _dbtypes = new Dictionary<string, string>
    {
        {"bigint", "Int64"},
        {"binary", "Binary"},
        {"bit", "Boolean"},
        {"char", "Char"},
        {"date", "Date"},
        {"datetime", "DateTime"},
        {"datetime2", "DateTime2"},
        {"datetimeoffset", "DateTimeOffset"},
        {"decimal", "Decimal"},
        {"float", "Decimal"},
        {"image", "Binary"},
        {"int", "Int32"},
        {"money", "Decimal"},
        {"nchar", "String"},
        {"ntext", "String"},
        {"numeric", "Decimal"},
        {"nvarchar", "String"},
        {"nvarcharmax", "String"},
        {"real", "Decimal"},
        {"rowversion", "Timestamp"},
        {"smalldatetime", "DateTime"},
        {"smallint", "Int16"},
        {"smallmoney", "Decimal"},
        {"sql_variant", "Object"},
        {"text", "String"},
        {"time", "Time"},
        {"timestamp", "Object"},
        {"tinyint", "Int16"},
        {"uniqueidentifier", "Guid"},
        {"varbinary", "Binary"},
        {"varbinarymax", "Binary"},
        {"varchar", "String"},
        {"varcharmax", "String"},
        {"xml", "Xml"},
    };
    // Access the Dictionary from external sources
    public static string GetDBType(string word)
    {
        // Try to get the result in the static Dictionary
        string result;
        if (word != null && _dbtypes.TryGetValue(word, out result))
        {
            return result;
        }
        else
        {
            return null;
        }

    }
}
