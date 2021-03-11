using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.FileIO;

namespace Tecan
{
    class Program
    {
        static void Main(string[] args)
        {

            //string workingDirectory = Environment.CurrentDirectory;
            //string startupPath = Directory.GetParent(workingDirectory).Parent.Parent.FullName+"/";
            ////string path = Console.ReadLine();
            Console.WriteLine("Hi");
        }
    }
}




/*


            Console.WriteLine("Please enter the file (.*cvs) name.");
StreamReader sr1 = new StreamReader(path);
DataTable mydata = new DataTable();  //create an empty DataTable.....
string[] arr;                        //....and an array in which you will store the elemnets of each line
int i = 0;                           //just a variable to help counting where you are in your data
bool mydatasetup = false;
using (sr1)
{
    while (sr1.EndOfStream == false)    //read the whole file
    {
        string line = sr1.ReadLine();    //get a line from the file

        if (line != null && line != String.Empty) //check if there is content in the line
        {
            arr = line.Split(';');    //split the line at each ";" and put the elements in the array

            if (mydatasetup == false)   //after reading the first line add as many columns to your datatable as you will need..... 
            {
                for (int u = 0; u < arr.Length; u++)
                {
                    mydata.Columns.Add();
                }
                mydatasetup = true; //...but only do this once (otherwise you wil have an unneccessary big datatable
            }

            mydata.Rows.Add();   //add a row in you datatable in which you will store the data of the line

            for (int j = 0; j < arr.Length; j++)    //go throught each element in your array and put it into your datatable
            {
                if (arr[j] != "")
                {
                    mydata.Rows[i][j] = arr[j];
                }
            }
            i = i + 1; //increase the counter so that the program knows it has to fill the data from the next line into the next row of the datatable
        }
    }
    StringBuilder sb = new StringBuilder();  //create a stringbuilder

    for (int u = 0; u < mydata.Columns.Count; u++)   //loop through the COLUMNS of your datatable....
    {
        for (int j = 0; j < mydata.Rows.Count; j++)  //....but for each column go through each row in the datatable first  
        {
            sb.Append(mydata.Rows[j][u].ToString()); // and add the elements to the stringbuilder - here the transposing is actually done

            if (j < mydata.Rows.Count - 1)   //add a deliminator after each element because you want a .csv as output again 
            {
                sb.Append(';');
            }
        }
        sb.AppendLine(); //add another line to your stringbuilder in which you will store the next column of your datatable
    }

    File.WriteAllText("/Users/maryamsdgh/Desktop/Output.csv", sb.ToString());  //finally create the output .csv  
*/