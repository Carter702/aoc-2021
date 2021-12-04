using System.Diagnostics;

var increases = 0;
const int BufferSize = 128;
const string Filename = "input_day1.txt";
var stopWatch = new Stopwatch();

using var fileStream = File.OpenRead(Filename);
using var streamReader = new StreamReader(fileStream, System.Text.Encoding.UTF8, true, BufferSize);

var prevLine = streamReader.ReadLine();
var line = "";
stopWatch.Start();

while( (line = streamReader.ReadLine()) != null ){
    increases += (int.Parse(prevLine) < int.Parse(line)) ? 1 : 0;
    prevLine = line;
}

stopWatch.Stop();
Console.WriteLine($"Finished in {stopWatch.Elapsed.Milliseconds} ms, Increases: {increases}");