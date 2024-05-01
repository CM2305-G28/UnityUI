using UnityEngine;
using TMPro;

public class SSL_slide_2  : MonoBehaviour
{
    public TMP_InputField clientCryptoInformation;
    public TextMeshProUGUI clientStatus;
    // 2
    public void ServerHello()
    {
        clientCryptoInformation.text = "USING " +  GenerateCryptoInfo.GenerateCryptographicInformation().Split("\n")[0];
        clientStatus.text = "Verifying.";
        Invoke("Wait", 1f); // 1 second wait
        clientStatus.text = "Verifying..";
        Invoke("Wait", 1f);
        clientStatus.text = "Verifying...";
        Invoke("Wait", 1f);
        clientStatus.text = "Verified!";
        Invoke("Wait", 1f);
    }

    private void Wait()
    {
        Debug.Log("waiting...");
    }
}