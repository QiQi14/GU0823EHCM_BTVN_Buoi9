using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
namespace BaseIso { 
[CreateAssetMenu(fileName = "New Rule Tile", menuName = "Tiles/Rule Tile")]

public class BaseIsometric : RuleTile //RuleTile save data
{
    public bool Walkable;
    public TileType TileType;

    public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
    {
        base.GetTileData(position, tilemap, ref tileData);
    }
}

public enum TileType
{
    Grass,
    Ground,
    WaterGround,
    Water,
    WaterFlow1,
    WaterFlow2,
    Rock1,
    Rock2,
    Rock3,
    Flower,
    Tree1,
    Tree2,
}
}