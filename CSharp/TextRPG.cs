namespace TextRPG
{
    internal class TextRPG
    {
        static void TextRpg(string[] args)
        {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            while (true)
            {

                int job = Convert.ToInt32(Console.ReadLine());

                if (job == 1)
                {
                    Console.WriteLine("기사를 선택하셨습니다");
                    break;
                }
                else if (job == 2)
                {
                    Console.WriteLine("궁수를 선택하셨습니다");
                    break;
                }
                else if (job == 3)
                {
                    Console.WriteLine("법사를 선택하셨습니다");
                    break;
                }
                else
                {
                    Console.WriteLine("다시 선택해주세요");
                }
            }
        }
    }
}