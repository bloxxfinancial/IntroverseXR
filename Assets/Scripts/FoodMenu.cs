using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject introBeer;
    public GameObject introWine;
    public GameObject introCocktail;
    public GameObject introSnacks;
    public GameObject menuController;

    public void EnterBeer()
    {
        mainMenu.SetActive(false);
        introBeer.SetActive(true);
        introWine.SetActive(false);
        introCocktail.SetActive(false);
        introSnacks.SetActive(false);
    }

    public void EnterWine()
    {
        mainMenu.SetActive(false);
        introBeer.SetActive(false);
        introWine.SetActive(true);
        introCocktail.SetActive(false);
        introSnacks.SetActive(false);
    }

    public void EnterCocktail()
    {
        mainMenu.SetActive(false);
        introBeer.SetActive(false);
        introWine.SetActive(false);
        introCocktail.SetActive(true);
        introSnacks.SetActive(false);
    }

    public void EnterSnacks()
    {
        mainMenu.SetActive(false);
        introBeer.SetActive(false);
        introWine.SetActive(false);
        introCocktail.SetActive(false);
        introSnacks.SetActive(true);
    }

    public void EnterBuy()
    {
        mainMenu.SetActive(true);
        introBeer.SetActive(false);
        introWine.SetActive(false);
        introCocktail.SetActive(false);
        introSnacks.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            menuController.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            menuController.SetActive(false);
        }
    }



}
