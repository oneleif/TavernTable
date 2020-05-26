using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

enum PlacementShape
{
    single, line, rect
}

public class TilePlacement : MonoBehaviour
{
    const int MAX_MAP_SIZE = 25;
    const int MAX_MAP_HEIGHT = 5;

    [SerializeField] Tileset selectedTileset;
    Controls ctrl;
    Camera cam;
    [SerializeField] GameObject ghostPrefab;
    GameObject ghost;
    Vector3 startPos, endPos;
    [SerializeField]PlacementShape shape = PlacementShape.single;

    MapLevel[] levels;

    struct MapLevel
    {
        public GameObject[][] array;
    }

    private void Awake()
    {
        startPos = Vector3.zero;
        endPos = Vector3.zero;

        cam = Camera.main;
        ctrl = GameManager.controls;
        ctrl.MapEditor.Enable();
        ctrl.MapEditor.LeftMouseButton.performed += ctx => LMBDown();
        ctrl.MapEditor.LeftMouseButton.canceled += ctx => LMBUp();
        ghost = Instantiate(ghostPrefab, Vector3.down * 100, Quaternion.identity);

        InitMapArray();
    }

    private void Update()
    {
        ShowGhost();
    }

    void ShowGhost()
    {   
        //Temporary testing logic - should use the correct tile from the set!!
        ghost.transform.position = GetCursorWorldPosition();
    }

    void LMBDown()
    {
        startPos = GetCursorWorldPosition();
        print(startPos);
        switch(shape){
            case PlacementShape.single:
                PlaceTileSingle((int)startPos.x, (int)startPos.z);
                break;
            case PlacementShape.line:
                break;
            case PlacementShape.rect:
                break;
        }
    }

    void LMBUp()
    {
        endPos = GetCursorWorldPosition();

        switch (shape)
        {
            case PlacementShape.single:
                break;

            case PlacementShape.rect:

                int startX, endX, startY, endY;
                startX = (int)startPos.x;
                startY = (int)startPos.z;
                endX = (int)endPos.x;
                endY = (int)endPos.z;
                PlaceTileRect(startX, startY, endX, endY);
                break;
        }

    }

    void PlaceTileSingle(int x, int y)
    {
        print(startPos);
        Instantiate(selectedTileset.Floor, new Vector3(x, 0, y), Quaternion.identity);
    }

    public void PlaceTileRect(int sx, int sy, int ex, int ey)
    {

        Debug.Log("NEW RECT: (" + sx + "," + sy + ") TO (" + ex + "," + ey + ")");

        for(int x = sx; x <= ex; x+=2)
        {
            for (int y = sy; y <= ey; y+=2)
            {
                Instantiate(selectedTileset.Floor, new Vector3(x, 0, y), Quaternion.identity);
            }
        }
    }

    

    Vector3 GetCursorWorldPosition()
    {
        Vector3 pos = Vector3.zero;

        RaycastHit hit;
        if (Physics.Raycast(cam.ScreenPointToRay(ctrl.MapEditor.MousePosition.ReadValue<Vector2>()), out hit))
        {
            pos = hit.point;
        }

        pos.x = Mathf.Round(pos.x / 2) * 2;
        pos.y = Mathf.Round(pos.y / 2) * 2;
        pos.z = Mathf.Round(pos.z / 2) * 2;

        return pos;
    }

    void InitMapArray()
    {
        levels = new MapLevel[MAX_MAP_HEIGHT];
    }

}
