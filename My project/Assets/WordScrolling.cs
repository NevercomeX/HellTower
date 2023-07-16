using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordScrolling : MonoBehaviour
{
    [SerializeField] Transform PlayerTransform;
    Vector2Int currentTilePosition;
    GameObject[,] terrainTiles;

    [SerializeField] int terrainTileHorizontalCount;
    [SerializeField] int terrainTileVerticalCount;

    private void Awake()
    {
        terrainTiles = new GameObject[terrainTileHorizontalCount, terrainTileVerticalCount];
    }

    public void Add(GameObject tilePosition, Vector2Int tilePosition)
    {
        terrainTiles[tilePosition.x, tilePosition.y] = tilePosition;
    }

}   
