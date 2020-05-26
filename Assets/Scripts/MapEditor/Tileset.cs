using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tileset", menuName = "TavernTable/Tileset")]
public class Tileset : ScriptableObject
{
    public GameObject Corner, Wall, Floor, Door, Stairs;
}
