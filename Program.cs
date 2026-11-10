//TASK1
//  int a = Convert.ToInt32(Console.ReadLine());
//  int b = Convert.ToInt32(Console.ReadLine());


// IsDivisible(a,b);

//  void IsDivisible(int a, int b)
// {
//     if (a % b == 0)
//     {
//         Console.Write("TRUE");
//     }
//     else
//     {
//         Console.WriteLine("FALSE");
//     }
// }




//TASK2
//  int a = Convert.ToInt32(Console.ReadLine());

// IsDivisible(a);
//  void IsDivisible(int a)
// {
//     if (a % 2 == 0)
//     {
//         Console.Write("EVEN");
//     }
//     else
//     {
//         Console.WriteLine("ODD");
//     }
// }

//HOME1

//   int [] arr = {1,2,3,4,5,6,7,8,9,10};

// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write($"{arr[i]} ");
// }

//HOME2


//   int [] arr = {1,2,3,4,5,6,7,8,9,10};

// for (int i=arr.Length-1; i>=0; i--)
// {
//     Console.Write($"{arr[i]} ");
// }


//HOME4

// Summ(1234 );

// void Summ(int n)
// {
//     if (n == 0)
//     {
//         return;
//     }
//       Console.Write(n%10 +" ");
//       Summ(n/10);
// }

   //HOME6
//    System.Console.WriteLine("ALL even numbers from 0 to 20 arr :");

//      for (int i = 0; i <= 20; i += 2)
// {
//   Console.Write(i+" ");
// }

     //TASK7

// System.Console.WriteLine(Count(90872));

//      int Count(int n)
// {
//     if (n < 10){
//      return 1;   
//     }
//     return 1+Count(n/10);
// }

      //TASK8

//    System.Console.WriteLine(Sumeven(583246));      

//       int Sumeven (int n)
// {
//     if (n == 0)
//     {
//         return 0;
//     }
//     if (n % 10 % 2 == 0)
//     {
//         return n % 10 + Sumeven(n/10);
//     }
//     return Sumeven(n/10);
// }


     //TASK12

//      int n =Convert.ToInt32(Console.ReadLine());
//      bool palindrom = ispalindrom(n);
//      Console.WriteLine(palindrom);
//      bool ispalindrom(int n)
// {
//     int rev = 0;
//     for (int i = n; i > 0; i /= 10)
//     {
//         rev = rev*10;
//         rev+=i%10;
//     }
//     if (rev == n)
//     {
//         return true;
//     }
//     return false;
// }


   //TASK10

//    int n = Convert.ToInt32(Console.ReadLine());
//    System.Console.WriteLine(isprime(n));

//    bool isprime(int n)
// {
//     if (n <= 1)
//     {
//         return false;
//     }
//     for (int i = 2; i < n; i++)
//     {
//         if (n % i == 0)
//         {
//             return false;
//         }
//     }
//     return true;
// }


     //TASK5
//      int sum=1;

//      for (int i = 1; i <= 5; i++)
// {
// sum*=i;    
// }
// System.Console.WriteLine(sum);