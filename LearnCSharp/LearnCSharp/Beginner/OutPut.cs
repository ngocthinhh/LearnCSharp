
namespace LearnCSharp.Beginner
{
    internal class OutPut
    {
        void Main()
        {
            Console.Write("Just Display");

            Console.WriteLine("Display & Go Down");

            // This is a comment

            /*
             * This
             * is
             * a
             * multi-line
             * comment
             */

            Console.Write("\a"); 
            // Beep sound

            Console.Write("\b"); 
            // Backspace
            // abc\bde -> abde

            Console.Write("\f"); 
            // Formfeed
            // abc\fxyz -> abc
            //                xyz

            Console.Write("\n");
            // New line
            // abc\ndef -> abc
            //             def

            Console.Write("\r");
            // Carriage return
            // Bring the pointer to the beginning of the line
            // abcde\rxyz -> xyzde 
            // "xyz" overwrites "abc" because the pointer move to "a" and then start write "xyz"
            // Usually \n and \r are used together as \r\n in Windows environment because /r to return to the beginning of the line and /n to go down to the next line (Windows Only)

            Console.Write("\t"); // Horizontal tab

            Console.Write("\v"); // Vertical tab

            Console.Write("\'"); // Single quote

            Console.Write("\""); // Double quote

            Console.Write("\\"); // Backslash
        }
    }
}
