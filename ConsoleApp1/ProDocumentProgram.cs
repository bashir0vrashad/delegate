namespace ConsoleApp1
{
    internal class ProDocumentProgram : DocumentProgram
    {
        public void OpenDocumat() { Console.WriteLine("Document Opened"); }
        public sealed override void EditDocument() { Console.WriteLine("Document Edited"); }
        public sealed override void SaveDocument() { Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet"); }

        public ProDocumentProgram() { Console.WriteLine("ProDocumentProgram default constructor"); }
    }
}
