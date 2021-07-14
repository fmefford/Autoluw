using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldEditor : MonoBehaviour
{
    public Tile selectedTile;
    public Tilemap world;
    public Tilemap overlay;
    private float currRotation = 0;
    private Vector3Int mousePos;
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
        mousePos = world.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        if (Input.GetMouseButtonDown(1))
        {
            currRotation++;
        }
        if (Input.GetMouseButtonDown(0))
        {
            world.SetTile(mousePos, selectedTile);
            world.SetTransformMatrix(mousePos, Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(0f, 0f, 90f * currRotation),Vector3.one));
        }
        overlay.SetTile(mousePos, selectedTile);
        overlay.SetTransformMatrix(mousePos, Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(0f, 0f, 90f * currRotation), Vector3.one));
    }
}
