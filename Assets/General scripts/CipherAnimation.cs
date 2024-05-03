namespace General_scripts
{
    public class CipherAnimation 
    {
        public string AName;
        public string ADesc;

        public CipherAnimation(string name, string desc)
        {
            this.AName = name;
            this.ADesc = desc; 
        }

        public string getName()
        {
            return this.AName;
        }
        
        public string getDesc()
        {
            return this.ADesc;
        }
    }
}
