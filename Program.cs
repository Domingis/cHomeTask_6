// int CheckInputNumbers(int m){
//     int result = 0;
//     int number = 0;
//     System.Console.WriteLine($"Введите {m} чисел");
//     for (int i = 1; i <= m; i++){
//         number = Convert.ToInt32(Console.ReadLine());
//         if (number > 0){
//         result++;
//         }
//     }
//     return result;
// }

// System.Console.WriteLine($"Положительных чисел - {CheckInputNumbers(5)}");


int InputOdd(string message){
    System.Console.Write($"{message} = ");
    return Convert.ToInt32(Console.ReadLine());
}

string SearchPoint(int b1, int k1, int b2, int k2){
    double x = Math.Round((Convert.ToDouble((b2-b1)) / (k1-k2)), 2);
    double y = k1*x + b1;
    string result = "(" + x + "; " + y + ")";
    return result;
}

string result = SearchPoint(InputOdd("b1"), InputOdd("k1"), 
                        InputOdd("b2"), InputOdd("k2"));
System.Console.WriteLine(result);


