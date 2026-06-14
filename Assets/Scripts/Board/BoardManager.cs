using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public int boardSize = 9;
    public float tileSize = 1.0f;

    void Start()
    {
        CreateBoard();
    }

    void CreateBoard()
    {
        for (int y = 0; y < boardSize; y++)
        {
            for (int x = 0; x < boardSize; x++)
            {
                GameObject tile = GameObject.CreatePrimitive(PrimitiveType.Quad);

                tile.name = $"Tile ({x}, {y})";
                tile.transform.position = new Vector3(x * tileSize, y * tileSize, 0);
                tile.transform.localScale = new Vector3(tileSize, tileSize, 1);

                Renderer renderer = tile.GetComponent<Renderer>();

                if ((x + y) % 2 == 0)
                {
                    renderer.material.color = new Color(0.9f, 0.75f, 0.45f);
                }
                else
                {
                    renderer.material.color = new Color(0.8f, 0.6f, 0.3f);
                }
            }
        }
    }
}