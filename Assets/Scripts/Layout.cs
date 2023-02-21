using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
using UnityEngine;

public class Layout : MonoBehaviour
{
    PaintBrush brush;
    XRSimpleInteractable interactable;
    // Start is called before the first frame update
    void Start()
    {
        brush = FindObjectOfType<PaintBrush>();
        interactable = GetComponent<XRSimpleInteractable>();
        interactable.selectEntered.AddListener(onSelect);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onDestroy()
    {
        if (interactable!= null)
        {
            interactable.selectEntered.RemoveListener(onSelect);
        }
    }

    private void onSelect(SelectEnterEventArgs arg)
    {
        UpdateBrushColor();
    }
    [ContextMenu("UpdateBrushColor")]
    public void UpdateBrushColor()
    {
        Color iconColor = GetComponent<Image>().color;
        brush.paintColor = iconColor;
    }
}
