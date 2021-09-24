using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    struct Student
    {
        int rollNo;
        string name;
        string gender;
        long mobile;


        public Student(int rollNo, string name, string gender, long mobile)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.gender = gender;
            this.mobile = mobile;

        }

        public string Display()
        {
            return string.Format("Roll No = {0}\t Name = {1}\t Gender = {2}\t Mobile = {3}", this.rollNo, this.name, this.gender, this.mobile);
        }
    }


}

