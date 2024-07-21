using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SetEvent : MonoBehaviour
{
    private EventTrigger eventTrigger;
    private EventsManager eventsManager;

    private Image borderImage;
    private GameObject displayOptions;

    public Item item;

    public void Selected()
    {
        borderImage.enabled = true;
    }

    public void Deselected()
    {
        borderImage.enabled = false;
        if (displayOptions.activeInHierarchy)
            displayOptions.SetActive(false);
    }

    private void Awake()
    {
        eventTrigger = gameObject.AddComponent<EventTrigger>();
        eventsManager = FindAnyObjectByType<EventsManager>();
        borderImage = gameObject.transform.Find("Border").GetComponent<Image>();
        displayOptions = transform.Find("DisplayOptions").gameObject;
        displayOptions.SetActive(false);

        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((data) => { OnItemClicked((PointerEventData)data); });
        eventTrigger.triggers.Add(entry);
    }

    private void OnItemClicked(PointerEventData data)
    {
        if (data.button == PointerEventData.InputButton.Left)
            eventsManager.SetCurrentSelection(gameObject, item);
        else if (data.button == PointerEventData.InputButton.Right)
            eventsManager.SetCurrentDisplayOptions(gameObject, displayOptions, item);
    }
}
