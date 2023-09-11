
namespace DataStructuresandAlgorithms.Hashtable
{
    public class Hashtable
    {
        private string[] _hashTable { get; set; }
       
        public Hashtable()
        {
                _hashTable=new string[10];
        }
        private int _hash(string key)
        {
            return key.Length % _hashTable.Length;
        }


        public string Get(string key)
        {
            int hashedKey=_hash(key);
            return _hashTable[hashedKey];
        }

        public void Set(string key, string value)
        {
            int hashedKey = _hash(key);
            if (_hashTable[hashedKey] != null)
            {
                Console.WriteLine("Sorry, Hash collision has occurred.");
            }
            else
            {
                _hashTable[hashedKey] = value;
            }
        }
    }
}
