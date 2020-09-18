using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0917_PhoneBook
{
    public class PhoneInfo
    {
        string name;        // 필수
        string phoneNumber;     //필수
        string birth;       //선택
        public PhoneInfo()
        {
            
        }
        public PhoneInfo(string name, string num)
        {
            this.name = name;
            phoneNumber = num;
            
        }
        public PhoneInfo(string name, string num, string birth)
        {
            this.name = name;
            phoneNumber = num;
            this.birth = birth;
            
        }
        public void ShowPhoneInfo() // 입력한 내용 출력
        {
            if (name == "")
            {
                return;
            }
            Console.WriteLine("----------");
            Console.WriteLine($" 이름 : {name}");
            Console.WriteLine($" 번호 : {phoneNumber}");
            Console.WriteLine($" 생일 : {birth}");
            Console.WriteLine("----------");
        }

        public void Searchinfo(string data)
        {
            if (name == data)
            {
                Console.WriteLine("----------");
                Console.WriteLine($" 이름 : {name}");
                Console.WriteLine($" 번호 : {phoneNumber}");
                Console.WriteLine($" 생일 : {birth}");
                Console.WriteLine("----------");
            }
            else if (phoneNumber == data)
            {
                Console.WriteLine("----------");
                Console.WriteLine($" 이름 : {name}");
                Console.WriteLine($" 번호 : {phoneNumber}");
                Console.WriteLine($" 생일 : {birth}");
                Console.WriteLine("----------");
            }
            else if (birth == data)
            {
                Console.WriteLine("----------");
                Console.WriteLine($" 이름 : {name}");
                Console.WriteLine($" 번호 : {phoneNumber}");
                Console.WriteLine($" 생일 : {birth}");
                Console.WriteLine("----------");
            }
            
        }
        public void DeleteInfo(string data)
        {
            if (name == data)
            {
                name = "";
                phoneNumber = "";
                birth = "";
            }
            else if (phoneNumber == data)
            {
                name = name ="";
                phoneNumber = "";
                birth = "";
            }
            else if (birth == data)
            {
                name = "";
                phoneNumber = "";
                birth = birth = "";
            }
        }
    }
}
