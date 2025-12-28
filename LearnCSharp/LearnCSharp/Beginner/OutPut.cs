
namespace LearnCSharp.Beginner
{
    internal class OutPut
    {
        public void Main()
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
            // LESS USED

            Console.Write("\n");
            // New line
            // abc\ndef -> abc
            //             def

            Console.Write("\r");
            // Carriage return
            // Bring the pointer to the beginning of the line
            // abcde\rxyz -> xyzde 
            // "xyz" overwrites "abc" because the pointer move to "a" and then start write "xyz"
            // Usually \n and \r are used together as \r\n in Windows environment
            // Because /r to return to the beginning of the line and /n to go down to the next line (Windows Only)
            // LESS USED

            Console.Write("\t"); // Horizontal tab
            // abc\txyz -> abc     xyz

            Console.Write("\v"); // Vertical tab
            // abc\vxyz -> abc
            //                xyz
            // LESS USED

            Console.Write("\'"); // Single quote
            // "char \'a\'" will display: char 'a'

            Console.Write("\""); // Double quote
            // "She said: \"Hello!\"" will display: She said: "Hello!"

            Console.Write("\\"); // Backslash
            // "C:\\Program Files\\" will display: C:\Program Files\
        }
    }
}
