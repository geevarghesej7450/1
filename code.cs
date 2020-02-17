Console.WriteLine("Enter Value");
int n = int.parse(Console.ReadLine());
int num = n;
int digits = 0;
if(n==0){
  digits = 1;
} else {
    while(num!=0){
    digits++;
    num /= 10;
  }
}

Console.WriteLine($"the number of digits is {digits}.");
