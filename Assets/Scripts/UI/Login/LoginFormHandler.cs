using SecureAnim;
using SecureAnimClient;
using TMPro;
using UnityEngine;
using Util;

namespace UI.Login
{
    public class LoginFormHandler : MonoBehaviour
    {
        
        static LoginFormHandler() {
            BackendSupport.InitLogging();
        }
        
        public LoginType lastSelectedState = LoginType.STUDENT;
    
        public TMP_InputField username;
        public TMP_InputField password;

        public void Login() {
            Debug.Log("Connecting to server...");

            ProtocolHelp.LogInfo("ProtocolHelp Logger is working");
            
            Client client = new Client();
            Debug.Log("Connected, logging in...");
        
            if (client.Login(username.text, password.text))
                Debug.Log("Logged in successfully!");
            else Debug.Log("unable to login...");
        }
    }
}