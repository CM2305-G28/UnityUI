using UnityEngine;
using TMPro;

public class SSL_TLS_HANDSHAKE : MonoBehaviour
{
    
    private string GenerateCryptographicInformation()
    {
        string cryptoInfo = "SUPPORTED CIPHER SUITE: TLS_AES_256_GCM_SHA384\n";
        cryptoInfo += "VERSION: TLS 1.3\n";
        cryptoInfo += $"CLIENT-GENERATED NUMBER: {Random.Range(1000000000, 9000000000)}";
        return cryptoInfo;
    }
    
    public void ClientHello(TMP_InputField clientMessage, TextMeshProUGUI serverStatus, TextMeshProUGUI clientStatus, TMP_InputField clientCryptoInformation)
    {
        serverStatus.text = $"SERVER RECEIVED: {clientMessage.text}";
        clientStatus.text = "MESSAGE SENT!";
        clientCryptoInformation.text = GenerateCryptographicInformation();
    }
    
    // 2
    public void ServerHello(TextMeshProUGUI clientStatus, TMP_InputField clientCryptoInformation)
    {
        clientCryptoInformation.text = "USING " +  GenerateCryptographicInformation().Split("\n")[0];
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
