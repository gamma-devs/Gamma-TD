using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustTileSize : MonoBehaviour
{
    public Transform tiles;

    //screen dimensions
    const float DIMENSION_X = 1080f;
    const float DIMENSION_Y = 2246f;

    float tile_scale_x = 1f;
    float tile_scale_y = 1f;

    //Adjust the tile scales according to what the screen size currently is.
    float curr_dim_x;
    float curr_dim_y;

    // Start is called before the first frame update
    void Start()
    {
        curr_dim_x = Screen.width;
        curr_dim_y = Screen.height;

        tile_scale_x = curr_dim_x / DIMENSION_X;
        tile_scale_y = curr_dim_y / DIMENSION_Y;
        Debug.Log(curr_dim_x + " " + curr_dim_y);
        tiles.transform.localScale = new Vector3(tile_scale_x, tile_scale_y, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
