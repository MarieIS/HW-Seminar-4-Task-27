int GetNumber(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetNumber("Insert your number: ");
int sum = 0;
int temp = num;

while (temp > 0) {
    sum += temp % 10;
    temp = temp / 10;
}
Console.WriteLine($"{num} -> {sum}");