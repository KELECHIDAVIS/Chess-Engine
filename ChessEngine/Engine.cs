﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Engine
{
  
    public static void Main(string[] args)
    {
        Board board = new Board();
        board.initStandardChess();

        /*// test that the pawn moves still work
        Console.WriteLine("Current Board");
        Board.printBitBoard(board.sideBB[(int)Side.White] | board.sideBB[(int)Side.Black]); 
        string pawnMoves = Moves.possibleMoves(Side.White, "2725", board.piecesBB, board.sideBB);

        string currentMove = ""; 
        for(int i =0; i<pawnMoves.Length; i++) {
            if(i%4==0) {
                Console.WriteLine(currentMove);
                currentMove = ""; 
            }
            currentMove += pawnMoves[i]; 
        }
        Console.WriteLine(currentMove);*/


        //Testing relevant occupancy masks 
        Console.WriteLine("_________ROOKS__________");
        for (int i = 0; i < 64; i++)
        {
            ulong movementMask = SlidingMoves.getRookMovementMask(i); 
            Board.printBitBoard(movementMask);
            Console.WriteLine("On bits: "+ SlidingMoves.getNumberOnBits(movementMask));
        }
        Console.WriteLine("_________BISHOP__________"); 
        for (int i= 0; i<64; i++) {
            ulong movementMask = SlidingMoves.getBishopMovementMasks(i);
            Board.printBitBoard(movementMask);
            Console.WriteLine("On bits: " + SlidingMoves.getNumberOnBits(movementMask)); 
        }
    }
}

    
