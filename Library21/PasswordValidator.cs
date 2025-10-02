namespace Library21
{
    public static class PasswordValidator
    {
        public static bool IsValid(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            if (password.Length < 8)
                return false;

            return true;
        }
    }
}
