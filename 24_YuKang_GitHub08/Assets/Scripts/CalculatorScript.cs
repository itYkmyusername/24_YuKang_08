using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    private float SGDUSD = 0.74f;
    private float SGDJPY = 82.78f;
    private float SGDRM = 3.08f;
    private float SGDEUR = 0.63f;
    private float SGDKRW = 881.54f;
    private float SGDTWD = 20.73f;
    public Toggle toggleUSDollar;
    public Toggle toggleJPYen;
    public Toggle toggleMalaysianRM;
    public Toggle toggleEuropeanEUR;
    public Toggle toggleKoreanKRW;
    public Toggle toggleTaiwanTWD;
    public InputField inputConvertedAmount;
    public InputField inputAmount;
    public Text DebugText;

    public void Convert()
    {
        try
        {
            float amount = float.Parse(inputAmount.text);

            if (toggleUSDollar.isOn == true && toggleJPYen.isOn == false && toggleMalaysianRM.isOn == false && toggleEuropeanEUR.isOn == false && toggleKoreanKRW.isOn == false && toggleTaiwanTWD.isOn == false)
            {
                amount *= SGDUSD;
                inputConvertedAmount.text = "$ " + (amount);
            }
            else if (toggleJPYen.isOn == true && toggleUSDollar.isOn == false && toggleMalaysianRM.isOn == false && toggleEuropeanEUR.isOn == false && toggleKoreanKRW.isOn == false && toggleTaiwanTWD.isOn == false)
            {
                amount *= SGDJPY;
                inputConvertedAmount.text = "$ " + (amount);
            }
            else if (toggleMalaysianRM.isOn == true && toggleJPYen.isOn == false && toggleUSDollar.isOn == false && toggleEuropeanEUR.isOn == false && toggleKoreanKRW.isOn == false && toggleTaiwanTWD.isOn == false)
            {
                amount *= SGDRM;
                inputConvertedAmount.text = "$ " + (amount);
            }
            else if (toggleEuropeanEUR.isOn == true && toggleJPYen.isOn == false && toggleUSDollar.isOn == false && toggleMalaysianRM.isOn == false && toggleKoreanKRW.isOn == false && toggleTaiwanTWD.isOn == false)
            {
                amount *= SGDEUR;
                inputConvertedAmount.text = "$ " + (amount);
            }
            else if(toggleKoreanKRW.isOn == true && toggleJPYen.isOn == false && toggleUSDollar.isOn == false && toggleMalaysianRM.isOn == false && toggleEuropeanEUR.isOn == false && toggleTaiwanTWD.isOn == false)
            {
                amount *= SGDKRW;
                inputConvertedAmount.text = "$ " + (amount);
            }
            else if(toggleTaiwanTWD.isOn == true && toggleJPYen.isOn == false && toggleUSDollar.isOn == false && toggleMalaysianRM.isOn == false && toggleEuropeanEUR.isOn == false && toggleKoreanKRW.isOn == false)
            {
                amount *= SGDTWD;
                inputConvertedAmount.text = "$ " + (amount);
            }
            else if (toggleJPYen.isOn == false && toggleUSDollar.isOn == false && toggleMalaysianRM.isOn == false && toggleEuropeanEUR.isOn == false && toggleKoreanKRW.isOn == false && toggleTaiwanTWD.isOn == false)
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
        toggleMalaysianRM.isOn = false;
        toggleEuropeanEUR.isOn = false;
        toggleKoreanKRW.isOn = false;
        toggleTaiwanTWD.isOn = false;
        inputConvertedAmount.text = "";
    }

}

