namespace KeyValueStore
{
    public class KeyValueRecord
    {
        public string Key { get; set; }
        public string Data { get; set; }

        public KeyValueRecord(string key, string data)
        {
            Key = key;
            Data = data;
        }
    }

}
