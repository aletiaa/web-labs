// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

Logger.Instance.Log("Hello, World!");

// working with classes and contructors
Apple yellowApple = new Apple("yellow apple", 17.5, "yellow");
Apple redApple = new Apple("red apple",15.4, "red");

Mango smallMango = new Mango("small mango", 42, 1);
Mango mediumMango = new Mango ("medium mango", 60, 2);
Mango largeMango = new Mango ("big mango", 85, 3);

Logger.Instance.Log(yellowApple.GetDetails());
Logger.Instance.Log(largeMango.GetDetails());

var appleCountries = yellowApple.GetProducingCountries();

// for - foreach
Logger.Instance.Log();
Logger.Instance.Log("Apples produced in:");
for (int i = 0; i < appleCountries.Count(); i++)
{
    Logger.Instance.Log(appleCountries[i]);
}

Logger.Instance.Log();
Logger.Instance.Log("Mangos produced in:");
foreach (var mangoCountry in mediumMango.GetProducingCountries()) 
{
    Logger.Instance.Log(mangoCountry);
}

// implode (+)
// version 1
Logger.Instance.Log("Implode");
Console.Write("Apples produced in:");
Logger.Instance.Log(string.Join(",", appleCountries));
// version 2
string implodedCountries = StringWorker.Implode(",", appleCountries);
Logger.Instance.Log(implodedCountries);

// explode (v1)
// v1
Logger.Instance.Log("Explode");
string[] explodedCountries = implodedCountries.Split(',');
for (int i = 0; i < explodedCountries.Count(); i++)
{
    Logger.Instance.Log($"Exploded country: {i + 1} {explodedCountries[i]}");
}

//v2
Logger.Instance.Log();
explodedCountries = StringWorker.Explode(implodedCountries, ',');
for (int i = 0; i < explodedCountries.Count(); i++)
{
    Logger.Instance.Log($"Exploded country: {i + 1} {explodedCountries[i]}");
}

Logger.Instance.Log();

object extraBigMango = new Mango("extraBigMango", 63.5, 4);
Logger.Instance.Log(extraBigMango);
Logger.Instance.Log();

Apple greenApple = new Apple("green apple", 12.5, "green");
Fruit fruit = greenApple;   

Logger.Instance.Log(fruit.Price);
Logger.Instance.Log();

// comparison
Logger.Instance.Log("Comparison:");

Compare(fruit, greenApple); // true, references to same object
Compare(extraBigMango, greenApple); // false
Compare("string 1", "string 2"); // false
Compare("string 1", "string" + " " + "1"); // true

var logger1 = Logger.Instance;
var logger2 = Logger.Instance;
Compare(logger1, logger2); // true

void Compare(object a, object b)
{
    if (a == b)
    {
        Logger.Instance.Log("Are equal");
    } 
    else
    {
        Logger.Instance.Log("Are not equal");
    }
}


// Hastable / HashSet && hash functions

HashItem item10 = new HashItem(10);
HashItem item21 = new HashItem(21);
HashItem item7 = new HashItem(7);
HashItem item9 = new HashItem(9);
HashItem item9_2 = new HashItem(9);

// Hashtable -- needs for keeping pairs Key/Value, Keys are unique
Logger.Instance.Log();
Logger.Instance.Log("Hashtable");
Hashtable hashTable = new Hashtable();
hashTable.Add("first", item10); 
hashTable.Add("second", item21);
hashTable.Add("third", item7);
hashTable.Add("fourth", item9);
// next key duplicates existing key "fourth"
// error occurs while trying to add item with exisitng key.
// hashTable.Add("fourth", item9_2); 

foreach(var itemKey in hashTable.Keys)
{
    Logger.Instance.Log($"--> Key={itemKey} {hashTable[itemKey].GetHashCode()} Value={hashTable[itemKey]})");
}

Logger.Instance.Log();
Logger.Instance.Log("HashSet");
HashSet<HashItem> hasSet = new HashSet<HashItem>();
hasSet.Add(item10);
hasSet.Add(item21);
hasSet.Add(item7);
hasSet.Add(item9);
//  items are equal -> does not add based on override Equals() from HashItem
hasSet.Add(item9_2);

foreach(HashItem item in hasSet)
{
    Logger.Instance.Log($"--> Key={item.GetHashCode()} Value={item.Value})");
}