using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.UI;
using Unity.Mathematics;

public class sendNewSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public Slider sliderThreshold;
    public TextMeshProUGUI sliderText;
    public TextMeshProUGUI sliderThresholdText;
    public UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets.DynamicMoveProvider dynamicMoveProvider;
    public HandMovementController handMovementController;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sliderText.text = math.round(slider.value).ToString();
        sliderThresholdText.text = sliderThreshold.value.ToString();
        dynamicMoveProvider.moveSpeed = slider.value;
        handMovementController.movementSpeed = slider.value;
        handMovementController.threshhold = sliderThreshold.value;

    }
}
