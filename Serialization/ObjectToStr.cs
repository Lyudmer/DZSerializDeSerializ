using System.Reflection;
using System.Text;


namespace DZSerializDeSerializ.Serialization
{
    public interface ISerializatorStr
    {
        string SerializeToString(object obj);
    }
    public class SerializeStr : ISerializatorStr
    {
        private readonly StringBuilder _strbild = new StringBuilder();
        public string SerializeToString(object obj)
        {

            Type type = obj.GetType();
            foreach (PropertyInfo property in type.GetProperties())
            {
                _strbild.Append($"{property.Name}: {property.GetValue(obj)}, ");
            }

            foreach (FieldInfo field in type.GetFields())
            {
                _strbild.Append($"{field.Name}: {field.GetValue(obj)}, ");
            }

            return _strbild.ToString().TrimEnd(',', ' ');
        }
    }
    public class ObjectToStr
    {
        private readonly ISerializatorStr _strbild;

        private object _testobj;
      
        public ObjectToStr(ISerializatorStr strbild, object testobj)
        {
            _strbild = strbild;
            _testobj = testobj;
            

        }
        public string RunSerializeStr()
        {
           return _strbild.SerializeToString(_testobj);
        }
    }

}
