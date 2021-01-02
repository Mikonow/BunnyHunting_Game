using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialHideShow : MonoBehaviour
{
    public RawImage tutorial_window;
    public RawImage tutorial_hint;

    bool tuto_on;
    // Start is called before the first frame update
    void Start()
    {
        tuto_on = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            if (tuto_on)
            {
                tutorial_window.enabled = false;
                tutorial_hint.enabled = true;

                tuto_on = false;
            }
            else
            {
                tutorial_window.enabled = true;
                tutorial_hint.enabled = false;

                tuto_on = true;
            }
        }
    }
}
