using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DZSerializDeSerializ.DeSerialization
{
    
        public interface IDeSerializatorStr
        {
            object DeSerializeToObj(string instr);
        }
        public class DeSerializeStr : IDeSerializatorStr
        {
            private readonly object _resobj = new F { };

            public object DeSerializeToObj(string instr)
            {
                Type type = _resobj.GetType();


                return _resobj;
            }
        }
        public class StrToObject
        {
            private readonly IDeSerializatorStr _testobj;

            private string _instr;

            public StrToObject(IDeSerializatorStr testobj,string instr )
            {
                _instr = instr;
                _testobj = testobj;
            }
            public object RunDeSerializeStr()
            {
                return _testobj.DeSerializeToObj(_instr);
            }
        }
    
}
