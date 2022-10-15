#region 1주차.
// int x;
// int y;
// int z;

// x = 10;
// y = 20;
// z = x + y;

// Console.WriteLine($"{x} + {y} = {z}");



// int i = 10;
// int j = 20;
// // Console.WriteLine(Sum(i, j));
// Console.WriteLine($"i:{i}, j:{j}");
// Swap(i, j);
// Console.WriteLine($"i:{i}, j:{j}");

// int Sum(int a, int b)
// {
//     int result = a + b;
//     return result;
// }
// void Swap(int a, int b)
// {
//     int temp = a;
//     a = b;
//     b = temp;
// }



// string aaa = "aaa";
// string bbb = "bbb";

// Swap(aaa, bbb);

// Console.WriteLine(aaa);
// Console.WriteLine(bbb);

// void Swap(string a, string b)
// {
//     string temp = a;
//     a = b;
//     b = temp;
// }
#endregion

#region 2주차.

//-----------------------------------------------------------------
// 1.함수의 정의.
// 반환형식, 함수의 이름, 매개변수, 함수 본문으로 이뤄진다.

// int Sum(int a, int b) // 반환 형식은 int, 함수 이름은 Sum, 매개변수는 a와 b
// { // 함수 본문 시작.
//     return a + b; 
// } // 함후 본문 끝.

// void PrintIntroduce(string name) // void는 반환 값이 없음을 의미.
// {
//     Console.WriteLine($"안녕하세요 제 이름은 {name}입니다.");
// }
//-----------------------------------------------------------------

//-----------------------------------------------------------------
// 2. 값 형식과 참조 형식.
// 일반적으로 기본 자료형은 거의 값 형식이다.
// 참조형식에는 대표적으로 string와 class가 있다.

// int x = 10;
// float f = 3.14f;
// string str = "호호";
// Profile profile = new Profile();
// class Profile
// {
//     int age;
// }
//-----------------------------------------------------------------

//-----------------------------------------------------------------
// 3. 값 형식의 매개변수와 참조 형식 매개변수의 차이
// 값 형식의 매개변수는 형식의 인스턴스(실제 값)이 넘겨진다.
// 참조 형식의 매개변수는 형식의 인스턴스에 대한 참조(주소)가 넘겨진다.
// 위의 Sum 함수와 PrintIntroduce로 심볼테이블과 스택, 힙을 그려보자.
//-----------------------------------------------------------------

//-----------------------------------------------------------------
// 4. Call by Value
// int i = 10;
// int j = 20;
// Swap(i, j);
// void Swap(int a, int b)
// {
//     int temp = a;
//     a = b;
//     b = temp;
// }
//-----------------------------------------------------------------

//-----------------------------------------------------------------
// 5. Call by Address
// Profile p1 = new Profile();
// Profile p2 = new Profile();
// p1.age = 10;
// p2.age = 20;

// Console.WriteLine($"p1.age:{p1.age}, p2.age:{p2.age}");
// Swap(p1, p2);
// Console.WriteLine($"p1.age:{p1.age}, p2.age:{p2.age}");

// void Swap(Profile a, Profile b)
// {
//     int temp = a.age;
//     a.age = b.age;
//     b.age = temp;
// }

// class Profile
// {
//     public int age;
// }
//-----------------------------------------------------------------

//-----------------------------------------------------------------
// 6. Call by Reference
// int i = 10;
// int j = 20;
// Console.WriteLine($"i:{i}, j:{j}");
// Swap(ref i, ref j);
// Console.WriteLine($"i:{i}, j:{j}");
// void Swap(ref int a, ref int b)
// {
//     int temp = a;
//     a = b;
//     b = temp;
// }
//-----------------------------------------------------------------

#endregion

#region 3주차.
// //-----------------------------------------------------------------
// // 1. 클래스, 캡슐화, 상속, 다형성.
// // Player player = new Player();
// // player.GetDamage(10);
// Character player = new Player(); // 다형성(상위 클래스의 변수에 하위 클래스의 인스턴스 할당)
// player.GetInfo(); // 다형성(하위 클래스에서 오버라이딩된 메서드 호출)

// class Character
// {
//     private int hp; // 멤버 변수(필드), private으로 숨김 => 캡슐화(정보은닉)
//     public int Hp
//     {
//         get
//         {
//             return hp;
//         }
//     }

//     public void GetDamage(int value) //멤버 함수(메서드)
//     {
//         hp -= value;
//     }
//     public virtual void GetInfo() // virtual : 하위 클래스에서 오버라이딩을 가능하게 함.
//     {
//         Console.WriteLine("캐릭터");
//     }
// }
// class Player: Character
// {
//     private int currentExp;
//     private int levelupExp;

//     public Player()
//     {
//         currentExp = 0;
//         levelupExp = 100;
//     }

//     public override void GetInfo()
//     {
//         Console.WriteLine("플레이어");
//     }
// }
// //-----------------------------------------------------------------
#endregion

