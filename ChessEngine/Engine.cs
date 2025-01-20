using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Engine
{ 
    public static void Main(string[] args)
    {
        //Perft.runTest(); 
        Board board = new Board();
        board.initStandardChess();
        var timer = Stopwatch.StartNew();
        long nodes = Perft.perft(board, 6, true, new());
        Console.WriteLine("Nodes: " + nodes); 
        Console.WriteLine("NPS: "+ nodes /(timer.ElapsedMilliseconds/1000));
    }

}



