// Uso de Random
Console.WriteLine("uso de de random:\n");
Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

//desafio 
string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin")){
    Console.WriteLine("a");
}