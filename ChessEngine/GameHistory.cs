﻿
public struct GameHistory // a list class that hold all the gamestates (kinda like a stack for states ) 
{
    static readonly int MAX_GAME_MOVES = 2048; // can be more but should never reach this number realistically 
    GameState[] list;
    uint count; // keeps track of elements in use 

    public GameHistory()
    {
        count = 0 ;
        list = new GameState[MAX_GAME_MOVES]; 
    }

    public void push (GameState state)
    {
        list[count] = state ;
        count ++;
    }

    public uint length()
    {
        return count; 
    }

    public GameState getState(int index)
    {
        return list[index];
    }

    public GameState? pop()
    {
        if (count > 0)
        {
            GameState state = list[count-1];
            count--;
            return state;
        }
        return null; 
    }

    public void clear()
    {
        count = 0; 
        list = new GameState[MAX_GAME_MOVES]; 
    }

    public GameHistory getCopy() {
        GameHistory temp = new GameHistory();
        temp.count = count;
        Array.Copy(list, temp.list, list.Length);
        return temp; 
    }
}