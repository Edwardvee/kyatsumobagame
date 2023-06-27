using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class abilities : MonoBehaviour
{
    public Image hab1;
    public float cooldown1 = 5;
    bool isCooldown = false;
    public KeyCode ability1;

    Vector3 position;
    public Canvas abillity1Canvas;
    public Image dash;
    public Transform player;




    public Image hab2;
    public float cooldown2 = 5;
    bool isCooldown2 = false;
    public KeyCode ability2;



    public Image hab3;
    public float cooldown3 = 5;
    bool isCooldown3 = false;
    public KeyCode ability3;



    public Image hab4;
    public float cooldown4 = 5;
    bool isCooldown4 = false;
    public KeyCode ability4;

    
    public Canvas abillity4Canvas;
    public Image skillshot;
  



    // Start is called before the first frame update
    void Start()
    {
        hab1.fillAmount = 0;
        hab2.fillAmount = 0;
        hab3.fillAmount = 0;
        hab4.fillAmount = 0;

        skillshot.GetComponent<Image>().enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        Ability1();
        Ability2();
        Ability3();
        Ability4();

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {

            position = new Vector3(hit.point.x,hit.point.y, hit.point.z);
        }

        Quaternion transRot = Quaternion.LookRotation(position - player.transform.position);
        transRot.eulerAngles = new Vector3(0, transRot.eulerAngles.y, transRot.eulerAngles.z);
        abillity4Canvas.transform.rotation = Quaternion.Lerp(transRot, abillity4Canvas.transform.rotation, 0f);
    }

    void Ability1()
    {
        if(Input.GetKey(ability1) && isCooldown == false){


            isCooldown= true;
            hab1.fillAmount = 1;

        }
     
        if (isCooldown) {
            
            hab1.fillAmount -= 1 / cooldown1 * Time.deltaTime;
        
            if (hab1.fillAmount <= 0) {
             hab1.fillAmount = 0;
                isCooldown = false;
          }
        }
    }
    void Ability2()
    {
        if (Input.GetKey(ability2) && isCooldown2 == false)
        {

            isCooldown2 = true;
            hab2.fillAmount = 1;

        }
        if (isCooldown2)
        {
            hab2.fillAmount -= 1 / cooldown2 * Time.deltaTime;
            if (hab2.fillAmount <= 0)
            {
                hab2.fillAmount = 0;
                isCooldown2 = false;
            }
        }
    }
    void Ability3()
    {
        if (Input.GetKey(ability3) && isCooldown3 == false)
        {

            isCooldown3 = true;
            hab3.fillAmount = 1;

        }
        if (isCooldown3)
        {
            hab3.fillAmount -= 1 / cooldown3 * Time.deltaTime;
            if (hab3.fillAmount <= 0)
            {
                hab3.fillAmount = 0;
                isCooldown3 = false;
            }
        }
    }
    void Ability4()
    {
        if (Input.GetKey(ability4) && isCooldown4 == false)
        {
            skillshot.GetComponent<Image>().enabled = true;
           

        }
        if (skillshot.GetComponent<Image>().enabled == true && Input.GetMouseButton(0))
        {
            isCooldown4 = true;
            hab4.fillAmount = 1;

        }
        if (isCooldown4)
        {
            hab4.fillAmount -= 1 / cooldown4 * Time.deltaTime;
            skillshot.GetComponent<Image>().enabled = false;
            if (hab4.fillAmount <= 0)
            {
                hab4.fillAmount = 0;
                isCooldown4 = false;
            }
        }
    }
}
