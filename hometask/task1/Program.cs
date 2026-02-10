


// Task 1


// void Count(int n)
// {
//     if (n <= 0)
//     {
//         return;
//     }

//     Count(n - 1);

//     Console.Write(n + " " );
// }

// int n = Convert.ToInt32(Console.ReadLine());
// Count(n);






// Task 2


// void Count(int n)
// {
//     if (n <= 0)
//     {
//         return;
//     }
//        Console.Write(n + " " );
//     Count(n - 1);
// }

// int n = Convert.ToInt32(Console.ReadLine());
// Count(n);






// Task 3

// int  sum = 0;
// void Count(int n)
// {
//     sum += n;

//     if (n <= 0)
//     {
//         return;
//     }
//     Count(n - 1);
// }

// int n = Convert.ToInt32(Console.ReadLine());
// Count(n);
// Console.WriteLine("Sum = " + sum);







// Task 4


// void Number(int n)
// {
//     if (n <= 0)
//     {
//         return;
//     }
//     Number(n / 10);
//     Console.Write(n % 10 + " ");
// }

// int n = Convert.ToInt32(Console.ReadLine());
// Number(n);







// Task 5


// int  cnt = 0;
// void Count(int n)
// {
//     if (n <= 0)
//     {
//         return;
//     }
//     Count(n / 10);
//     cnt ++;
// }

// int n = Convert.ToInt32(Console.ReadLine());
// Count(n);
// Console.WriteLine("Count = " + cnt);







// Task 6


// void CountEven(int a, int b)
// { 
//     if(a > b)
//     {
//       return;
//     }
//     if(a % 2 == 0)
//     {
//       Console.Write( a + " " );
//     }
    
//     CountEven(a + 1, b);
// }

// void CountOdd(int a, int b)
// { 
//     if(a > b)
//     {
//       return;
//     }

//     if(a % 2 != 0)
//     {
//         Console.Write( a + " " );
//     }

//     CountOdd(a + 1, b);
// }

// int a = Convert.ToInt32(Console.ReadLine());

// int b = Convert.ToInt32(Console.ReadLine());

// CountEven(a , b);

// CountOdd(a , b);
