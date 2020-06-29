//CMP1124M Algorithms & Complexity Assignment 2
//by Gabriella Di Gregorio 15624188

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmsAssignment
{
    class Program
    {
        public static int steps = 0;

        public static void Main(string[] args)
        {
            //The first step is to choose which file to open/work on...
            Console.WriteLine("Which File would you like to work on? \nHere are the available files:");

            DirectoryInfo FilesFolder = new DirectoryInfo(@"Files");
            FileInfo[] Files = FilesFolder.GetFiles("*.txt");

            int num = 1;

            foreach (FileInfo file in Files)
            {
                Console.WriteLine(num + ". " + file.Name);

                num++;
            }
            //The lines above read which files are stored in the file location and displays them to the user

            string selectedFile;

            //The user now enters which file (1-15) they would like to open/work with
            Console.Write("Please enter the number of the file you wish to work on: ");
            selectedFile = Console.ReadLine();

            string[] Data_txt;
            float[] Data = new float[] { };
            //Lines 43 to 207 displays the contents of the selected file and assigns it to a string Array then converts the numbers in the file to a float Array
            
            if (selectedFile == "1")
            {
                Data_txt = System.IO.File.ReadAllLines(@"Files/Change_1024.txt"); //Reads the file into a string array
                Data = Array.ConvertAll<string, float>(Data_txt, Convert.ToSingle); //Converts that string array into a float array

                Console.WriteLine("\nContents of Change_1024: ");
                foreach (float number in Data) //displays all contents of chosen file
                {
                    Console.Write("{0:N3} ", number); //(to 3 decimal places so they will all appear the same e.g. 0.300 rather than just 0.3)
                }
            }
            if (selectedFile == "2")
            {
                Data_txt = System.IO.File.ReadAllLines(@"Files/Change_128.txt");
                Data = Array.ConvertAll<string, float>(Data_txt, Convert.ToSingle);

                Console.WriteLine("\nContents of Change_128: ");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }
            if (selectedFile == "3")
            {
                Data_txt = System.IO.File.ReadAllLines(@"Files/Change_256.txt");
                Data = Array.ConvertAll<string, float>(Data_txt, Convert.ToSingle);

                Console.WriteLine("\nContents of Change_256: ");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }
            if (selectedFile == "4")
            {
                Data_txt = System.IO.File.ReadAllLines(@"Files/Close_1024.txt");
                Data = Array.ConvertAll<string, float>(Data_txt, Convert.ToSingle);

                Console.WriteLine("\nContents of Close_1024: ");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }
            if (selectedFile == "5")
            {
                Data_txt = System.IO.File.ReadAllLines(@"Files/Close_128.txt");
                Data = Array.ConvertAll<string, float>(Data_txt, Convert.ToSingle);

                Console.WriteLine("\nContents of Close_128: ");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }
            if (selectedFile == "6")
            {
                Data_txt = System.IO.File.ReadAllLines(@"Files/Close_256.txt");
                Data = Array.ConvertAll<string, float>(Data_txt, Convert.ToSingle);

                Console.WriteLine("\nContents of Close_256: ");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }
            if (selectedFile == "7")
            {
                Data_txt = System.IO.File.ReadAllLines(@"Files/High_1024.txt");
                Data = Array.ConvertAll<string, float>(Data_txt, Convert.ToSingle);

                Console.WriteLine("\nContents of High_1024: ");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }
            if (selectedFile == "8")
            {
                Data_txt = System.IO.File.ReadAllLines(@"Files/High_128.txt");
                Data = Array.ConvertAll<string, float>(Data_txt, Convert.ToSingle);

                Console.WriteLine("\nContents of High_128: ");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }
            if (selectedFile == "9")
            {
                Data_txt = System.IO.File.ReadAllLines(@"Files/High_256.txt");
                Data = Array.ConvertAll<string, float>(Data_txt, Convert.ToSingle);

                Console.WriteLine("\nContents of High_256: ");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }
            if (selectedFile == "10")
            {
                Data_txt = System.IO.File.ReadAllLines(@"Files/Low_1024.txt");
                Data = Array.ConvertAll<string, float>(Data_txt, Convert.ToSingle);

                Console.WriteLine("\nContents of Low_1024: ");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }
            if (selectedFile == "11")
            {
                Data_txt = System.IO.File.ReadAllLines(@"Files/Low_128.txt");
                Data = Array.ConvertAll<string, float>(Data_txt, Convert.ToSingle);

                Console.WriteLine("\nContents of Low_128: ");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }
            if (selectedFile == "12")
            {
                Data_txt = System.IO.File.ReadAllLines(@"Files/Low_256.txt");
                Data = Array.ConvertAll<string, float>(Data_txt, Convert.ToSingle);

                Console.WriteLine("\nContents of Low_256: ");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }
            if (selectedFile == "13")
            {
                Data_txt = System.IO.File.ReadAllLines(@"Files/Open_1024.txt");
                Data = Array.ConvertAll<string, float>(Data_txt, Convert.ToSingle);

                Console.WriteLine("\nContents of Open_1024: ");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }
            if (selectedFile == "14")
            {
                Data_txt = System.IO.File.ReadAllLines(@"Files/Open_128.txt");
                Data = Array.ConvertAll<string, float>(Data_txt, Convert.ToSingle);

                Console.WriteLine("\nContents of Open_128: ");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }
            if (selectedFile == "15")
            {
                Data_txt = System.IO.File.ReadAllLines(@"Files/Open_256.txt");
                Data = Array.ConvertAll<string, float>(Data_txt, Convert.ToSingle);

                Console.WriteLine("\nContents of Open_256: ");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }

            string selectedAlgorithm;

            //The user can now select which sorting algorithm they would like to use to sort their chosen file
            Console.WriteLine("\n\nWhich sorting algorithm would you like to use? \n1. Bubble Sort \n2. Quicksort \n3. Merge Sort");
            Console.Write("Please enter the number of your chosen Algorithm: ");
            selectedAlgorithm = Console.ReadLine();

            if(selectedAlgorithm == "1")
            {
                //Runs the Bubble Sort method and displays the sorted array
                BubbleSort(Data);
                Console.WriteLine("\nYour file has been sorted:");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }
            if (selectedAlgorithm == "2")
            {
                //For the Quicksort algorithm, the order could not be chosen in the method so it is selected here instead.
                string order;

                Console.WriteLine("\nWould you like to sort in ascending or descending order?");
                Console.WriteLine("Enter 1 for ascending, or 2 for descending");
                Console.Write("Order: ");
                order = Console.ReadLine();                

                //A different method runs depending on whether the user selects ascending or descending order
                if (order == "1")
                {
                    QuickSort_Ascending(Data, 0, Data.Length - 1);
                }
                if (order == "2")
                {
                    QuickSort_Descending(Data, 0, Data.Length - 1);
                }

                Console.WriteLine("\nThis has taken {0} steps...", steps);

                //Displays the sorted array
                Console.WriteLine("\nYour file has been sorted:");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }
            if(selectedAlgorithm == "3")
            {                
                MergeSort(Data);
                Console.WriteLine("\nThis has taken {0} steps...", steps);

                Console.WriteLine("\nYour file has been sorted:");
                foreach (float number in Data)
                {
                    Console.Write("{0:N3} ", number);
                }
            }

            string selectedSearchAlgorithm;
            float searchItem;

            //The chosen file has now been sorted in some way so the user can now choose which searching algorithm they would like to use
            Console.WriteLine("\n\nWhich searching algorithm would you like to use? \n1. Linear Search \n2. Binary Search");
            Console.Write("Please enter the number of your chosen Algorithm: ");
            selectedSearchAlgorithm = Console.ReadLine();

            if(selectedSearchAlgorithm == "1")
            {
                //Then, the user is asked which number they would like to search for
                Console.Write("\nWhich item would you like to search for?: ");
                searchItem = float.Parse(Console.ReadLine());

                LinearSearch(Data, searchItem); //The Linear search method runs                
            }
            if (selectedSearchAlgorithm == "2")
            {
                Console.Write("\nWhich item would you like to search for?: ");
                searchItem = float.Parse(Console.ReadLine());

                int min = 0;
                int max = Data.Length - 1;
                //The start and end of the array needed to be declared outside of the Binary Search method

                List<int> foundPositions = BinarySearch(Data, searchItem, min, max);
                foundPositions.Sort();
                //The Binary Search method runs and the results of the found positions are sorted into ascending order

                Console.WriteLine("\nThis has taken {0} steps...", steps);

                //If there are items in the list, meaning that the number has been found, displays all found locations of the searched number
                if (foundPositions.Count() != 0)
                {
                    Console.Write("{0} has been found at position(s): ", searchItem);
                    foreach (int position in foundPositions)
                    {
                        Console.Write(position + " ");
                    }
                }
                //If the count is 0 then that means the searched number has not been found at any positions, so displays an error message.
                else
                {
                    Console.WriteLine("Sorry, this number could not be found.");
                }
            }

            Console.ReadKey();
            //End of program
        }

        public static void BubbleSort(float[] Data)
        {
            int steps = 0;
            string order;

            //The user is asked whether they would like to use the Bubble Sort to display their chosen file in ascending or descending order
            Console.WriteLine("\nWould you like to sort in ascending or descending order?");
            Console.WriteLine("Enter 1 for ascending, or 2 for descending");
            Console.Write("Order: ");
            order = Console.ReadLine();

            for (int i = 0; i < Data.Length - 1; i++) //Goes through the array from start to finish
            {
                for (int j = 0; j < Data.Length - 1 - i; j++)
                {
                    if(order == "1")
                    {
                        if (Data[j + 1] < Data[j]) //For ascending order, perform a swap if the current number is smaller than the one after
                        {
                            float temp = Data[j];
                            Data[j] = Data[j + 1];
                            Data[j + 1] = temp;
                        }
                    }
                    if (order == "2")
                    {
                        if (Data[j + 1] > Data[j]) //For descending order, perform a swap if the current number is larger than the one after
                        {
                            float temp = Data[j];
                            Data[j] = Data[j + 1];
                            Data[j + 1] = temp;
                        }
                    }
                    steps++; //counts the number of times it repeats and therefore how many steps it takes for the algorithm to complete
                }                
            }
            Console.WriteLine("\nThis has taken {0} steps...", steps);
        }        
        public static void QuickSort_Ascending(float[] Data, int left, int right)
        {
            if (left < right)
            {
                int pivot = QuickSortPartition_Ascending(Data, left, right); //result from method below becomes the pivot

                if (pivot > 1)
                {
                    QuickSort_Ascending(Data, left, pivot - 1); //If the pivot is greater than 1, repeat with the first portion of the array
                }
                if (pivot + 1 < right)
                {
                    QuickSort_Ascending(Data, pivot + 1, right); //If the number after the pivot is smaller than the number on the right, repeat with the last portion of the array
                }
            }
        }
        public static int QuickSortPartition_Ascending(float[] Data, int left, int right)
        {
            float pivot = Data[left]; //Pivot starts at first element            

            while(true)
            {
                while(Data[left] < pivot) //While any number to the left of the pivot is smaller than the pivot, keep going along the array
                {
                    left++;
                }
                while(Data[right] > pivot) //While any number to the right of the pivot is larger than the pivot, keep going along the array backwards
                {
                    right--;
                }
                if (left < right) //If the current number on the left side is smaller than the right side, it is on the wrong side of the pivot so should be swapped
                {
                    float temp = Data[left];
                    Data[left] = Data[right];
                    Data[right] = temp;
                    //A swap is performed between the left and right numbers                    

                    if (Data[left] == Data[right]) //If the number to the left is equal to the number on the right, keep going along the array too
                    {
                        left++;
                    }                    
                }
                else //If not, stop and return the number on the right
                {
                    return right;
                }
                steps++;
            }
        }
        public static void QuickSort_Descending(float[] Data, int left, int right) //Same again for descending order
        {
            if (left < right)
            {
                int pivot = QuickSortPartition_Descending(Data, left, right);

                if (pivot > 1)
                {
                    QuickSort_Descending(Data, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort_Descending(Data, pivot + 1, right);
                }
            }
        }
        public static int QuickSortPartition_Descending(float[] Data, int left, int right)
        {
            float pivot = Data[left];

            while (true)
            {
                while (Data[left] > pivot) //Except for descending, the data on the left should be bigger than the pivot...
                {
                    left++;
                }
                while (Data[right] < pivot) //...and the data on the right should be smaller than the pivot.
                {
                    right--;
                }
                if (left < right) //So, if the left is smaller than the right, then a swap needs to be performed to get the numbers on the correct side.
                {
                    float temp = Data[left];
                    Data[left] = Data[right];
                    Data[right] = temp;

                    if (Data[left] == Data[right])
                    {
                        left++;
                    }
                }
                else
                {
                    return right;
                }
                steps++;
            }
        }

        public static void Merge(float[] Data, float[] temp, int low, int mid, int high)
        {
            int resultIndex = low;
            int tempIndex = low;
            int destinationIndex = mid;

            //While two lists are not empty, merge smaller value
            while (tempIndex < mid && destinationIndex <= high)
            {
                if (Data[destinationIndex] < temp[tempIndex])
                {
                    Data[resultIndex++] = Data[destinationIndex++];
                    //smaller is in high data
                }
                else
                {
                    Data[resultIndex++] = temp[tempIndex++]; //smaller is in temp
                }
                steps++;
            }
            //Possibly some values left in temp array (or some values left in correct place in data array)...
            while (tempIndex < mid)
            {
                Data[resultIndex++] = temp[tempIndex++];                
            }            
        }
        public static void MergeSortRecursive(float[] Data, float[] temp, int low, int high)
        {
            int n = high - low + 1;
            int mid = low + n / 2;
            int i;

            if (n < 2) return;

            //move lower half of data into temporary storage
            for (i = low; i < mid; i++)
            {
                temp[i] = Data[i];                
            }
            //Sort lower half of array:
            MergeSortRecursive(temp, Data, low, mid - 1);
            //Sort upper half of array:
            MergeSortRecursive(Data, temp, mid, high);
            //Merge two halves together:
            Merge(Data, temp, low, mid, high);
        }
        public static void MergeSort(float[] Data)
        {
            int n = Data.Length;
            float[] temp = new float[n];
            MergeSortRecursive(Data, temp, 0, n - 1);            
        }

        public static void LinearSearch(float[] Data, float searchItem)
        {
            List<int> foundPositions = new List<int>(); //Creates list to store all the positions the searched item is found in
            int steps = 0;

            bool found = false;
            
            for(int currentElement = 0; currentElement < Data.Length; currentElement++) //Goes through array one by one from start to finish
            {
                if(Data[currentElement] == searchItem) //If the current value is the same as the search item, then it has been found so add the current position to the list of found positions
                {
                    foundPositions.Add(currentElement);
                    found = true;
                }
                steps++; //counts how many times the loop repeats and therefore how long it takes to run the algorithm
            }

            Console.WriteLine("This has taken {0} steps...", steps);

            int[] foundPositons = foundPositions.ToArray(); //Convert list to an array

            if (found == true) //If it has been found, show the user all the positions that the searched number has been found in
            {
                Console.Write("{0} has been found at position(s): ", searchItem);
                foreach(int position in foundPositions)
                {
                    Console.Write(position + " ");
                }
            }
            else //If not, then we need to look for the nearest value...
            {
                float searchItem1 = searchItem;
                float higherResult = 0;
                float searchItem2 = searchItem;
                float lowerResult = 0;

                int higherPosition = 0;
                int lowerPosition = 0;

                bool foundHigher = false;
                bool foundLower = false;

                do
                {
                    searchItem1 += 0.001F; //Keep incrementing the original search item until the nearest higher number gets found

                    for (int currentElement = 0; currentElement < Data.Length; currentElement++) //Go through the array again
                    {
                        if (Data[currentElement] == searchItem1) //Once a match is found, store the closest higher number and where it was found
                        {
                            higherPosition = currentElement;
                            higherResult = Data[currentElement];
                            foundHigher = true;
                        }
                    }
                } while (foundHigher == false);

                do
                {

                    searchItem2 -= 0.001F; //Keep decreasing the original search item until the nearest lower number gets found

                    for (int currentElement = 0; currentElement < Data.Length; currentElement++) //Go through the array again
                    {
                        if (Data[currentElement] == searchItem2) //Once a match is found, store the closest lower number and where it was found
                        {
                            lowerPosition = currentElement;
                            lowerResult = Data[currentElement];
                            foundLower = true;
                        }
                    }
                } while (foundLower == false);

                //Compare whether the nearest higher number or the nearest lower number is closest to the original search item and display the result to the user
                if (searchItem1 - searchItem == searchItem - searchItem2)
                {
                    Console.WriteLine("The number has not been found. There are 2 numbers just as near; {0} at position {1} and {2} at position {3}", lowerResult, lowerPosition, higherResult, higherPosition);
                }
                else if (searchItem1 - searchItem < searchItem - searchItem2)
                {
                    Console.WriteLine("The number has not been found. The nearest number is {0} at position {1}", higherResult, higherPosition);
                }
                else if (searchItem1 - searchItem > searchItem - searchItem2)
                {
                    Console.WriteLine("The number has not been found. The nearest number is {0} at position {1}", lowerResult, lowerPosition);
                }
                
            }
        }
        
        public static List<int> BinarySearch(float[] Data, float searchItem, int min, int max)
        {
            int mid = (min + max) / 2;
            List<int> foundPositions = new List<int>(); //The found positions create a list
            bool repeatLower = true;
            bool repeatHigher = true;

            if(max - min > 1) //Stop once whole array has been searched
            {
                if(Data[mid] == searchItem)
                {
                    foundPositions.Add(mid + 1); //If a match is found, add the current position to the list                    

                    for(int lower = 1; repeatLower; lower++) //repeat again to see if the number one lower is the same
                    {
                        if(Data[mid - lower] == searchItem)
                        {
                            foundPositions.Add((mid - lower) + 1); //if it is, then add that position to the list too
                        }
                        else
                        {
                            repeatLower = false; //stop if the number next to it on the left hand side is not the same
                        }
                    }                    
                    for(int higher = 1; repeatHigher; higher++) //same again to see if the next number up is the same...
                    {
                        if(Data[mid + higher] == searchItem)
                        {
                            foundPositions.Add(mid + higher + 1);
                        }
                        else
                        {
                            repeatHigher = false;
                        }
                    }
                    steps++;
                }
                else if (Data[mid] > searchItem) //If the middle of the array is bigger than the number we are looking for...
                {
                    if (Data[min] < Data[max]) //If it is ascending order...
                    {
                        return BinarySearch(Data, searchItem, min, mid - 1); //Look in the lower half of the array
                    }
                    else if (Data[min] > Data[max]) //If it is descending order...
                    {
                        return BinarySearch(Data, searchItem, mid + 1, max); //Look in the upper half of the array
                    }
                    steps++;
                }
                else if (Data[mid] < searchItem) //If the middle of the array is smaller than the number we are looking for...
                {
                    if (Data[min] < Data[max]) //If its ascending order...
                    {
                        return BinarySearch(Data, searchItem, mid + 1, max); //Look in the upper half of the array
                    }
                    else if (Data[min] > Data[max]) //If its descending order...
                    {
                        return BinarySearch(Data, searchItem, min, mid - 1); //Look in the lower half of the array
                    }
                    steps++;
                }
                steps++;
            }
            return foundPositions; //return the list (if its empty it has not been found, otherwise it will contain all of the positions the search item has been found in)           
        }        
    }
}
