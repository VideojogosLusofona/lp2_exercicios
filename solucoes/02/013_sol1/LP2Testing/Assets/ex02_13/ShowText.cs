using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    // Get the Text Box to use.
    [SerializeField]
    Text textBox;
    ReadInput readInput;

    // Start is called before the first frame update
    void Start()
    {
        readInput = gameObject.AddComponent<ReadInput>() as ReadInput;
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text = readInput.GetVector2().ToString();
    }
}
