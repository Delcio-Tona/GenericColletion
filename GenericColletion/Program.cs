using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;

namespace GenericColletion
{ 
    public delegate void MyDelegate(int[] Array);

    class Program
    { 
    Queue<string> Name_of_ingredient = new Queue<string>();
    Queue<string> description = new Queue<string>();
    Queue<float> Quantity = new Queue<float>();
    Queue<float> Unit_of_measurement = new Queue<float>();
    Queue<int> Step = new Queue<int>();
    Queue<string> Recipe_name = new Queue<string>();
    Queue<int> number_of_ingredient = new Queue<int>();
    int number_of_recipe;

    //Declaring Arrays to display what the generic collections will contain
    int[] num_of_calories = new int[20];
    string[] food_group = new string[20];
    int[] Convert_Step = new int[10];
    float[] convert = new float[20];
    float[] convert1 = new float[20];
    string place_condition;
    string place_condition_convert;
    string condition2;
    string[] Convert_description = new string[20];
    string condition3;
    string option;
    string indexFromList;
    string option2;
    int num_of_ingredient;
    Queue<int> contain_calorie = new Queue<int>();
    int num_calorie;
    Queue<string> food_groups = new Queue<string>();
    float[] convert_Quantity = new float[20];
    static void Main(string[] args)
    {
            //Display color on the top
            Console.ForegroundColor = ConsoleColor.Blue;
            //Display background color
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("***************** RECIPE **********************\n");
            //Create a object of the main class
            Program Tona = new Program();
            //Calling the method of the main class
            Tona.Delcio();
    }
    public void Delcio()
    {
        while (true)
        {           
            Console.Write("Enter the number of recipe: ");
            //Input from the user
            number_of_recipe = int.Parse(Console.ReadLine());
            //Placing the condition
            if (number_of_recipe == number_of_recipe)
            {
                for (int i = 0; i < number_of_recipe; i++)
                {                   
                    Console.Write("Enter the name of recipe: ");
                    //Storing the input user in the generic collection
                    Recipe_name.Enqueue(Console.ReadLine().ToUpper());
                }
                //Storing the generic collection in the list
                List<string> n = new List<string>(Recipe_name);
                //Sorting the list in alphabetical order
                n.Sort();
                Console.WriteLine("List");
                foreach (string name_for_recipe in n)
                {
                    //Display color
                    Console.ForegroundColor = ConsoleColor.Red;
                    //Display the recipes
                    Console.WriteLine("Recipe: " + name_for_recipe);
                }
                //Display color
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Do you like to choose any of the recipes listed? (Yes) or (Not): ");
                //Placing the condition
                option = (Console.ReadLine().ToUpper());
                if (option == "YES")
                {
                    Console.Write("Enter the recipe name: ");
                    //Input from the user
                    indexFromList = (Console.ReadLine().ToUpper());
                    //Placing the condition
                    if (n.Contains(indexFromList))
                    {                      
                        Console.Write("Do you like to enter the ingredient for " + indexFromList + "? (Yes) or (Not): ");
                        //Input from the user
                        option2 = (Console.ReadLine().ToUpper());
                        //Placing the condition
                        if (option2 == "YES")
                        {
                            //Calling the method of the main class
                            ingredient();
                            break;
                        }
                        else
                        {
                            //If the first condition fails will go back to first step
                            Console.WriteLine("Back to the menu!");
                        }

                    }
                    else
                    {
                        //If the first condition fails will close the program
                        Console.WriteLine("Recipe not found!");
                        break;
                    }
                }
                else
                {         
                    Console.Write("Do you like to close the application? (Yes) or (Not): ");
                    String response = Console.ReadLine().ToUpper();
                    if (response == "YES")
                    {
                        break;
                    }
                    else
                    {
                    }
                }

            }
        }
    }

