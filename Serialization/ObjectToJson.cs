using System.Text.Json;


namespace DZSerializDeSerializ.Serialization
{
    
        public interface ISerializatorJson
        {
            string SerializeToJson(object obj);
        }
        public class SerializeJson : ISerializatorJson
        {
            public string SerializeToJson(object obj)
            {
                return JsonSerializer.Serialize(obj);
            }
        }
        public class ObjectToJson
        {
            private readonly ISerializatorJson _jsbild;

            private object _testobj;
           
            public ObjectToJson(ISerializatorJson jsbild, object testobj)
            {
                _jsbild = jsbild;
                _testobj = testobj;
            }
            public string RunSerializeJson()
            {
                return _jsbild.SerializeToJson(_testobj);
            }
        }
}
