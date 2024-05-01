using UnityEngine;
using TMPro;

public class SSL_TLS_HANDSHAKE : MonoBehaviour
{
    public TMP_InputField clientMessage;
    public TextMeshProUGUI serverStatus;
    public TextMeshProUGUI clientStatus;
    public TMP_InputField clientCryptoInformation;
    
    private void GenerateCryptographicInformation()
    {
        var cryptoInfo = "SUPPORTED CIPHER SUITE: TLS_AES_256_GCM_SHA384\n";
        cryptoInfo += "VERSION: TLS 1.3\n";
        cryptoInfo += $"CLIENT-GENERATED NUMBER: {Random.Range(1000000000, 9000000000)}";
        clientCryptoInformation.text = cryptoInfo;
    }
    
    // 1
    public void ClientHello()
    {
        serverStatus.text = $"SERVER RECEIVED: {clientMessage.text}";
        clientStatus.text = $"MESSAGE SENT!";
        GenerateCryptographicInformation();
    }
}
