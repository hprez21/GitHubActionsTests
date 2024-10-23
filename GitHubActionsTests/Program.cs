Console.WriteLine("Hello, GitHub learners!");
Console.WriteLine("Creating txt file");

// Get the current directory and print it
string path = Path.Combine(Directory.GetCurrentDirectory(), "test.txt");
Console.WriteLine($"File will be created at: {path}");

// Create a new file in the current directory.
using (FileStream fs = File.Create(path))
{
    Byte[] info = new System.Text.UTF8Encoding(true).GetBytes("This is some text in the file.");
    // Add some information to the file.
    fs.Write(info, 0, info.Length);
}

Console.WriteLine("File created successfully"); 
