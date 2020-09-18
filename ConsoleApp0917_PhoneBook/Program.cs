using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0917_PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBookManager manager = new PhoneBookManager();

            while(true)
            {
                manager.ShowMenu();
                int choice = Utility.ConvertInt(Console.ReadLine());

                switch(choice)
                {
                    case 1: manager.InputData(); break;
                    case 2: manager.ListData(); break;
                    case 3: manager.SearchData(); break;
                    case 4: manager.DeleteData(); break;
                    case 5: Console.WriteLine("프로그램을 종료합니다."); return;
                    default: Console.WriteLine("다시 입력해주세요"); break;
                }    
            }
        }
    }
}
/* phonebook 
 * phoneinfo 에서 상속받아서 학교(과,학년) 회사(회사이름) 동아리(동아리 이름) 출력
 * 
 */