using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIInventoryPage : MonoBehaviour
{
    [SerializeField]
    private UIInventoryItem _itemPrefab;

    [SerializeField]
    private RectTransform _contentPanel;

    [SerializeField] 
    private UIInventoryDescription _itemDescription;

    List<UIInventoryItem> listOfUIItems = new List<UIInventoryItem>();

    public Sprite image;
    public int quantity;
    public string title;
    public string description;

    private void Awake()
    {
        Hide();
        _itemDescription.ResetDescription();
    }
    public void InitializeInventoryUI(int inventorysize)
    {
        for (int i = 0; i < inventorysize; i++)
        {
            UIInventoryItem item = Instantiate(_itemPrefab, Vector3.zero, Quaternion.identity);
            item.transform.SetParent(_contentPanel);
            listOfUIItems.Add(item);

            item.OnItemClicked += HandleItemSelection;
            item.OnItemBeginDrag += HandleBeginDrag;
            item.OnItemDroppedOn += HandleSwap;
            item.OnItemEndDrag += HandleEndDrag;
            item.OnRightMouseBtnClick += HandleShowItemActions;
        }
    }

    private void HandleShowItemActions(UIInventoryItem obj)
    {
        
    }

    private void HandleEndDrag(UIInventoryItem obj)
    {
        
    }

    private void HandleSwap(UIInventoryItem obj)
    {
        
    }

    private void HandleBeginDrag(UIInventoryItem obj)
    {
        
    }

    private void HandleItemSelection(UIInventoryItem obj)
    {
        _itemDescription.SetDescription(image, title, description);
        listOfUIItems[0].Select();
    }

    public void Show()
    {
        gameObject.SetActive(true);
        _itemDescription.ResetDescription();

        listOfUIItems[0].SetData(image, quantity);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
