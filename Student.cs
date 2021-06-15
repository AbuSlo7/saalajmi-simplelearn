using System;

namespace saalajmi
{
    public class Student
    {
        private string id;
        private string name;
        private string _class;
        private string section;
        public Student()
        {
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }

        public string Section
        {
            get { return section; }
            set { section = value; }
        }
    }
}