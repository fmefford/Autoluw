using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldEditor : MonoBehaviour
{
    public Tile selectedTile;
    public Tilemap world;
    public Tilemap overlay;
    // Start is called before the first frame update
    void Start()
    {
        world = world.GetComponent<Tilemap>();
        overlay = overlay.GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        overlay.ClearAllTiles();
        if (Input.GetMouseButtonDown(0))
        {
            world.SetTile(world.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition)), selectedTile);
        }
        overlay.SetTile(world.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition)), selectedTile);
    }
}
