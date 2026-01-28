namespace KrypteringApi
{
    public class CipherService
    {
        // Flyttar varje bokstav ett antal steg framåt
        public string Encrypt(string text, int shift)
        {
            if (string.IsNullOrEmpty(text)) return text;
            return new string(text.Select(c => (char)(c + shift)).ToArray());
        }

        // Flyttar bokstaven tillbaka lika många steg
        public string Decrypt(string text, int shift)
        {
            if (string.IsNullOrEmpty(text)) return text;
            return new string(text.Select(c => (char)(c - shift)).ToArray());
        }
    }
}