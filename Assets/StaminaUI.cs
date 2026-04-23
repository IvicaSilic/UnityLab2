using UnityEngine;
using UnityEngine.UI;

public class StaminaUI : MonoBehaviour
{
    public Slider staminaSlider;
    public PlayerController playerController;

    void Update()
    {
        staminaSlider.value = playerController.GetStamina() / playerController.GetMaxStamina();
    }
}