#region 4주차.
// //-----------------------------------------------------------------
// // 1.클래스 복습.
// Car sonata = new Car("소나타");
// Car k5 = new Car("K5");
// sonata.PrintInfo();
// Car.PrintCategory();

// // Car rayEngine = new EngineCar("레이");
// // Car rayElectric = new ElectricCar("레이");
// // rayEngine.PrintInfo();
// // rayElectric.PrintInfo();

// // // 8. 다형성 설명. 기본 클래스의 변수에 파생 클래스의 인스턴스를 담는다.
// // Car rayEngine = new EngineCar("레이");
// // Car rayElectric = new ElectricCar("레이");
// // // 변수가 어떤 파생 클래스의 인스턴스를 담느냐에 따라 호출되는 실제 메서드가 달라짐.
// // rayEngine.Drive();
// // rayElectric.Drive();
// // Console.WriteLine(sonata.GetType());
// // Console.WriteLine(rayElectric.GetType());

// // sonata.MakeSound();

// class Car
// // 4. sealed 키워드.
// // sealed class Car
// // 6. 추상 클래스.
// // abstract class Car
// // class Car : ISoundable
// {
//     //-----------------------------------------------------------------
//     // A. 정적 멤버.
//     public const int NumberOfWheels = 4; // 정적 필드. const를 쓰면 상수. 변경 불가.
//     public static int NextProductId = 1;
//     public static void PrintCategory() // 정적 메서드.
//     {
//         Console.WriteLine("이 상품은 자동차 입니다.");
//     }
//     //-----------------------------------------------------------------

//     private string _name;
//     // protected string _name;
//     private int _productId;

//     public void PrintInfo()
//     // 5. 메서드 오버라이딩.
//     // public virtual void PrintInfo()
//     {
//         Console.WriteLine($"이 차는 {_name} 입니다.");
//     }
//     // 오버로딩.
//     public void PrintInfo(int repeat)
//     {
//         for (int i = 0; i < repeat; i++)
//         {
//             PrintInfo();
//         }
//     }

//     public Car(string name)
//     {
//         _name = name;
//         _productId = NextProductId;
//         NextProductId++;
//     }

//     // // 7.추상 메서드.
//     // public abstract void Drive();

//     // public void MakeSound()
//     // {
//     //     Console.WriteLine("빵빵");
//     // }
// }
// // 2. 상속.
// class EngineCar : Car
// // class EngineCar : Car, ISoundable
// {
//     private int numberOfCylinder;
    
//     public EngineCar(string name) : base(name)
//     {
//         // 3. private멤버 접근 x
//         // _name = name;
//     }

//     // public override void PrintInfo()
//     // {
//     //     Console.WriteLine($"이 차는 {_name}(내연기관차) 입니다.");
//     // }

//     // public override void Drive()
//     // {
//     //     Console.WriteLine("엔진 시동걸기");
//     //     Console.WriteLine("엔진에 연료 주입");
//     // }

//     // public void MakeSound()
//     // {
//     //     Console.WriteLine("빵빵");
//     // }
// }
// // 실습.
// class ElectricCar : Car
// // class ElectricCar : Car, ISoundable
// {
//     private float capacity;
    
//     public ElectricCar(string name) : base(name)
//     {
//     }

//     // 실습.
//     // public override void PrintInfo()
//     // {
//     //     Console.WriteLine($"이 차는 {_name}(전기차) 입니다.");
//     // }

//     // 실습.
//     // public override void Drive()
//     // {
//     //     Console.WriteLine("전원 켜기");
//     //     Console.WriteLine("전기로 모터 돌리기");
//     // }

//     // public void MakeSound()
//     // {
//     //     Console.WriteLine("삥삥");
//     // }
// }

// // // 9. 인터페이스.
// // interface ISoundable
// // {
// //     void MakeSound();
// // }
// //-----------------------------------------------------------------

// //-----------------------------------------------------------------
// // 10. 컬렉션.
// //-----------------------------------------------------------------

// // //-----------------------------------------------------------------
// // // B. 정적 클래스.
// // // System.Math
// // Console.WriteLine($"섭씨 20도 = 화씨 {TemperatureConverter.CtoF(20.0)}도");
// // Console.WriteLine($"화씨 70도 = 섭씨 {TemperatureConverter.FtoC(70.0).ToString("F0")}도");
// // static class TemperatureConverter
// // {
// //     public static double CtoF(double celsius)
// //     {
// //         double fahrenheit = (celsius * 9 / 5) + 32;
// //         return fahrenheit;
// //     }

// //     public static double FtoC(double fahrenheit)
// //     {
// //         double celsius = (fahrenheit - 32) * 5 / 9;
// //         return celsius;
// //     }
// // }
// // //-----------------------------------------------------------------
#endregion

#region 5주차.
// //-----------------------------------------------------------------
// // 컬렉션 복습.
// List<int> numberList = new List<int>();
// numberList.Add(5);
// numberList.Add(20);

// numberList.Clear();

