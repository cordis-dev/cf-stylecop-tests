using System;
using System.Collections.Generic;
using System.IO;

namespace Tests
{
    public class UsingDeclarations
    {
        static int WriteLinesToFile(IEnumerable<string> lines)
        {
            // classic
            using (var streamReader = new StreamReader("ReadToEnd.txt"))
            {
                Console.Write(streamReader.ReadToEnd());
            };

            using var file = new System.IO.StreamWriter("WriteLines2.txt");
			
			
			// with await
			await using SilkDbContext db = GetContext();
			
            int skippedLines = 0;
            foreach (string line in lines)
            {
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
                else
                {
                    skippedLines++;
                }
            }
            // Notice how skippedLines is in scope here.
            return skippedLines;
            // file is disposed here
        }
    }
}