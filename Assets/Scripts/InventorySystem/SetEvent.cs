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

    public Item item;

    public void Selected()
    {
        borderImage.enabled = true;
    }

    public void Deselected()
    {
        borderImage.enabled = false;
    }

    private void Awake()
    {
        eventTrigger = gameObject.AddComponent<EventTrigger>();
        eventsManager = FindAnyObjectByType<EventsManager>();
        borderImage = gameObject.transform.Find("Border").GetComponent<Image>();

        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((data) => { OnItemClicked((PointerEventData)data); });
        eventTrigger.triggers.Add(entry);
    }

    private void OnItemClicked(PointerEventData data)
    {
        eventsManager.SetCurrentSelection(gameObject, item);
    }
}
