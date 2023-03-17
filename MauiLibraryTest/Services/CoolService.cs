using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiLibraryTest.Services;
public partial class CoolService
{
    [LibraryImport(libName)]
    internal static partial int getData();
    
    public int GetData()
    {
        return getData();
    }
}
