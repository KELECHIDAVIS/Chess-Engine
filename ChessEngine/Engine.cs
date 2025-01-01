﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Engine
{ 
    public static void Main(string[] args)
    {
        /*bool gameRunning = true;

        Board board = new Board(); 
        
        // ask user for fen string and init board 
        //FOR PROCESSING INPUT OUTPUT USES EXTRA THREAD
        while (gameRunning)
        {
            // process uci input 
        }*/

        /*char[][] chessBoard = new char[][]{
            new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            new char[] { 'k', ' ', ' ', 'P', 'p', ' ', ' ', 'Q' },
            new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            new char[] { ' ', ' ', ' ', 'K', ' ', ' ', ' ', ' ' },
        };
        Board board = Board.charArrayToBoard(chessBoard);
        Moves.printMoves(board); */

        Board board = new Board();
        board.initStandardChess();



        for (int maxDepth = 1; maxDepth <= 5; maxDepth++) {
            Console.WriteLine("MaxDepth: " + maxDepth);
            Dictionary<ulong, int> boardMemo = new Dictionary<ulong, int>();
            int totalMoves = Perft.perft(board, 1, maxDepth, boardMemo);
            Console.WriteLine("Total Nodes: " + totalMoves);
        }



        /*char[][] chessBoard = new char[][]{
            new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            new char[] { ' ', ' ', ' ', ' ', ' ', ' ', 'P', ' ' },
            new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            new char[] { ' ', ' ', ' ', ' ', 'b', ' ', ' ', ' ' },
        };
        Board board = Board.charArrayToBoard(chessBoard);
        Board.printBoard(board);

        ulong bishopBB = board.piecesBB[(int)Side.Black][(int)Piece.Bishop]; 
        int origin= BitOperations.TrailingZeroCount(bishopBB);
        ulong blockerBB = (board.sideBB[(int)Side.White] | board.sideBB[(int)Side.Black]) ^ (1UL << origin);

        ulong rawBishopMoves = Moves.getBishopMoves(blockerBB, origin);
        Console.WriteLine("Raw Bishop Moves");
        Board.printBitBoard(rawBishopMoves); */
    }

}



