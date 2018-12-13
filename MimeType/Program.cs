using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace MimeType
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
            int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.

            Dictionary<string, string> mimeTypes = new Dictionary<string, string>();
            HashSet<string> files = new HashSet<string>();
            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string EXT = inputs[0]; // file extension
                string MT = inputs[1]; // MIME type.
                mimeTypes[EXT.ToLower()] = MT;
            }
            for (int i = 0; i < Q; i++)
            {
                string FNAME = Console.ReadLine(); // One file name per line.
                files.Add(FNAME.ToLower());
            }

            foreach (string file in files)
            {
                string answer = "UNKNOWN";
                int lastPoint = file.LastIndexOf('.');
                if (lastPoint == -1)
                {
                    Console.WriteLine(answer);
                    continue;
                }

                if (lastPoint + 1 < file.Length)
                {
                    string extension = file.Substring(lastPoint + 1).ToLower();
                    if (mimeTypes.ContainsKey(extension.ToLower()))
                    {
                        answer = mimeTypes[extension];
                    }
                }
                Console.WriteLine(answer);
            }
        }
    }
}
