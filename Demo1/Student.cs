using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Student
    {
        //id
        public  int studentID { get; set; }
        //姓名
        public  string studentName { get; set; }
        //是否是文科
        public  bool isArts { get; set; }
        //语文成绩
        public  double chineseGrade { get; set; }
        //数学成绩
        public  double mathematicsGrade { get; set; }
        //英语成绩
        public  double englishGrade { get; set; }
        //综合成绩overall
        public double overallGrade { get; set; }
    }
}
