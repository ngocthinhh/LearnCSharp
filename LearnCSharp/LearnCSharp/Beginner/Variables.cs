
using System.Text;

namespace LearnCSharp.Beginner
{
    internal class Variables
    {
        public void Main()
        {
            int x;
            // Declaration
            // Khai báo biến

            x = 10;
            // Initialization
            // Khởi tạo giá trị cho biến

            int y = 20;
            // Declaration + Initialization
            // Khai báo + Khởi tạo giá trị cho biến

            int z = x + y;

            Console.WriteLine($"Sum {x} and {y}: {z}");

            int intergetNumber;
            // Integer: Số nguyên

            double doubleNumber;
            // Double: Số thực

            float floatNumber;
            // Float: Số thực (nhỏ hơn Double)

            bool isTrue;
            // Boolean: Biến logic (true hoặc false)

            char character = 'a';
            // Character: Ký tự (single quote 'a')

            string text = "Hello C#";
            // String: Chuỗi ký tự (double quote "Hello C#")
            text = "Hello Guy";
            text += " with String";
            // Khi gán giá trị mới cho biến string
            // hoặc nối chuỗi
            // thì nó sẽ tạo ra một vùng nhớ mới chứ không phải thay đổi giá trị cũ

            StringBuilder stringBuilder = new StringBuilder("Hello C#");
            stringBuilder.Append(" with StringBuilder");
            // Khi nối chuỗi thì nó vãn ở trong vùng nhớ cũ
            stringBuilder = new StringBuilder("Hello Guy");
            // Chỉ tạo vùng nhớ mới khi sử dụng new

            string name = "John";
            string type01 = "Name " + name;
            string type02 = string.Format("Name {0}", name);
            string type03 = $"Name {name}";
            // 3 ways to concatenate string
            // 3 cách nối chuỗi

            // ============================= VALUE TYPES =============================
            // Value Types is stored in stack memory
            // -> Copy value variable to another variable will create a new copy in memory
            // Other types: Byte, SByte, Short, UShort, UInt, Long, ULong, Decimal, Struct, Enum ...

            // Sample 01:
            // int a = 10;
            // int b = 20;
            // int c = 10;
            // int d = a;
            // In Stack:
            // 10 <-- a
            // 20 <-- b
            // 10 <-- c
            // 10 <-- d
            // -> Different memory locations
            // -> Không dùng chung vùng nhớ

            // Sample 02:
            // Struct {int x; int y;}
            // Struct p1 = { 1, 2 };
            // Struct p2 = p1;
            // p1.x = 5;
            // p2.x is still 1
            // -> Copy is a new copy in memory
            // Mỗi lần copy sẽ tạo ra một bản sao mới trong bộ nhớ

            // Sample 03:
            // int a = 10;
            // 10 <-- a
            // a = 20;
            // 20 <-- a (overwrite)
            // -> Value types can be overwritten in the same memory location
            // -> Có thể ghi đè giá trị mới lên giá trị cũ trong cùng một vị trí bộ nhớ



            // ============================= REFERENCE TYPES =============================
            // Reference Types is stored in heap memory
            // -> Copy reference variable to another variable will point to the same memory address
            // Other types: Class, Object, Array, Delegate, Interface ...

            // Sample 01:
            // string a = "Hello";
            // string b = "World";
            // string c = "Hello";
            // string d = a;
            // "Hello" <-- a,c,d
            // "World" <-- b

            // Sample 02:
            // b = a;
            // "Hello" <-- a,c,d,b
            // "World" <-- (no reference) -> Garbage Collector will clean it up

            // Sample 03:
            // c = "New";
            // "Hello" <-- a,d,b
            // "New" <-- c

            // Sample 04:
            // int a[] = { 1, 2, 3 };
            // int b[] = a;
            // { 1, 2, 3 } <-- a,b
            // a[0] = 5;
            // { 5, 2, 3 } <-- a,b
            // => b[0] is also 5



            // ========================================================================
            // Int vs UInt
            // Int: -2,147,483,648 to 2,147,483,647
            // Int can store negative and positive values
            // Số âm, số dương và số 0
            // UInt: 0 to 4,294,967,295
            // UInt can only store positive values
            // Chỉ số dương và số 0
            // Khoảng chứa âm không có nhưng khoảng chứa dương thì lớn hơn gấp đôi so với Int
            // Aplly with all types have unsigned versions (Byte, Short, Long ...)
            // Áp dụng với mọi kiểu có unsigned (Byte, Short, Long ...)
        }
    }
}
