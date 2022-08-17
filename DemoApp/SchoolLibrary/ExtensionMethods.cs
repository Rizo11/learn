namespace SchoolLibrary
{
    public static class ExtensionMethods
    {
        public static int WordCount(this string Text)
        {
            return Text.Split(new char[] { ' ', '.', '?', '!', '-', '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
