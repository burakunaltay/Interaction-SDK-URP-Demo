using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;


public class HandObserverMenu : MonoBehaviour
{
    public GameObject menu_ui;

    [SerializeField]
    public GameObject leftHandText;

    [SerializeField]
    public GameObject HandednessText;
    

    // Start is called before the first frame update
    void Start()
    {
        Assert.IsTrue(menu_ui != null);
        Assert.IsTrue(leftHandText != null);
    }

    public void UpdateHandStatus()
    {
        //menu_ui.
        leftHandText.GetComponent<TextMeshProUGUI>().text = "Left Hand: " + OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger).ToString();
        var dominantHand = OVRInput.GetDominantHand();
        HandednessText.GetComponent<TextMeshProUGUI>().text = "Dominant Hand: " + dominantHand.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        UpdateHandStatus();
    }
}
