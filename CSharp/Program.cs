namespace TextRPG
{

    // 객체(OOP Object Oriented Programming)

    // Knight

    // 속성: hp, attack
    // 기능: Move, Attack, Die

    // OOP(은닉성/상속성/다형성)

    // 은닉성(보안)
    // 자동차
    // 핸들 페잘 차문
    // 전기장치 엔진 기름 <-> 외부 노출
    //class Knight
    //{
        // 접근 한정자
        // public(수정) protected(할당된 클래스 한정 수정 가능) private(수정불가)

        //protected int hp;

    //}

    class SuperKnight : Knight
    {
        void Test()
        {
            hp = 10;
        }
    }




    class Player
    {
        // 필드
        static public int counter = 1; // 오로지 1개만 존재
        public int id;
        public int hp;
        public int attack;

        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
        }
    }

    // 오버로딩(함수 이름의 재사용): 함수이름 동일 인자만 다름 ex) Move(), Move(int position)
    // 오버라이딩: 어떤 함수에 실제 타입에 따라 다양한 형태로 동작을 하게함(다형성)
    class Mage : Player
    {
        public int mp = 10;
        public override void Move()
        {
            Console.WriteLine("Mage 이동!");
        }
    }
    class Archer : Player
    {

    }

    // Ref 참조
    class Knight : Player
    {
        public override void Move()
        {
            base.Move(); // 기존 Player에 있던 Move를 실행
            Console.WriteLine("Knight 이동!");
        }
    }

    // Copy 복사
    /*struct Mage
    {
        public int hp;
        public int attack;
    }*/

    // 스택(stack)
    // - 함수 호출과 관련된 지역 변수 및 함수 매개변수를 저장하는데 사용 ex) (Main 함수안에)mage, knight

    // 힙(heap)
    // - 프로그램이 실행되는 동안 필요한 메모리를 동적으로 할당하고 해제하는데 사용 ex) (struct Mage안에)hp, attack


    internal class Program
    {
        static void EnterGame(Player player)
        {
            Mage mage = (player as Mage);
            if(mage != null)
            {
                mage.mp = 10;
                mage.Move();
            }

        }

        static void Main(string[] args)
        {
            //Knight knight = Knight.CreateKnight();
            //knight.Move();// Knight.Move(); (x)
            Knight knight = new Knight();
            Mage mage = new Mage();

            knight.Move();
            mage.Move();

            Console.WriteLine();



            // 문자열 둘러보기
            string name ="Harry Poter";

            // 1.찾기
            bool found = name.Contains("Harry"); // name안에 Harry가 포함되어있는지 여부
            int index = name.IndexOf('z'); // name에 p가 몇번째열에 있는지를 반환 없을경우 -1

            // 2.변형
            name = name + " Junior"; // Harry Poter Junior로 변경
            string lowerCaseName = name.ToLower(); //글자를 전부 소문자로 변경
            string upperCaseName = name.ToUpper(); //글자를 전부 대문자로 변경
            string newName = name.Replace('r', 'l'); // r을 l로 변경

            // 3.분할
            string[] names = name.Split(new char[] { ' ' }); // 띄어쓰기 기준으로 배열로 나눔
            string subStringName = name.Substring(5); // 5번째이후 글자부터 가져옴
        }
    }
}
