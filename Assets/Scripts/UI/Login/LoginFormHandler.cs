using System;
using General_scripts;
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
    
        public TMP_InputField username;
        public TMP_InputField password;

        public TMP_Text negativeFeedbackField;
        public LoadManager successTransition;

        private void Start()
        {
            ResetMenuState();
        }
        
        

        public void Login() 
        {
            negativeFeedbackField.text = "";
            Debug.Log("Connecting to server...");
            
            if (!TryGetClient(out Client client))
            {
                negativeFeedbackField.text = "Unable to reach the server. Check your connection & try again later.";
                return;
            }
            
            Debug.Log("Connected, logging in...");

            if (!client.Login(username.text, password.text))
            {
                password.text = "";
                negativeFeedbackField.text = "Incorrect Username / Password";
                return;
            }
            
            Debug.Log("Logged in successfully!");
            
            successTransition.changeScene();
        }
        
        
        public void Register() 
        {
            negativeFeedbackField.text = "";
            Debug.Log("Connecting to server...");
            
            if (!TryGetClient(out Client client))
            {
                negativeFeedbackField.text = "Unable to reach the server. Check your connection & try again later.";
                return;
            }
            
            Debug.Log("Connected, registering account...");

            if (!client.CreateAccount(username.text, password.text))
            {
                negativeFeedbackField.text = "Username is taken, please try a different name";
                username.text = "";
                password.text = "";
                return;
            }
            
            Debug.Log("Registered & Logged in successfully!");
                
            successTransition.changeScene();
        }
        
        public void LoginAsGuest() 
        {
            negativeFeedbackField.text = "";
            Debug.Log("Skipping server - using Offline Guest mode");
            Debug.Log("Registered & Logged in successfully!");
            successTransition.changeScene();
        }

        private bool TryGetClient(out Client client)
        {
            try
            {
                client = new Client();
                return true;
            }
            catch (Exception err)
            {
                Debug.LogException(err);
            }

            client = null;
            return false;
        }

        public void ResetMenuState()
        {
            negativeFeedbackField.text = "";
            username.text = "";
            password.text = "";
        }
    }
}