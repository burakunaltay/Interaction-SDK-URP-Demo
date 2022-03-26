using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class HandObserver : MonoBehaviour
{
    [SerializeField]
    public OVRHand leftHand;
    [SerializeField]
    public OVRHand rightHand;

    [SerializeField]
    public HandObserverMenu menu;

    // Start is called before the first frame update
    void Start()
    {
        Assert.IsTrue(leftHand != null && rightHand != null);
        
    }

    [SerializeField]
    public Transform leftHandTransform;
    [SerializeField]
    public Transform rightHandTransform;

    public void get_hand_data()
    {
        leftHandTransform = leftHand.transform;
        rightHandTransform = rightHand.transform;

        menu.leftHandText.GetComponent<TMPro.TextMeshProUGUI>().text = "Left Hand: ";
        if(leftHand.GetFingerIsPinching(OVRHand.HandFinger.Index))
        {
            menu.HandednessText.GetComponent<TMPro.TextMeshProUGUI>().text += "Index is Pinching";
        }
        else
        {
            menu.HandednessText.GetComponent<TMPro.TextMeshProUGUI>().text += "Index is not Pinching";
        }


        Debug.Log("left hand position: " + leftHand.transform.position);
        Debug.Log("right hand position: " + rightHand.transform.position);
        Debug.Log("left hand rotation: " + leftHand.transform.rotation);
        Debug.Log("right hand rotation: " + rightHand.transform.rotation);

        
    }


    public void Update()
    {
        get_hand_data();
    }
}
