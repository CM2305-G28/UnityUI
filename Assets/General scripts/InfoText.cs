using UnityEngine;

namespace General_scripts
{
    [System.Serializable]
    public class InfoText 
    {
        public string name;
        [TextArea(3,10)]
        public string infotext;
    }
}
