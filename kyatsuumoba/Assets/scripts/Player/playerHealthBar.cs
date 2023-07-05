using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealthBar : MonoBehaviour
{
    public GameObject unit;
    public Vector2 offSet;
    Vector2 GetScreenPosition(Vector3 worldPos)
    {
        return Camera.main.WorldToScreenPoint(worldPos);
    }
    void FollowUnit() {
        Vector2 pos = GetScreenPosition(unit.transform.position + new Vector3(0f, 2.2f, 0f));
        pos += offSet;
        transform.position = pos;   
    }
    // Update is called once per frame
    void LateUpdate()
    {
        FollowUnit();


    }


}
    