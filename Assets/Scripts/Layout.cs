using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Layout : MonoBehaviour
{
    // Start is called before the first frame update
    PaintBrush brush;
    XRSimpleInteractable interactable;
    void Start()
    {
        brush= FindObjectOfType<PaintBrush>();
        interactable = GetComponent<XRSimpleInteractable>();
        interactable.selectEntered.AddListener(onSelect);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
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
