using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{

    public Slider playerSlider3D;
    Slider playerSlider2D;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        playerSlider2D = GetComponent<Slider>();
        playerSlider3D.maxValue = health;
        playerSlider2D.maxValue = health;
    }

    // Update is called once per frame
    void Update()
    {
        playerSlider2D.value = health;
        playerSlider3D.value = playerSlider2D.value;
    }
}
