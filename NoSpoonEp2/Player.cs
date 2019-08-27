using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * The machines are gaining ground. Time to show them what we're really made of...
 **/
public class Player
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
        int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis
        for (int i = 0; i < height; i++)
        {
            string line = Console.ReadLine(); // width characters, each either a number or a '.'
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");


        // Two coordinates and one integer: a node, one of its neighbors, the number of links connecting them.
        Console.WriteLine("0 0 2 0 1");
    }
}