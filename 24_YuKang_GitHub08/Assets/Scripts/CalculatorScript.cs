using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    private float SGDUSD = 0.74f;
    private float SGDJPY = 82.78f;
    public Toggle toggleUSDollar;
    public Toggle toggleJPYen;
    public InputField inputConvertedAmount;
    public InputField inputAmount;
    public Text DebugText;

    public void Convert()
    {
        try
        {
            float amount = float.Parse(inputAmount.text);

            if (toggleUSDollar.isOn == true && toggleJPYen.isOn == false)
            {
                amount *= SGDUSD;
                inputConvertedAmount.text = "$ " + (amount);
            }
            else if (toggleJPYen.isOn == true && toggleUSDollar.isOn == false)
            {
                amount *= SGDJPY;
                inputConvertedAmount.text = "$ " + (amount);
            }
            else if (toggleJPYen.isOn == false && toggleUSDollar.isOn == false)
            {
                inputConvertedAmount.text = "$ " + (amount);
            }
            else
            {
                inputConvertedAmount.text = "Invalid";
            }
        }
        catch
        {
            DebugText.text = "Please enter a valid amount.";
        }

    }

    public void Clear()
    {
        inputAmount.text = "";
        toggleUSDollar.isOn = false;
        toggleJPYen.isOn = false;
        inputConvertedAmount.text = "";
    }

}

