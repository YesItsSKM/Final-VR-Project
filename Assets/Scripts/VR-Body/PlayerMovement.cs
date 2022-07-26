using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public OVRPlayerController playerController;

    public TextMeshProUGUI debugText;

    // Start is called before the first frame update
    void Start()
    {
        debugText.text = "Testing begins!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ThumbsUpSelected()
    {
        debugText.text = "Thumbs Up";
    }

    public void ThumbsUpUnselected()
    {
        debugText.text = ".";
    }
}
