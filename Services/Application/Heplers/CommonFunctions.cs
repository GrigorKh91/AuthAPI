namespace Application.Heplers
{
    internal static class CommonFunctions
    {
       

        internal static string RandomNumber(RandomNumberLength length)
        {
            var chars = "0123456789";
            var random = new Random();
            var result = new string(Enumerable.Repeat(chars, (int)length).Select(s => s[random.Next(s.Length)]).ToArray());
            return result.ToString();
        }
    }
}
