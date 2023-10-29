using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Orders : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _sizeText;
    [SerializeField]
    private TMP_Text _iceText;
    [SerializeField]
    private TMP_Text _teaText;
    [SerializeField]
    private TMP_Text _flavorText;
    [SerializeField]
    private TMP_Text _milkText;
    [SerializeField]
    private TMP_Text _bobaText;
    [SerializeField]
    private TMP_Text _addinsText;

    [SerializeField]
    private int _sizeChoice;
    [SerializeField]
    private int _iceChoice;
    [SerializeField]
    private int _teaChoice;
    [SerializeField]
    private int _flavorChoice;
    [SerializeField]
    private int _milkChoice;
    [SerializeField]
    private int _bobaChoice;
    [SerializeField]
    private int _addinsChoice;

    void Start()
    {
        _sizeText = gameObject.transform.GetChild(0).GetComponent<TMP_Text>();
        _iceText = gameObject.transform.GetChild(1).GetComponent<TMP_Text>();
        _teaText = gameObject.transform.GetChild(2).GetComponent<TMP_Text>();
        _flavorText = gameObject.transform.GetChild(3).GetComponent<TMP_Text>();
        _milkText = gameObject.transform.GetChild(4).GetComponent<TMP_Text>();
        _bobaText = gameObject.transform.GetChild(5).GetComponent<TMP_Text>();
        _addinsText = gameObject.transform.GetChild(6).GetComponent<TMP_Text>();
        StartCoroutine(CreateOrder());
    }

    void Update()
    {
        
    }

    private IEnumerator CreateOrder()
    {
        BlankOrder();
        yield return new WaitForSeconds(.5f);
        Size();
        yield return new WaitForSeconds(.5f);
        Ice();
        yield return new WaitForSeconds(.5f);
        Tea();
        yield return new WaitForSeconds(.5f);
        Flavor();
        yield return new WaitForSeconds(.5f);
        Milk();
        yield return new WaitForSeconds(.5f);
        Boba();
        yield return new WaitForSeconds(.5f);
        AddIns();
        yield return new WaitForSeconds(.5f);
        Debug.Log("Order Created");
    }

    private void BlankOrder()
    {
        _sizeText.text = "";
        _iceText.text = "";
        _teaText.text = "";
        _flavorText.text = "";
        _milkText.text = "";
        _bobaText.text = "";
        _addinsText.text = "";
    }

    private void Size()
    {
        _sizeChoice = Random.Range(0, 3);
        switch (_sizeChoice)
        {
            case 0:
                _sizeText.text = "Small";
                break;
            case 1:
                _sizeText.text = "Medium";
                break;
            case 2:
                _sizeText.text = "Large";
                break;
        }
    }

    private void Ice()
    {
        _iceChoice = Random.Range(0, 2);
        switch (_iceChoice)
        {
            case 0:
                _iceText.text = "Ice";
                break;
            case 1:
                _iceText.text = "No Ice";
                break;
        }
    }

    private void Tea()
    {
        _teaChoice = Random.Range(0, 7);
        switch (_teaChoice)
        {
            case 0:
                _teaText.text = "Black Tea";
                break;
            case 1:
                _teaText.text = "Oolong Tea";
                break;
            case 2:
                _teaText.text = "Green Tea";
                break;
            case 3:
                _teaText.text = "Thai Tea";
                break;
            case 4:
                _teaText.text = "Jasmine Tea";
                break;
            case 5:
                _teaText.text = "Earl Gray Tea";
                break;
            case 6:
                _teaText.text = "Matcha Tea";
                break;
        }
    }

    private void Flavor()
    {
        _flavorChoice = Random.Range(0, 24);
        switch (_flavorChoice)
        {
            case 0:
                _flavorText.text = "Strawberry";
                break;
            case 1:
                _flavorText.text = "Peach";
                break;
            case 2:
                _flavorText.text = "Mango";
                break;
            case 3:
                _flavorText.text = "Watermelon";
                break;
            case 4:
                _flavorText.text = "Grape";
                break;
            case 5:
                _flavorText.text = "Rose";
                break;
            case 6:
                _flavorText.text = "Passion Fruit";
                break;
            case 7:
                _flavorText.text = "Dragonfruit";
                break;
            case 8:
                _flavorText.text = "Pineapple";
                break;
            case 9:
                _flavorText.text = "Grapefruit";
                break;
            case 10:
                _flavorText.text = "Lemon";
                break;
            case 11:
                _flavorText.text = "Raspberry";
                break;
            case 12:
                _flavorText.text = "Honeydew";
                break;
            case 13:
                _flavorText.text = "Coconut";
                break;
            case 14:
                _flavorText.text = "Papaya";
                break;
            case 15:
                _flavorText.text = "Blueberry";
                break;
            case 16:
                _flavorText.text = "Banana";
                break;
            case 17:
                _flavorText.text = "Orange";
                break;
            case 18:
                _flavorText.text = "Pear";
                break;
            case 19:
                _flavorText.text = "Avacado";
                break;
            case 20:
                _flavorText.text = "Honey";
                break;
            case 21:
                _flavorText.text = "Coffee";
                break;
            case 22:
                _flavorText.text = "Brown Sugar";
                break;
            case 23:
                _flavorText.text = "Chocolate";
                break;
        }
    }

    private void Milk()
    {
        _milkChoice = Random.Range(0, 3);
        switch (_milkChoice)
        {
            case 0:
                _milkText.text = "Milk";
                break;
            case 1:
                _milkText.text = "Almond Milk";
                break;
            case 2:
                _milkText.text = "No Milk";
                break;
        }
    }

    private void Boba()
    {
        _bobaChoice = Random.Range(0, 18);
        switch (_bobaChoice)
        {
            case 0:
                _bobaText.text = "Tapiocha Boba";
                break;
            case 1:
                _bobaText.text = "Rainbow Crystal Boba";
                break;
            case 2:
                _bobaText.text = "Clear Crystal Boba";
                break;
            case 3:
                _bobaText.text = "Brown Sugar Crystal Boba";
                break;
            case 4:
                _bobaText.text = "Strawberry Popping Boba";
                break;
            case 5:
                _bobaText.text = "Mango Popping Boba";
                break;
            case 6:
                _bobaText.text = "Peach Popping Boba";
                break;
            case 7:
                _bobaText.text = "Passion Fruit Popping Boba";
                break;
            case 8:
                _bobaText.text = "Green Apple Popping Boba";
                break;
            case 9:
                _bobaText.text = "Lychee Jelly Boba";
                break;
            case 10:
                _bobaText.text = "Mango Jelly Boba";
                break;
            case 11:
                _bobaText.text = "Strawberry Jelly Boba";
                break;
            case 12:
                _bobaText.text = "Coffee Jelly Boba";
                break;
            case 13:
                _bobaText.text = "Peach Jelly Boba";
                break;
            case 14:
                _bobaText.text = "Mango Jelly Boba";
                break;
            case 15:
                _bobaText.text = "Rose Jelly Boba";
                break;
            case 16:
                _bobaText.text = "Matcha Jelly Boba";
                break;
            case 17:
                _bobaText.text = "No Boba";
                break;
        }
    }

    private void AddIns()
    {
        _addinsChoice = Random.Range(0, 5);
        switch (_addinsChoice)
        {
            case 0:
                _addinsText.text = "Salted Cheese Cap";
                break;
            case 1:
                _addinsText.text = "Creme Brulee Cap";
                break;
            case 2:
                _addinsText.text = "Yogurt";
                break;
            case 3:
                _addinsText.text = "Oreo";
                break;
            case 4:
                _addinsText.text = "No Add-Ins";
                break;
        }
    }
}