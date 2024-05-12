/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then display "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze {
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX;
    private int _currY;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap, int startX, int startY) {
        _mazeMap = mazeMap;
        _currX = startX;
        _currY = startY;
    }

    // Todo Maze Problem - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public bool MoveLeft()
    {
        if (_mazeMap.ContainsKey(new ValueTuple<int, int>(_currX, _currY)) && _mazeMap[new ValueTuple<int, int>(_currX, _currY)][0])
        {
            _currX--;
            return true; // Return true to indicate successful movement
        }
        else
        {
            Console.WriteLine("Can't go left!");
            return false; 
        }
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public bool MoveRight()
    {
        if (_mazeMap.ContainsKey(new ValueTuple<int, int>(_currX, _currY)) && _mazeMap[new ValueTuple<int, int>(_currX, _currY)][1])
        {
            _currX++;
            return true;
        }
        else
        {
            Console.WriteLine("Can't go right!");
            return false; 
        }
    }


    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public bool MoveUp()
    {
        if (_mazeMap.ContainsKey(new ValueTuple<int, int>(_currX, _currY)) && _mazeMap[new ValueTuple<int, int>(_currX, _currY)][2])
        {
            _currY--;
            return true;
        }
        else
        {
            Console.WriteLine("Can't go up!");
            return false; 
        }
    }


    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public bool MoveDown()
    {
        if (_mazeMap.ContainsKey(new ValueTuple<int, int>(_currX, _currY)) && _mazeMap[new ValueTuple<int, int>(_currX,_currY)][3])
        {
            _currY++;
            return true;
        }
        else
        {
            Console.WriteLine("Can't go down!");
            return false; 
        }
    }

    public void ShowStatus() {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }
}