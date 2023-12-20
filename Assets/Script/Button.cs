using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Button : MonoBehaviour
{
    public Scene scene;
    public GameObject phare;
    public GameObject pivot;
    public Camera cam;
    public GameObject image;
    public Active active;
    public int level = 1;
    public Vector3 limUp;
    public Vector3 limDown;
    public GameObject T1S0;
    public GameObject T2S0;
    public GameObject T3S0;
    public GameObject T4S0;
    public GameObject T1S1;
    public GameObject T2S1;
    public GameObject T3S1;
    public GameObject T4S1;
    public GameObject T1S2;
    public GameObject T2S2;
    public GameObject T3S2;
    public GameObject T4S2;

    public GameObject stand0;
    public GameObject stand1;
    public GameObject stand2;
    public GameObject stand3;

    public GameObject standUp0;
    public GameObject standUp1;
    public GameObject standUp2;
    public GameObject standUp3;
    public GameObject upg;
    public GameObject bld;
    public Focus_Bat foc;
    public GameObject moneyMana;
    public Money moneyMult;

    public Focus_Obj focO;
    public GameObject reno;
    public GameObject renov0;
    public GameObject renov1;
    public GameObject renov2;
    public GameObject renov3;
    public GameObject renov4;
    public GameObject renov5;
    public GameObject renov6;
    public GameObject renov7;

    public bool estRenov0=false;
    public bool estRenov1=false;
    public bool estRenov2=false;
    public bool estRenov3=false;
    public bool estRenov4=false;
    public bool estRenov5=false;
    public bool estRenov6=false;
    public bool estRenov7=false;

    public GameObject TR1;
    public GameObject TR2;
    public GameObject TR3;
    public GameObject TR4;
    public GameObject TR5;
    public GameObject TR6;
    public GameObject TR7;
    public GameObject TR8;

    void Start()
    {
        limDown = new Vector3(pivot.transform.position.x, pivot.transform.position.y, pivot.transform.position.z);
        limUp = new Vector3(pivot.transform.position.x, pivot.transform.position.y + (42 * level - 1), pivot.transform.position.z);
        if (moneyMana != null)
        {
            moneyMult = moneyMana.GetComponent<Money>();
        }
        scene = SceneManager.GetActiveScene();
        
        
    }
    private void Update()
    {
        if (level == 1)
        {
            if (estRenov0 == true && estRenov1 == true)
            {
                level += 1;
            }
        }

        if (level == 2)
        {
            if (estRenov2 == true && estRenov3 == true && estRenov4==true)
            {
                level += 1;
            }
        }

        if (level == 3)
        {
            if (estRenov5 == true && estRenov6 == true)
            {
                level += 1;
            }
        }
        if (level == 4)
        {
            if (estRenov7 == true)
            {
                level += 1;
            }
        }
    }
    public void Zoom_Phare()
    {
        pivot.transform.position = phare.transform.position;
    }

    public void Up()
    {
        if (active.activate == false)
        {
            if (level >= 2 && pivot.transform.position.y + 42 < limUp.y)
            {
                Debug.Log(pivot.transform.position.y + 42);
                Debug.Log(limUp.y);
                pivot.transform.position = new Vector3(pivot.transform.position.x, pivot.transform.position.y + 42, pivot.transform.position.z);
            }
        }
    }

    public void Down()
    {
        if (active.activate == false)
        {
            if (pivot.transform.position.y - 42 >= limDown.y - 1)
            {
                pivot.transform.position = new Vector3(pivot.transform.position.x, pivot.transform.position.y - 42, pivot.transform.position.z);
            }
        }
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }



    public void Renovate()
    {
        if (focO.id == 0)
        {
            if (Money.score >= 10) {
                Money.score -= 10;
                GameObject newObject = Instantiate(renov0);
                newObject.transform.position = focO.gameObject.transform.position;
                newObject.transform.rotation = focO.gameObject.transform.rotation;
                newObject.transform.localScale = focO.gameObject.transform.localScale;
                reno.SetActive(false);
                estRenov0 = true;
                Destroy(focO.gameObject);
            }
        }
        if (focO.id == 1)
        {
            if (Money.score >= 30)
            {
                Money.score -= 30;
                GameObject newObject = Instantiate(renov1);
                newObject.transform.position = focO.gameObject.transform.position;
                newObject.transform.rotation = focO.gameObject.transform.rotation;
                newObject.transform.localScale = focO.gameObject.transform.localScale;
                reno.SetActive(false);
                estRenov1=true;
                Destroy(focO.gameObject);
            }
        }
        if (focO.id == 2)
        {
            if (Money.score >= 60)
            {
                Money.score -= 60;
                GameObject newObject = Instantiate(renov2);
                newObject.transform.position = focO.gameObject.transform.position;
                newObject.transform.rotation = focO.gameObject.transform.rotation;
                newObject.transform.localScale = focO.gameObject.transform.localScale;
                reno.SetActive(false);
                estRenov2 = true;
                Destroy(focO.gameObject);
            }
        }
        if (focO.id == 3)
        {
            if (Money.score >= 100)
            {
                Money.score -= 100;
                GameObject newObject = Instantiate(renov3);
                newObject.transform.position = focO.gameObject.transform.position;
                newObject.transform.rotation = focO.gameObject.transform.rotation;
                newObject.transform.localScale = focO.gameObject.transform.localScale;
                reno.SetActive(false);
                estRenov3 = true;
                Destroy(focO.gameObject);
            }
        }
        if (focO.id == 4)
        {
            if (Money.score >= 150)
            {
                Money.score -= 150;
                GameObject newObject = Instantiate(renov4);
                newObject.transform.position = focO.gameObject.transform.position;
                newObject.transform.rotation = focO.gameObject.transform.rotation;
                newObject.transform.localScale = focO.gameObject.transform.localScale;
                reno.SetActive(false);
                estRenov4 = true;
                Destroy(focO.gameObject);
            }
        }
        if (focO.id == 5)
        {
            if (Money.score >= 750)
            {
                Money.score -= 750;
                GameObject newObject = Instantiate(renov5);
                newObject.transform.position = focO.gameObject.transform.position;
                newObject.transform.rotation = focO.gameObject.transform.rotation;
                newObject.transform.localScale = focO.gameObject.transform.localScale;
                reno.SetActive(false);
                estRenov5 = true;
                Destroy(focO.gameObject);
            }
        }
        if (focO.id == 6)
        {
            if (Money.score >= 1000)
            {
                Money.score -= 1000;
                GameObject newObject = Instantiate(renov6);
                newObject.transform.position = focO.gameObject.transform.position;
                newObject.transform.rotation = focO.gameObject.transform.rotation;
                newObject.transform.localScale = focO.gameObject.transform.localScale;
                reno.SetActive(false);
                estRenov6 = true;
                Destroy(focO.gameObject);
            }
        }
        if (focO.id == 7)
        {
            if (Money.score >= 4000)
            {
                Money.score -= 4000;
                GameObject newObject = Instantiate(renov7);
                newObject.transform.position = focO.gameObject.transform.position;
                newObject.transform.rotation = focO.gameObject.transform.rotation;
                newObject.transform.localScale = focO.gameObject.transform.localScale;
                reno.SetActive(false);
                estRenov7 = true;
                Destroy(focO.gameObject);
            }
        }
    }
}