// // 제네릭 설명.
// // List에 보면 T라는 제네릭 형식 매개변수가 있다.
// // List<T>를 제네릭 클래스 라고 한다.
// // 여러 타입에 대해 List를 만들 수 있게 한다.
// //-----------------------------------------------------------------

// //-----------------------------------------------------------------
// // 대리자
// Calculate calculator = Add;
// // System.Func<int, int, int> calculator = Add;

// int x = 20;
// int y = 10;
// Console.WriteLine(calculator(x, y));

// calculator = Sub;
// Console.WriteLine(calculator(x, y));

// int Add(int a, int b)
// {
//     return a + b;
// }
// int Sub(int a, int b) // Subtraction
// {
//     return a - b;
// }
// public delegate int Calculate(int a, int b);
// //-----------------------------------------------------------------

// //-----------------------------------------------------------------
// // System.Action이란?
// SimpleAction printMethod;
// // System.Action printMethod;
// printMethod = PrintMyName;
// printMethod();

// 대리자 체이닝.
// printMethod += PrintSomething;
// printMethod();

// void PrintMyName()
// {
//     Console.WriteLine("내이름");
// }
// void PrintSomething()
// {
//     Console.WriteLine("하하하하 호호호호");
// }
// public delegate void SimpleAction(); // 항상 이런걸 만들면 귀찮다.
//-----------------------------------------------------------------



//-----------------------------------------------------------------
// 이벤트.
// 카운터. 숫자를 더하다가 지정한 숫자를 넘어가면 이벤트 호출.
Counter counter = new Counter(10);
// counter.ThresholdReached = PrintThresholdReached;
// counter.ThresholdReached = PrintAdditionalThresholdReached;
counter.ThresholdReached += PrintThresholdReached;
counter.ThresholdReached += PrintAdditionalThresholdReached;

Console.WriteLine("test print");
// counter.ThresholdReached();

Console.WriteLine("add 2");
counter.Add(2);
Console.WriteLine("add 5");
counter.Add(5);
Console.WriteLine("add 4");
counter.Add(4);


static void PrintThresholdReached()
// static void PrintThresholdReached(object sender, EventArgs e)
{
    Console.WriteLine("The threshold was reached.");
    // Environment.Exit(0);
}
static void PrintAdditionalThresholdReached()
// static void PrintThresholdReached(object sender, EventArgs e)
{
    Console.WriteLine("The threshold was reached!!!!!!!!!!!!!!!!");
    // Environment.Exit(0);
}

class Counter
{
    private int _threshold; // 역치. 문턱값.
    private int _total;

    public delegate void EventHandler();
    
    // 대리자 방식.
    // public EventHandler ThresholdReached;
    // 이벤트 방식.
    public event EventHandler ThresholdReached;

    public Counter(int threshold)
    {
        _threshold = threshold;
    }

    public void Add(int value)
    {
        _total += value;
        if (_total >= _threshold)
        {
            ThresholdReached();
        }
    }

} 

//-----------------------------------------------------------------



// //-----------------------------------------------------------------
// // 람다 식
// // 메서드를 만들 필요 없이 바로 구현사항을 넣는다.
// System.Action printSomething;
// printSomething = PrintHoho;
// printSomething();

// // 문 람다. 매개변수 목록, 람다 연산자(=>), 코드 블록.
// printSomething = () =>
// {
//     Console.WriteLine("hihi");
// };
// printSomething();

// // 식 람다. 
// printSomething = () => Console.WriteLine("haha");
// printSomething();

// // int Mul(int a, int b) // multiply
// void PrintHoho()
// {
//     Console.WriteLine("Hoho");
// }
// //-----------------------------------------------------------------

// //-----------------------------------------------------------------
// // 람다 식 추가 예제.
// int[] numbers = new int[] { 3, 6, 2, 7, 8, 4, 20, 64, 23, 41 };
// // BubbleSort(numbers, GreaterThan);
// // BubbleSort(numbers, AlphabeticalGreaterThan);
// // 문 람다 사용.
// // BubbleSort(numbers, (int first, int second) =>
// // {
// //     return first > second;
// // });
// // 식 람다 사용. 매개변수 형식도 생략.
// // BubbleSort(numbers, (first, second) => first > second);
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }

// bool GreaterThan(int first, int second)
// {
//     return first > second;
// }
// bool AlphabeticalGreaterThan(int first, int second)
// {
//     int comparison;
//     comparison = (first.ToString().CompareTo(second.ToString()));
//     return comparison > 0;
// }
// void BubbleSort(int[] items, ComparisonHandler comparisonMethod)
// {
//     int i, j, temp;
//     for (i = items.Length - 1; i >= 0; i--)
//     {
//         for (j = 1; j <= i; j++)
//         {
//             if(comparisonMethod(items[j-1],items[j]))
//             {
//                 temp = items[j - 1];
//                 items[j - 1] = items[j];
//                 items[j] = temp;
//             }
//         }
//     }
// }
// delegate bool ComparisonHandler(int first, int second);
// //-----------------------------------------------------------------
#endregion
