namespace ConsoleApp1
{

    delegate void MyDelegate();



    internal class DocumentProgram
    {
        public void OpenDocumat() { Console.WriteLine("Document Opened"); }
        public virtual void EditDocument() { Console.WriteLine(" Can Edit in Pro and Expert versions"); }
        public virtual  void SaveDocument() { Console.WriteLine(" Can Save in Pro and Expert versions"); }

        public DocumentProgram() { Console.WriteLine("DocumentProgram default constructor"); }
    }
}
