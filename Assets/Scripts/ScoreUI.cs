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
    public int scorehitcount;
    void Start()
    {
        scorehitcount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SetHitcount(scorehitcount);
    }
    private void SetHitcount(int hitcount)
    {
        TextMeshProUGUI monTextMeshProUGUI = GetComponent<TextMeshProUGUI>();
        monTextMeshProUGUI.SetText("Score : " + hitcount);
    }
}
