using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EventsManager : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Image currentSelectionImage;
    [SerializeField] private TextMeshProUGUI currentSelectionTitle;
    [SerializeField] private TextMeshProUGUI currentSelectionDescription;

    private GameObject currentSelection;
    private SetEvent currentSetEvent;
    private GameObject selectedDisplayOptions;

    private Player player;
    private Inventory myInventory;

    private Button dropButton;
    private Button useButton;

    private Color transparent = new Color(0, 0, 0, 0);

    private void Awake()
    {
        player = FindAnyObjectByType<Player>();

        currentSelection = null;
        currentSelectionImage.color = transparent;
        currentSelectionTitle.SetText("");
        currentSelectionDescription.SetText("");
    }

    public void SetCurrentSelection(GameObject selection, Item item)
    {
        if (currentSelection != selection)
        {
            if (currentSelection != null)
                currentSetEvent.Deselected();

            currentSetEvent = selection.GetComponent<SetEvent>();

            currentSetEvent.Selected();
            currentSelection = selection;

            currentSelectionImage.sprite = item.GetSprite();
            currentSelectionImage.color = Color.white;
            currentSelectionTitle.SetText(AddSpacesToCamelCase(item.itemType.ToString()));
            currentSelectionDescription.SetText(item.GetDescription());

            myInventory = player.GetInventory();
        }
        else
            CleanSelection();
    }

    public void SetCurrentDisplayOptions(GameObject selection, GameObject displayOptions, Item item, int id)
    {
        selectedDisplayOptions = displayOptions;

        if (currentSelection != selection)
            SetCurrentSelection(selection, item);

        if (displayOptions.activeInHierarchy)
            displayOptions.SetActive(false);
        else
        {
            displayOptions.SetActive(true);
            dropButton = displayOptions.transform.Find("Panel/Button_Drop").GetComponent<Button>();
            dropButton.onClick.AddListener(() => DropItem(item, id));

            useButton = displayOptions.transform.Find("Panel/Button_Use").GetComponent<Button>();

            if (!item.IsStackable())
                useButton.interactable = false;
            else
                useButton.onClick.AddListener(() => UseItem(item, id));
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        CleanSelection();
    }

    public void CleanSelection()
    {
        if (currentSelection != null)
        {
            currentSetEvent.Deselected();
            currentSetEvent = null;
            currentSelection = null;
            currentSelectionImage.color = transparent;
            currentSelectionTitle.SetText("");
            currentSelectionDescription.SetText("");
        }

        if (selectedDisplayOptions != null)
        {
            selectedDisplayOptions.SetActive(false);
            selectedDisplayOptions = null;
        }
    }

    public void UseItem(Item item, int id)
    {
        if (item.id == id)
        {
            player.UseItem(item);
            CleanSelection();
        }
    }

    public void DropItem(Item item, int id)
    {
        if (item.id == id)
        {
            Item duplicateItem = new Item { itemType = item.itemType, amount = item.amount };

            myInventory.RemoveItem(item);
            CleanSelection();
            ItemWorld.DropItem(player.GetPosition(), duplicateItem);
        }
    }

    private string AddSpacesToCamelCase(string text)
    {
        return Regex.Replace(text, "(\\B[A-Z])", " $1");
    }
}
