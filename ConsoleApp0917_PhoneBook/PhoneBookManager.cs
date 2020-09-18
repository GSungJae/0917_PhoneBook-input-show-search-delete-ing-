using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0917_PhoneBook
{
    public class PhoneBookManager
    {
        const int MAX_CNT = 100;
        PhoneInfo[] infoStorage = new PhoneInfo[MAX_CNT];
        PhoneInfo info = new PhoneInfo();
        int curCnt = 0;
        public void ShowMenu()
        {
            Console.WriteLine("-----------------주소록-----------------");
            Console.WriteLine("1.입력  |  2.목록  |  3.검색  |  4.삭제  |  5.종료");
            Console.WriteLine("------------------------------------------------");
            Console.Write("선택: ");      
        }

        public void InputData()
        {
            Console.Write("이름을 입력해주세요(필수). :");
            string name = Console.ReadLine();
            Console.Write("번호를 입력해주세요(필수). :");
            string num = Console.ReadLine();
            Console.Write("생일을 입력해주세요(선택). :");
            string birth = Console.ReadLine();
            if (name != "" && num != "")
            {
                if (birth == "")
                    infoStorage[curCnt] = new PhoneInfo(name, num);
                else
                    infoStorage[curCnt] = new PhoneInfo(name, num, birth);
                curCnt++;
            }
            else
                Console.WriteLine("이름과 번호 모두 입력해주세요.");
        }

        public void ListData()
        {
            if (curCnt != 0)
            {
                for (int user = 0; user < curCnt; user++)
                {
                    if (curCnt != 0)
                        infoStorage[user].ShowPhoneInfo();
                }
            }
            else
                Console.WriteLine("입력된 정보가 없습니다.");
        }

        public void SearchData()
        {
            if (curCnt != 0)
            {
                Console.Write("찾을 데이터를 입력해주세요 : ");
                string data = Console.ReadLine();
                for (int user = 0; user < curCnt; user++)
                {
                        infoStorage[user].Searchinfo(data);
                }
            }
            else
                Console.WriteLine("입력된 정보가 없습니다.");
        }

        public void DeleteData()
        {
            if (curCnt != 0)
            {
                Console.Write("삭제할 데이터를 입력해주세요 : ");
                string data = Console.ReadLine();
                for (int user = 0; user < curCnt; user++)
                {
                    infoStorage[user].DeleteInfo(data);
                }
                
            }
            else
                Console.WriteLine("입력된 정보가 없습니다.");
        }
    }
}
