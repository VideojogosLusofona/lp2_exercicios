using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    // Get the Text Box to use.
    [SerializeField]
    Text textBox;

    // Update is called once per frame
    void Update()
    {
        // Test to see if it works.
        textBox.text = ReadInput.GetMovement().ToString();
    }
}
