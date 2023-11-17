using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildObjectController : MonoBehaviour
{
     private int currentIndex = 0;
    private int totalChildObjects;

    private void Start()
    {
        // Get the total number of child objects
        totalChildObjects = transform.childCount;

        // Initialize by activating the first child object
        ActivateChild(currentIndex);
    }

    private void ActivateChild(int index)
    {
        // Deactivate all child objects
        for (int i = 0; i < totalChildObjects; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

        // Activate the specified child object
        transform.GetChild(index).gameObject.SetActive(true);
    }

    public void NextChild()
    {
        // Move to the next child object
        currentIndex = (currentIndex + 1) % totalChildObjects;

        // Activate the new child object
        ActivateChild(currentIndex);
    }

    public void PreviousChild()
    {
        // Move to the previous child object
        currentIndex = (currentIndex - 1 + totalChildObjects) % totalChildObjects;

        // Activate the new child object
        ActivateChild(currentIndex);
    }
}

