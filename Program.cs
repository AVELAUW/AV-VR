//methods have () and properties do not
//experiment with Console.WriteLine() Console.Write() string.Trim(), TrimEnd(), TrimStart() 
//Experiment with string.ToUpper string.ToLower 
//String.ToUpper and string.ToLower return copy string
//Trim by itself only trims for the beginning and end of the string with spaces
//string interplation means letting the program check for variables within your Console statement and it is activated using $ right outside the "" and having the string variable inside "" and in quotes.
//Examples below

/* The goal is to replace all question marks with variable names */

/*your Program starts here*/

Console.WriteLine("Hello, World!");
string myname = "Azhar    "; // myname is a variable of type string and it is assigned a value of "Azhar"
string najibsname= "   Najib"; // najibsname is a variable of type string and it is assigned a value of "Najib"
string yourname = "   Pinksay  "; // yourname is a variable of type string and it is assigned a value of "Pinksay"

/* Create some string variables of your own and experiment with the methods and properties below.*/

// Console.WriteLine(?); // simple print using console

// Console.WriteLine(?); // finds the number of character in a string using .Length

// Console.WriteLine(?); // string interpolation e.g  Console.WriteLine($"The name Azhar has  {myname.Length} characters"); // string interpolation


//  string newName = yourname.Trim(); //you can trim the spaces of a string using .Trim() method e.g Console.WriteLine(yourname.Trim()); // you can also print out your new trim as a variable newName

//Console.WriteLine($"**** {?} ***"); // remember creating a new variable after trimming does not change original, creates a copy

//string ? = ?.ToUpper(); //use .ToUpper() to change string to uppercase

string sentencepractice = $"My name is Azhar and I am the CEO of sableSync my favorite language is C# and my favorite hobby is developing VR applications. I want to hear about {myname.Length} hobbies of yours"; 

Console.WriteLine(sentencepractice.Replace("Azhar", "full stack software developer"));

//string newSentencepractice = sentencepractice.Replace("?", "?"); // try out the replace method and see what it does

//Console.WriteLine(?.Length); // more practice with string methods

/*Create a new string variable and assign it a value. */
// Console.WriteLine(?.Replace("?", "?"));
// Console.WriteLine(?.ToUpper());





//Sample program utilizing all the concepts.
//Console.WriteLine("Azhar     "); //simple print
//string myName = "Azhar";
//Console.Write($"My name is {myName.TrimEnd()}  and it has {myName.Length} characters. Jokes it is Actually 5 Characters.");
//Console.WriteLine($" It can also be written in uppercase like this {myname.Trim().ToUpper()} and now I will share a bit about my history");
//string history = $"As I said my name is {myname.Trim()} and it is made up of {myname.Length} letters. {newSentencepractice.Replace("My name is", "My job description is")}";
//Console.WriteLine(history);






//The best part about programs is asking questions to get a result and learn from the program.
//here is a simple program that utilizes methods suchs as string.StartWith & String.EndWith, StringContains 
//The focus here is to get a steady introduction to booleans


/* Remove the "/*" and "*/ // to activate the program below

/* if(?.StartsWith("a") == true) { // we will use this program to test out the StartsWith method
    Console.WriteLine("yey");
} else if (?.StartsWith("Ahar") == true) {
    Console.Write("I would have never known");
} else {
    Console.WriteLine(false);
}


 var ? = ?.ToCharArray();
 Console.WriteLine(newmyname.Reverse());

if(?.EndsWith("R")==true) {
    Console.Write("hmm, are you a genius");
} else if ( ?.EndsWith("ar")==false) {
    Console.WriteLine("ha, got em");
} else {
    Console.WriteLine(" I think soon we will get the hang of this if we keep experimenting");
}

*/