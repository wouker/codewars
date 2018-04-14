namespace TheCode
{
    public class MissingLetterFinder
    {
        public static char Find(char[] array)
        {
            var expectedCounter = (int)array[0];
            var realityCounter = 1;
            while (++expectedCounter == array[realityCounter++]) { }
            return (char)expectedCounter;
        }
    }
}
