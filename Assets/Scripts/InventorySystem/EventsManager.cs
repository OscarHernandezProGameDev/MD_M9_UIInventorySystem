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
    private GameObject currentDisplayOptions;

    private Color transparent = new Color(0, 0, 0, 0);

    private void Awake()
    {
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
        }
        else
            CleanSelection();
    }

    public void SetCurrentDisplayOptions(GameObject selection, GameObject displayOptions, Item item)
    {
        currentDisplayOptions = displayOptions;

        if (currentSelection != selection)
            SetCurrentSelection(selection, item);

        if (displayOptions.activeInHierarchy)
            displayOptions.SetActive(false);
        else
            displayOptions.SetActive(true);
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

        if (currentDisplayOptions != null)
        {
            currentDisplayOptions.SetActive(false);
            currentDisplayOptions = null;
        }
    }

    private string AddSpacesToCamelCase(string text)
    {
        return Regex.Replace(text, "(\\B[A-Z])", " $1");
    }
}
