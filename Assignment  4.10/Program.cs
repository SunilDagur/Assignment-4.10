using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__4._10
{
    using System;

    [Flags]
    enum FilePermission
    {
        None = 0,
        Read = 1 << 0,    
        Write = 1 << 1,   
        Execute = 1 << 2  
    }

    class Program
    {
        static void Main()
        {
            
            FilePermission userPermissions = FilePermission.Read | FilePermission.Write;

           
            bool canRead = (userPermissions & FilePermission.Read) == FilePermission.Read;
            bool canWrite = (userPermissions & FilePermission.Write) == FilePermission.Write;
            bool canExecute = (userPermissions & FilePermission.Execute) == FilePermission.Execute;

            Console.WriteLine($"User can read: {canRead}");
            Console.WriteLine($"User can write: {canWrite}");
            Console.WriteLine($"User can execute: {canExecute}");
        }
    }

}
