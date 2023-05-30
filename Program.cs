using System.Drawing;
using System.Drawing.Imaging;

string CurrFolder = Environment.CurrentDirectory;

var folder = CurrFolder;
int count = 0;

foreach (string file in Directory.GetFiles(folder))
{
    string ext = Path.GetExtension(file).ToLower();
    if (ext == ".png")
    {
        Console.WriteLine(file);
        string name = Path.GetFileNameWithoutExtension(file);

        Image png = Image.FromFile(file);

        png.Save(CurrFolder + @"/" + name + ".jpg", ImageFormat.Jpeg);
        png.Dispose();

        count++;
        File.Delete(file);

    }
}

Console.WriteLine("{0} file(s) converted.", count);
Console.ReadLine();