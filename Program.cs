// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using SealedClass_Console.Services;

Console.WriteLine("Program start");

//// run on specific benchmark test class
//var summary = BenchmarkRunner.Run<PerformanceBenchmark>();

//// run all benchmark test classes (if having multiple benchmark test classes)
_ = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

Console.WriteLine("Program end");