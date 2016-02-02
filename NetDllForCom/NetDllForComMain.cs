using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*to expose types in an assembly to COM applications*/
/*1:Classes should implement interfaces explicitly.*/
/* can set ClassInterface but better to implement interfaces explicitly*/
/*2:Managed types must be public.*/
/*3:Methods, properties, fields, and events must be public.*/
/*4:Types must have a public default constructor to be activated from COM.*/
/*5:Types cannot be abstract.*/
namespace NetDllForCom
{
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("NetDllForCom.NetDllForComMain")]
    public class NetDllForComMain
    {
        public NetDllForComMain() { }
        /// <summary>
        /// GetSum
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int getSum(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// CompareValue
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool compareValue(int x, int y)
        {
            return x >= y ? true : false;  
        }
    }
}
