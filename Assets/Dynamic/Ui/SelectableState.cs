using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectableState : MonoBehaviour, ISelectHandler
{
    [HideInInspector] public bool selected = false;
    public void OnSelect(BaseEventData eventData)
    {
        Debug.Log(this.gameObject.name + " was selected");
        selected = true;
    }

    public void OnDeselect(BaseEventData data) //Delay added because when you press join it deseelects
    {
        Debug.Log("Deselected");
        StartCoroutine(deSelect(0.25f));
    }

    IEnumerator deSelect(float delay)
    {
        yield return new WaitForSeconds(delay);
        selected = false;
    }
}
