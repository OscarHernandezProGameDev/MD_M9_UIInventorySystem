using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventsManager : MonoBehaviour, IPointerClickHandler
{
    private GameObject currentSelection;
    private SetEvent currentSetEvent;

    private void Awake()
    {
        currentSelection = null;
    }

    public void SetCurrentSelection(GameObject selection)
    {
        if (currentSelection != selection)
        {
            if (currentSelection != null)
                currentSetEvent.Deselected();

            currentSetEvent = selection.GetComponent<SetEvent>();

            currentSetEvent.Selected();
            currentSelection = selection;
        }
        else
            CleanSelection();
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
        }
    }
}
