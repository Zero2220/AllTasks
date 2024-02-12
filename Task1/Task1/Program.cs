namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullname;
            string GroupName;
            Console.WriteLine("Adi daxil edin");
            fullname = Console.ReadLine();
            Console.WriteLine("GroupNoyu daxil edin ");
            GroupName = Console.ReadLine();

            Student student = new Student();
            student.groupNo = GroupName;
            student.fullname = fullname;
            
        }
    }
}
