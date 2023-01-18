using UnityEngine;
using UnityEngine.Tilemaps;

//giving a refrence to tiles 
public enum Tetromino
{
    I,
    O,
    L,
    J,
    T,
    S,
    Z,
}

//show data in the engine 
[System.Serializable]

// setting a data class to store info on tiles
public struct TetrominoData
{
    public Tetromino tetromino;
    public Tile tile;
    public Vector2Int[] cells{ get; private set;}
    
    public void Initialize()
    {
        this.cells = Data.Cells[this.tetromino];
    }
}