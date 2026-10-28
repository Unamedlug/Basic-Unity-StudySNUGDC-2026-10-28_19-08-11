using UnityEngine;
using System.Collections.Generic;
using System;

[CreateAssetMenu(menuName = "Scripts/MapData")]
public class MapData : ScriptableObject
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Serializable]
    public class MapDataRow
    {
        public List<GameManager.EntityType> entityTypes = new List<GameManager.EntityType>();
    }

    public string mapName;
    public List<MapDataRow> mapDataRows = new List<MapDataRow>();
}
