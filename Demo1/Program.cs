using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>
            {
                new Student(){studentID=1, studentName="张三" ,isArts=false,chineseGrade=127,mathematicsGrade=145,englishGrade=122,overallGrade=289},
                new Student(){studentID=1, studentName="刘亮" ,isArts=true,chineseGrade=103,mathematicsGrade=145,englishGrade=122,overallGrade=250},
                new Student(){studentID=1, studentName="薛贵" ,isArts=true,chineseGrade=136,mathematicsGrade=102,englishGrade=89,overallGrade=189},
                new Student(){studentID=1, studentName="吴迪" ,isArts=true,chineseGrade=126,mathematicsGrade=98,englishGrade=140,overallGrade=238}
            };
            //筛选文科
            var quer = list.Where(s => s.isArts==true );
            Console.WriteLine("文科生有：");
            foreach (var stu in quer)
            {
                Console.WriteLine("姓名：{0} 语文：{1}分 数学：{2}分  英语：{3}分 综合：{4}分",stu.studentName,stu.chineseGrade,stu.mathematicsGrade,stu.englishGrade,stu.overallGrade);
            }
           //求所有文科生的总成绩的平局成绩
            var quer1 = list.Where(s => s.isArts == true).Average(s=>s.overallGrade+s.chineseGrade+s.mathematicsGrade+s.englishGrade);
            Console.WriteLine("平均成绩：{0}", quer1);
            
            Console.ReadLine();
        }
    }
}
