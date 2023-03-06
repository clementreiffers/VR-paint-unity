using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class ScoreUI : MonoBehaviour
{
    // Start is called before the first frame update
    Target target;
    void Start()
    {
        target = FindObjectOfType<Target>();
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI monTextMeshProUGUI = GetComponent<TextMeshProUGUI>();
        monTextMeshProUGUI.SetText("Score : " + target.hitCount);

    }
}
