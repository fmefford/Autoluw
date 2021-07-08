using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldEditor : MonoBehaviour
{
    public Tile selectedTile;
    public Tilemap world;
    // Start is called before the first frame update
    void Start()
    {
        world = world.GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            world.SetTile(world.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition)), selectedTile);
        }
    }
}
