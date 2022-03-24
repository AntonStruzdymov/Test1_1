namespace T1Library
{
    public class MyString
    {
        public string _string { get; set; }
        private string output = "";
        public MyString()
        {

        }
        public MyString(string value)
        {
            _string = value;
        }
        public string Reverse (string value)
        {
            for (int i = value.Length - 1; i >= 0; i--)
            {
                output += value[i];
            }
            return output;

        }
    }
}