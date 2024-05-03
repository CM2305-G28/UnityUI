using TMPro;
using UI.Login;
using UnityEngine;
using UnityEngine.UI;

namespace View.Account
{
    public class LoginMenuConfig : MonoBehaviour
    {
        public Image logo;
        public Button loginButton;
        public TMP_Text welcomeText;
        public LoginFormHandler loginForm;

        private void Start()
        {
            ResetMenuState();
        }

        private void ResetMenuState()
        {
            logo.gameObject.SetActive(true);
            loginButton.gameObject.SetActive(true);
            welcomeText.gameObject.SetActive(true);
            loginForm.gameObject.SetActive(false);
            loginForm.ResetMenuState();
        }
    }
}