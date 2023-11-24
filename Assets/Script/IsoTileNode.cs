using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IsoTileNode : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField]
    private GameObject highlightTile;

    public bool Walkable;
    public TileType tileType;
    public TileDataSet tileData;
    public TileNode previousTile;

    public UnitBase occupiedUnit;

    public bool isAvailable => Walkable && occupiedUnit != null;

    public int x, y;

    private void OnMouseEnter()
    {

        highlightTile.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseExit()
    {

        highlightTile.SetActive(false);
    }

    private void OnMouseDown()
    {
        CombatManager.instance.clear();
        CombatManager.instance.currentTile = this;
        CombatManager.instance.inspectTile();
    }
}

public class TileDataSet
{
    public float costFromOrigin = 0; //G
    public float costToDestination = 0; //F
    public int terrainCost = 0;

    public float totalCost { get { return costFromOrigin /*G*/ + costToDestination /*H*/ + terrainCost; } }
}//F
