using UnityEngine;
using TMPro;
using SecureAnimClient;

public class LoginHandler : MonoBehaviour
{
    public TMP_InputField username;
    public TMP_InputField password;

    public void Login(){
        Debug.Log("Connecting to server...");
        Client client = new Client();
        Debug.Log("Connected, logging in...");
        
        if (client.Login(username.text, password.text))
            Debug.Log("Logged in successfully!");
        else Debug.Log("unable to login...");
        
    }
}