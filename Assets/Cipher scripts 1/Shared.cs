using TMPro;

public class Shared
{
    public static void GetKeySize(TMP_Dropdown block_size, int[] values, out byte[] byte_key)
    {
        if (block_size.value==0){
            // Create a byte array to hold the random key
            byte_key = new byte[16]; 
        }
        else if (block_size.value==1){
            byte_key = new byte[24];
        }
        else{
            byte_key = new byte[32];
        }
    }
}