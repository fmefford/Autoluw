using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapManager : MonoBehaviour
{
    private Tilemap map;
    // Start is called before the first frame update
    void Start()
    {
        map = this.GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// This function updates the road at a given position on the tilemap. It will ensure that the tile at the position and all surronding positions appear continuous. 
    /// </summary>
    /// <param name="pos"> The position at which to update the road. </param>
    public void updateRoad(Vector3Int pos)
    {
        bool[] adjacentTiles = { false, false, false, false };
        for (int i = -1; i < 2; i += 2)
        {
            if (map.HasTile(new Vector3Int(pos.x, pos.y += i, pos.z)))
            {
                adjacentTiles[i + 1] = true;
            }
            if (map.HasTile(new Vector3Int(pos.x += i, pos.y, pos.z)))
            {
                adjacentTiles[i + 2] = true;
            }
        }
        if (map.HasTile(pos))
        {

        }
    }
}
