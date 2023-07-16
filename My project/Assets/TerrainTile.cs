using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainTile : MonoBehaviour
{

    [SerializeField] Vector2Int tilePosition;

    void Start()
    {
        GetComponentInParent<WordScrolling>().add(gameObject, tilePosition);
    }


}
