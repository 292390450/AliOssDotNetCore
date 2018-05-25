using System;
using Aliyun.OSS;

namespace OssTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            OssClient client=new OssClient("","","");
        }
    }
}
