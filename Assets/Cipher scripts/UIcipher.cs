using UnityEngine;
using TMPro;
using System;


public class UIcipher : MonoBehaviour
{

    public TMP_InputField shift;
    public TMP_InputField cleartext;
    public TextMeshProUGUI cleartextoutput;
    public TextMeshProUGUI shiftoutput;
    public TextMeshProUGUI ciphertextoutput;


    public void run_cipher()
    {
        cleartextoutput.text = cleartext.text;
        shiftoutput.text = "";
        ciphertextoutput.text = "";

        char[] characters = new char[cleartext.text.Length];

        for (int i = 0; i < characters.Length; i++){ 
                characters[i] = cleartext.text[i];
        }
        
        int key = Int32.Parse(shift.text);
        string sign;
        if (key < 0)
        {
            sign= "-";
        }
        else
        {
            sign = "+";
        }
        int temp = 0;

        for (int j = 0; j <  characters.Length; j++) {
            shiftoutput.text = shiftoutput.text + sign + shift.text;
            temp = cleartext.text[j] + key;
            if (temp >  'z') {
                temp -= 26;
            }
            else if (temp < 'a') {
                temp += 26;
            }
            characters[j] = (char)temp;
            ciphertextoutput.text += characters[j];
            
        }

    }


}
