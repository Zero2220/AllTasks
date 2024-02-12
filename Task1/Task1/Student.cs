using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Student
    {
        public string fullname;
        public string groupNo;
        private string Fullname
        {
            get { return Fullname; }
            set
            {
                if (CheckFullName(value))
                {
                    fullname = value;
                }

            }
        }
        private string GroupNo
        {
            get { return GroupNo; }
            set
            {
                if (CheckGroupName(value))
                {
                    groupNo = value;
                }
            }
        }
        public int Age;

        



        private static bool CheckFullName(string fullname) 
        {
          fullname.Trim();
            if(fullname.Contains(' '))
            {
                int index =fullname.IndexOf(' ');
                string lastName = fullname.Substring(index);
                if(!lastName.StartsWith(' '))
                {

                    return true;
                }
                else return false;


            }
            else
            {
                 return false;
            }

        }
        public static bool CheckGroupName(string GroupName)
        {
            GroupName.Trim();

            if (GroupName.Length ==4)
            {
                if (!GroupName.Contains(' '))
                {
                    if (Char.IsLetter(GroupName[0]))
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;

            }
            else return false;
        }
    }
}
