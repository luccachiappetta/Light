using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogTriggerOne : MonoBehaviour
{
    public dialog button;

    public void TriggerDialog()
    {
        FindObjectOfType<dialogManager>().StartDialog(button);
    }
}
