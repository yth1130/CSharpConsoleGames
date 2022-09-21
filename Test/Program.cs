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
// 4. Call by Address
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
// 4. Call by Reference
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
#endregion

#region 4주차.
#endregion

#region 5주차.
#endregion
