using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using DZSerializDeSerializ.Serialization;
using DZSerializDeSerializ.DeSerialization;
using System.Diagnostics;



namespace DZSerializDeSerializ
{
    [SimpleJob(RunStrategy.ColdStart,iterationCount:1)]
    [MinColumn, MaxColumn, MeanColumn, MedianColumn]
    public class ResultTest
    {
        private F _testObj = new F { i1 = 1, i2 = 2, i3 = 3, i4 = 4, i5 = 5 };
       
        [Benchmark]
        public void ObjectToStr()
        {   var stopwatch = new Stopwatch();
            stopwatch.Start();
            var testStr = new ObjectToStr(new SerializeStr(), _testObj);
            string resstr="";
            for (int i=0;i<1000;i++) resstr += testStr.RunSerializeStr();
           
         //   Console.WriteLine($"Result string: {resstr}");
            stopwatch.Stop();
            Console.WriteLine($"str ser: {stopwatch.ElapsedMilliseconds}");

            //var testobj = new StrToObject(new DeSerializeStr(), resstr);

        }
       // [Benchmark]
        public void ObjectToJson()
        {
            var testJson = new ObjectToJson(new SerializeJson(), _testObj);
            string resjs = testJson.RunSerializeJson();
          
            //var after = JsonSerializer.Deserialize<TestFile>(File.ReadAllText("json.json"));
        }
    }
    
}
