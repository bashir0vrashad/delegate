namespace ConsoleApp1
{
    internal class ExpertDocument : ProDocumentProgram
    {
        public void OpenDocumat() { Console.WriteLine("Document Opened"); }
        public   void EditDocument() { Console.WriteLine("Document Edited"); }
        public   void SaveDocument() { Console.WriteLine("Document Saved in pdf format"); }
        public ExpertDocument() { Console.WriteLine("ExpertDocument default constructor"); }
    }
}
