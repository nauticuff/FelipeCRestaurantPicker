/*
Carlos Felipe
10/19/22
This code prints out a randomized restaurant from a restaurant category chosen by the user. 
DONE
*/

Console.Clear();
bool run = true;
bool askQuestion = true;
string chosenRestaurant = "";

string[] asian = {"Siamese Street Thai Restaurant", "Tasty Pot", "Saigon Bowl Noodle House", "BonChon", "Domo", "Shirasoni Japanese Steakhouse", "Ramen 101 Stockton", "Huong Lan", "GK Mongolian BBQ", "Best Lumpia"};
string[] italian = {"Angelina's Spaghetti House","Eric's New York Style Pizza","De Vinci's","Romano's Macaroni Grill","De Vega Brothers","Dante's","David's New York Style Pizza","Eddie's Pizza","Olive Garden","Gian's Delicatessen",};
string[] mexican = {"Nena's Mexican Cuisine","Maria's Cafe","Taqueria Chapala","Taqueria La Estrella","Taqueria Carolina","Miguel's Mexican Restaurant","Tepa Taqueria","La Baja Birrieria Tijuana","Cancún Restaurant","Tio Pepe's II",};



while(askQuestion){
Console.WriteLine("Are you Hungry?");
string funny = Console.ReadLine().ToLower();
if(funny == "yes"){
    Console.WriteLine("Hello Hungry I'm HAL 9000.");
    askQuestion = false;
}
if(funny == "no"){
    run = false;
    Console.WriteLine("Okay... why are you here then?");
    askQuestion = false;
    run = false;
}
if(funny != "yes" && funny != "no"){
    Console.WriteLine("\nI said...");
}
}

while(run){
Console.Write("\nI have three restaurant categories for you to pick from.\nEnter your pick below.\nAsian, Italian, or Mexican: ");
string category = Console.ReadLine().ToLower();
if(category == "asian"){
    Random rnd = new Random();
    int asianNum = rnd.Next(asian.Length);
    chosenRestaurant = asian[asianNum];
    Console.WriteLine($"\nMaybe you should eat at {chosenRestaurant}");
}
else if(category == "italian"){
    Random rnd = new Random();
    int italianNum = rnd.Next(italian.Length);
    chosenRestaurant = italian[italianNum];
    Console.WriteLine($"\nMaybe you should eat at {chosenRestaurant}");
}
else if(category == "mexican"){
    Random rnd = new Random();
    int mexicanNum = rnd.Next(mexican.Length);
    chosenRestaurant = mexican[mexicanNum];
    Console.WriteLine($"\nMaybe you should eat at {chosenRestaurant}");
}
else{
    Console.WriteLine("\nInvalid category.\nTry again.");
}

if(category == "asian" || category == "italian" || category == "mexican"){
Console.WriteLine("\nChoose another restaurant?\nType YES or NO: ");
string runChoice = Console.ReadLine().ToUpper();
while(runChoice != "YES" && runChoice != "NO"){
    Console.WriteLine("I said 'YES or 'NO'\nTry again: ");
    runChoice = Console.ReadLine().ToUpper();
}
if(runChoice == "NO"){
    run = false;
    Console.WriteLine($"Enjoy eating at {chosenRestaurant} mortal.");
}
}
}



