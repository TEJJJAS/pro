namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> lststu = new List<Students>
            {
                new Students { stuid = 1 , name ="tejas sonawane" , marks =80},
            new Students { stuid = 1, name = "tushar patil ", marks = 90 },
            new Students { stuid = 1, name = "tejas chaudhari", marks = 60 }

            };

            IEnumerable<Students> lst = from Students in lststu where Students.marks==80 select Students;

            foreach (Students sdt in lst)
            {
                Console.WriteLine(sdt.stuid + " "+sdt.name+" "+sdt.marks);

            }
        }
    }

    internal class Students
    {
        public int stuid;
        public string name;
        public int marks;

    }
}