using UnityEngine;

public class Tile : MonoBehaviour
{
    public Vector2Int BoardPosition { get; private set; }
    public GameObject Occupant { get; private set; }

    public bool IsOccupied => Occupant != null;

    public void Initialize(int x, int y)
    {
        BoardPosition = new Vector2Int(x, y);
        name = $"Tile ({x}, {y})";
    }

    public void SetOccupant(GameObject occupant)
    {
        Occupant = occupant;
    }

    public void ClearOccupant()
    {
        Occupant = null;
    }
}
