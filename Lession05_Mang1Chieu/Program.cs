using Lession05_Mang1Chieu;

Console.WriteLine("làm việc với mảng 1 chiều!");
// Khai báo 
int[] a;
int[] b = new int[10];
int[] c = new int[] { 10, 2, 3, 6 };
int[] d = { 11, 44, 22, 33, 445 };

string[] strName = new string[10];
string[] value = { "H", "jj" };
// Truy cập đến các phần tử 
b[0] = 100;
strName[0] = "Devmaster";
// Lấy giá trị 
Console.WriteLine("Truy cập lấy gt:{0},{1} \n", b[0], strName[0]);
// Duyệt mảng : for, do while, foreach, while,...
Console.WriteLine("In pt trong mảng c:");
for (int i = 0; i < c.Length; i++)
{
    Console.Write("{0};", c[i]);
}
// gán gt ngẫu nhiên 
for (int i = 0; i < b.Length; i++)
{
    b[i] = (new Random()).Next(10, 99);
}
// in gt 
foreach (var item in b)
{
    Console.WriteLine(item);
}

// sử dụng mảng với lớp đối tượng 
Student[] students = new Student[10];
for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine("Nhập sv thứ: " + i);
    students[i] = new Student();
    Console.WriteLine("ID:");
    students[i].Id = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Name:");
    students[i].Name = Console.ReadLine();
    Console.WriteLine("Age:");
    students[i].Age = Console.ReadLine();
}
Console.WriteLine("In ds sv");
foreach (var item in students)
{
    item.Display();
}
// sx theo tuổi 
Array.Sort(students, (x,y) => {return  });
// sx 
/*
Array.Sort(b);
Console.WriteLine();
foreach(var item in b)
{
    Console.WriteLine("{0}", item);
}
Console.WriteLine();
Array.Reverse(b);

foreach(var item in b)
{
    Console.Write("{0}", item);
}
Console.WriteLine();

*/