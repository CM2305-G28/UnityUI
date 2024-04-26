using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using TMPro;

public class HMAC : MonoBehaviour
{
    public TMP_InputField senderMessage; // THIS IS THE TOP LEFT TEXT FIELD THAT IS USED AS INPUT (string plaintext = inputMessage1.text;)
    public TMP_InputField receiverMessage;
    public TMP_InputField middleMessage;
    public TMP_InputField middleMac;
    public TMP_InputField senderKey;
    public TMP_InputField receiverKey;
    public TMP_Dropdown block_size;
    public Toggle gen_new_key;
    public TMP_InputField senderOutput; // THIS IS THE OUTPUT TEXT FIELD (encryptedText.text = macHexString;)

    private string GetMacHexString(){
        string macHexString = null;

        switch (block_size.value){
            case 0:
                using (HMACSHA1 hmac = new HMACSHA1(byte_key))
                {
                    // Compute the MAC for the message
                    byte[] macBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(plaintext));
        
                    // Convert the MAC bytes to a hexadecimal string
                    macHexString = BitConverter.ToString(macBytes).Replace("-", "").ToLower();
                }
                break;
            case 1:
                using (HMACSHA256 hmac = new HMACSHA256(byte_key))
                {
                    // Compute the MAC for the message
                    byte[] macBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(plaintext));

                    // Convert the MAC bytes to a hexadecimal string
                    macHexString = BitConverter.ToString(macBytes).Replace("-", "").ToLower();
                }
                break;
            case 2:
                using (HMACSHA512 hmac = new HMACSHA512(byte_key))
                {
                    // Compute the MAC for the message
                    byte[] macBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(plaintext));
        
                    // Convert the MAC bytes to a hexadecimal string
                    macHexString = BitConverter.ToString(macBytes).Replace("-", "").ToLower();
                }
                break;
    }
    return macHexString;

    public void GetHash()
    {
        string plaintext = senderMessage.text;

        byte[] byte_key;

        if (block_size.value==0){
            // Create a byte array to hold the random key
            byte_key = new byte[20]; // SHA1
        }
        else if (block_size.value==1){
            byte_key = new byte[32]; // SHA256
        }
        else{
            byte_key = new byte[64]; // SHA512
        }

        if (gen_new_key.isOn){
            // Generate random bytes to fill the array
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(byte_key);
            }
            Debug.Log("different");
            // Display generated key
            senderKey.text=Convert.ToBase64String(byte_key);
        }
        else{
            byte_key = Encoding.UTF8.GetBytes(key.text);
            Debug.Log("same");
        }

        macHexString = GetMacHexString()

        senderOutput.text = macHexString;
        receiverMessage.text = plaintext;
        middleMessage.text = plaintext;
        middleMac.text = macHexString;
        receiverKey.text = senderKey.text;
    }

    public TMP_InputField OGMac;
    public TMP_InputField validationCheckMessage;
    public TMP_InputField generatedMac;
    public Toggle changeMessage;

    public void SendMessage(){
        
        if (changeMessage.isOn){
            validationCheckMessage.text = "MAC does not match!"
            receiverMessage.text = middleMessage.text + "[ALTERED]";
            generatedMac.text = GetMacHexString();
        }

        else{
            validationCheckMessage.text = "MAC is valid."
            receiverMessage.text = middleMessage.text;
            generatedMac.text = middleMac.text;
        }

        OGMac.text = middleMac.text;
    }
}