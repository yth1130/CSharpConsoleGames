Console.Clear();

string name; // = "윤태훈";
int age; // = 30;
float height; // = 172.0f;
bool isMarried; // = false;
// string[] favoriteFoods = new string[] { "마라탕", "피자", "치킨" };
string[] favoriteFoods = new string[3];

Console.WriteLine("이름을 입력해주세요.");
name = Console.ReadLine();

Console.WriteLine("나이를 입력해주세요.");
age = int.Parse(Console.ReadLine());

Console.WriteLine("키를 입력해주세요.");
height = float.Parse(Console.ReadLine());

Console.WriteLine("기혼 여부를 입력해주세요(true / false)");
isMarried = bool.Parse(Console.ReadLine());

int count = 0;
while (count < 3)
{
    Console.WriteLine("좋아하는 음식을 입력해주세요. (끝내기 : q)");
    string input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    favoriteFoods[count] = input;
    count++;
}

Console.Clear();

Console.WriteLine($"이름 : {name}");
Console.WriteLine($"나이 : {age}");
Console.WriteLine($"키 : {height}");
Console.WriteLine($"기혼 여부 : {isMarried}");

// favoriteFoods.Length == 3;
// for문은 세번 반복된다. i==0, i==1, i==2일 때.
// i==3이면 조건이 false가 되어서 실행하지 않음.
for (int i = 0; i < favoriteFoods.Length; i++) // i++ => i = i + 1;
{
    Console.WriteLine($"좋아하는 음식{(i + 1)} : {favoriteFoods[i]}");
}

if (age < 20)
{
    Console.WriteLine("좋겠다...");
}
else if (age < 30)
{
    Console.WriteLine("아직 좋다..");
}
else
{
    Console.WriteLine("힘내자..!");
}

Gender gender; // 0: 남자, 1: 여자.
gender = Gender.Male;

switch (gender)
{
    case Gender.Male:
        Console.WriteLine("성별 : 남자");
        break;
    case Gender.Female:
        Console.WriteLine("성별 : 여자");
        break;
    case Gender.Etc:
        Console.WriteLine("성별 : ??");
        break;
}

while (true)
{
    Console.WriteLine("숫자를 입력해주세요. (나가기 : q)");
    string input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    int inputNumber;
    if (int.TryParse(input, out inputNumber) == false)
    {
        Console.WriteLine("숫자로 입력해주세요!");
        continue;
    }
    Console.WriteLine($"입력된 숫자는 {inputNumber}입니다.");
}

// &&는 두 조건문이 모두 true일 때에 전체가 true가 된다.
// 하나라도 false이면 전체 조건문은 false.
if (isMarried == true && gender == Gender.Male)
{
    Console.WriteLine("가장이시네요");
}


// 과제. 

enum Gender
{
    Male,
    Female,
    Etc,
}