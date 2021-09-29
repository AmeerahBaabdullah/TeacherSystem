using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ConsoleApp1
{
    class Teacher
    {

        private int ID_;
        private string Name_;

        private string Section_;
        private string ClassName_;

        public Teacher()
        {
            Name_ = "0";
            ID_ = 0;
            ClassName_ = "";
            Section_ = "";
        }

        public Teacher(int id, string n, string c, string s)
        {
            ID_ = id;
            Name_ = n;
            ClassName_ = c;
            Section_ = s;
        }
        public Teacher(string filerow)
        {
            string[] arr = filerow.Split(',');

            ID_ = Convert.ToInt32(arr[0]);
            Name_ = arr[1];
            ClassName_ = arr[2];
            Section_ = arr[3];
        }


        // properties of attributes
        public string Name
        {
            get { return Name_; }
            set { Name_ = value; }
        }
        public int ID
        {
            get { return ID_; }
            set { ID_ = value; }
        }

        public string ClassName
        {
            get { return ClassName_; }
            set { ClassName_ = value; }
        }

        public string Section
        {
            get { return Section_; }
            set { Section_ = value; }
        }


        public string BuildFileRow()
        {

            string s = "";
            s += ID_.ToString();
            s += ",";
            s += Name_;
            s += ",";
            s += ClassName_;
            s += ",";
            s += Section_;

            return s;
        }

        public void printInfo()
        {
            Console.Write("ID:" + ID);
            Console.Write("\tName:" + Name);
            Console.Write("\tSection:" + Section);
            Console.Write("\tClass:" + ClassName_);
            Console.WriteLine();

        }

    }
}
