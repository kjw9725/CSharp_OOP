namespace TextRPG
{

    // 객체(OOP Object Oriented Programming)

    // Knight

    // 속성: hp, attack
    // 기능: Move, Attack, Die

    // OOP(은닉성/상속성/다형성)
    class Player
    {
        // 필드
        static public int counter = 1; // 오로지 1개만 존재
        public int id;
        public int hp;
        public int attack;
    }
    class Mage : Player
    {

    }
    class Archer: Player
    {

    }

    // Ref 참조
    class Knight: Player
    {

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }

        // 생성자
        public Knight()
        {
            id = counter;
            counter++;
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출");
        }

        public Knight(int hp) : this() // this() 원래 Knight()를 호출
        {
            this.hp = hp;
            Console.WriteLine("int 생성자 호출");
        }

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
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

        static void Main(string[] args)
        {
            Knight knight = Knight.CreateKnight();
            knight.Move();// Knight.Move(); (x)

            Console.WriteLine();
        }
    }
}
