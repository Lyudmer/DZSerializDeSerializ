using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using DZSerializDeSerializ;
using DZSerializDeSerializ.Serialization;
using System.Text;

Console.WriteLine("Тест сериализация / десериализация");
BenchmarkRunner.Run<ResultTest>();
Console.WriteLine("end");