    public void ingredient()
    {
        while (true)
        {
           Console.WriteLine("***********************************************");
          Console.Write("Enter the number of ingredients: ");
            //Input from the user
            num_of_ingredient = (int.Parse(Console.ReadLine()));
            //Placing the condition
            if (num_of_ingredient == num_of_ingredient)
            {
                for (int num = 0; num < num_of_ingredient; num++)
                {
                    Console.Write("Enter the name of ingredient: ");
                    //Storing the input user in the generic collection
                    Name_of_ingredient.Enqueue(Console.ReadLine());
                    Console.Write("Enter the quantity: ");
                    //Quantity.Enqueue(float.Parse(Console.ReadLine()));
                    //Storing the input user in the array
                    convert_Quantity[num] = float.Parse(Console.ReadLine());
                    Console.Write("Do you like to reset the quantity? (Yes) or (Not): ");
                    //Input from the user
                    place_condition = Console.ReadLine();
                    place_condition_convert = place_condition.ToUpper();
                    //Placing the condition
                    if (place_condition_convert == "YES")
                    {
                        //Set the quantity to empty
                        convert_Quantity[num] = 0;
                        //Storage of the the user input
                        Console.Write("Enter the quantity: ");
                        //Storage of the the user input
                        //Quantity.Enqueue(float.Parse(Console.ReadLine()));
                        convert_Quantity[num] = float.Parse(Console.ReadLine());
                    }
                    else
                    {
                        //Adding new line 
                        Console.Write("");
                    }
                    Console.Write("How many of tablespoon: ");
                    //Storage of the the user input
                    Unit_of_measurement.Enqueue(float.Parse(Console.ReadLine()));
                    Console.Write("Enter the number of calories: ");
                    //Input by the user
                    num_calorie = int.Parse(Console.ReadLine());
                    //Placing the order 
                    if (num_calorie > 300)
                    {
                        //Storing the input user in the generic collection
                        contain_calorie.Enqueue(num_calorie);
                    }
                    else
                    {
                        //Storing the input user in the generic collection
                        contain_calorie.Enqueue(num_calorie);
                    }
                    Console.Write("Enter the food group: ");
                    food_groups.Enqueue(Console.ReadLine());

                    Console.Write("Enter the number of step: ");
                    //Storage of the the user input
                    Step.Enqueue(int.Parse(Console.ReadLine()));

                    Console.Write("Enter the description of step: ");
                    //Storing the input user in the generic collection
                    description.Enqueue(Console.ReadLine());
                    //Storage of the the user input

                }
                Console.WriteLine("***********************************************");
                Console.WriteLine("");
                Console.Write("Number of ingredients: " + num_of_ingredient);
                Console.WriteLine("");
                //Storing the generic collection in the Array
                string[] convert_Name_of_ingredient = Name_of_ingredient.ToArray();
                //Storing the generic collection in the Array
                float[] conert_Quantity = Quantity.ToArray();
                //Storing the generic collection in the Array
                convert = Unit_of_measurement.ToArray();
                //Storing the generic collection in the Array
                Convert_description = description.ToArray();
                //Storing the generic collection in the Array
                Convert_Step = Step.ToArray();
                //Storing the generic collection in the Array
                food_group = food_groups.ToArray();
                //Storing the generic collection in the Array
                num_of_calories = contain_calorie.ToArray();
                //Looping according to the number of ingredient the user will input
                for (int b = 0; b < num_of_ingredient; b++)
                {

                        Console.WriteLine("Name of ingredient: " + convert_Name_of_ingredient[b]);
                        Console.WriteLine("Quantity: " + convert_Quantity[b]);
                        Console.WriteLine("Tablespoon: " + convert[b] / 5 + " ");
                }

                //Looping according to the number of ingredient the user will input
                for (int b = 0; b < num_of_ingredient; b++)
                {
                    Console.WriteLine("Description: " + Convert_description[b]);
                    Console.WriteLine("Step: " + Convert_Step[b]);
                    Console.WriteLine("Food group: " + food_group[b]);
                    Console.WriteLine("Calory: " + num_of_calories[b]);
                }
                //Initialize the method in the delegate function
                MyDelegate del = calculte_num_of_calorie;
                //Display the method by the invoke function
                del.Invoke(num_of_calories);


                //Adding new line
                Console.WriteLine("");
                Console.Write("Do you like to clear all data? (Yes) or (Not): ");
                //Storage of the the user input
                condition2 = Console.ReadLine();
                //Convert the input user to uppercase
                condition2 = condition2.ToUpper();
                //Placing condition
                if (condition2 == "YES")
                {
                    //Reset everything 
                    Console.WriteLine("");
                    //Declaring variables
                    //Declaring generic collections
                    Queue<string> Name_of_ingredient = new Queue<string>();
                    Queue<string> description = new Queue<string>();
                    Queue<float> Quantity = new Queue<float>();
                    Queue<float> Unit_of_measurement = new Queue<float>();
                    Queue<int> Step = new Queue<int>();
                    Queue<string> Recipe_name = new Queue<string>();
                    Queue<int> number_of_ingredient = new Queue<int>();
                    int number_of_recipe;

                    //Declaring Arrays to display what the generic collections will contain
                    int[] num_of_calories = new int[20];
                    string[] food_group = new string[20];
                    int[] Convert_Step = new int[10];
                    float[] convert = new float[20];
                    float[] convert1 = new float[20];
                    string place_condition;
                    string place_condition_convert;
                    string condition2;
                    string[] Convert_description = new string[20];
                    string condition3;
                    string option;
                    string indexFromList;
                    string option2;
                    int num_of_ingredient;
                    Queue<int> contain_calorie = new Queue<int>();
                    int num_calorie;
                    Queue<string> food_groups = new Queue<string>();
                    float[] conert_Quantityy = new float[20];
                    //What the user should see as an output
                    Console.WriteLine("All data have been successfully deleted!");
                    //Adding new line
                    Console.WriteLine("");
                    //Creating the object of the class
                    second_class second = new second_class();
                    //Calling a method
                    second.clear_all_data();
                    break;

                }
                else
                {
                    //Adding new line
                    Console.WriteLine("");
                    //Displaying to the user 
                    Console.Write("Do you like to exist the application? (Yes) or (Not): ");
                    //Storage of the the user input
                    condition3 = Console.ReadLine();
                    //Convert the user input to upppercase
                    condition3 = condition3.ToUpper();
                    //Placing condition
                    if (condition3 == "YES")
                    {

                        break;
                    }
                    else
                    {
                        //Calling the method
                        Delcio();
                    }
                    break;
                }

            }

        }
    }

    public void calculte_num_of_calorie(int[] Num)
    {
        int cal = 0;
        for (int num = 0; num < num_of_ingredient; num++)
        {
            cal += Num[num];
        }
        Console.WriteLine("Total calories: " + cal);
        if (cal > 300)
        {
            Console.WriteLine("Total calories exceeded 300");
        }
    }

}
class second_class
{
    public void clear_all_data()
    {
        //Calling the main class in the second class
        Program Tona = new Program();
        //calling the main method
        Tona.Delcio();
    }
}

}


