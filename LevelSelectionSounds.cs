using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LevelSelectionSounds : MonoBehaviour
{

    public AudioSource[] sounds;
    Button meButton;


    void Start()
    {
        meButton = gameObject.GetComponent<Button>();

        EventTrigger trigger = GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerEnter;
        entry.callback.AddListener((data) => { OnPointerEnterDelegate((PointerEventData)data); });
        trigger.triggers.Add(entry);


        EventTrigger.Entry entry1 = new EventTrigger.Entry();
        entry1.eventID = EventTriggerType.PointerClick;
        entry1.callback.AddListener((data) => { OnPointerClickedDelegate((PointerEventData)data); });
        trigger.triggers.Add(entry1);

    }

    public void OnPointerEnterDelegate(PointerEventData data)
    {
        if (meButton.interactable == true)
        {
            sounds[0].Play();
        }
    }

    public void OnPointerClickedDelegate(PointerEventData data)
    {
        if (meButton.interactable == true)
        {
            sounds[1].Play();
        }
    }
}
