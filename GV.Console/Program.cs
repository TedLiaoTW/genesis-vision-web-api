using Ipfs;
using System;
using System.IO;

namespace GV.WebApi.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ipfs = new IpfsClient())
            {
                //Name of the file to add
                string fileName = "test.txt";

                //Wrap our stream in an IpfsStream, so it has a file name.
                IpfsStream inputStream = new IpfsStream(fileName, File.OpenRead(fileName));

                MerkleNode node = ipfs.Add(inputStream).Result;

                Stream outputStream = ipfs.Cat(node.Hash.ToString()).Result;

                using (StreamReader sr = new StreamReader(outputStream))
                {
                    string contents = sr.ReadToEnd();

                    System.Console.WriteLine(contents); //Contents of test.txt are printed here!
                }
            }
        }
    }
}