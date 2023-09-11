
using ConsoleApp1;
using System.Xml.Linq;
DocumentProgram d1 = new DocumentProgram();
Console.Clear();
string key;
Console.WriteLine("acar secin:");
key = Console.ReadLine();   
switch (key)
{
    case "basic":
      
        break;
    case "pro":
       d1= new ProDocumentProgram();
        break;
    case "expert":
      d1= new ExpertDocument();
        break;  
}


MyDelegate m1 = null;
m1 += d1.OpenDocumat;
m1 += d1.EditDocument;
m1 += d1.SaveDocument;

foreach (var item in m1.GetInvocationList())
{
    item.DynamicInvoke();
}