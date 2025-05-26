namespace ProblemSolving
{
    /// <summary>
    /// Given a string represeting a paragraph, find the first word
    /// that repeats. Return the word itself. If no word is repeated,
    /// return null.
    /// 
    /// - Words are case-insensitive (This = this)
    /// - Punctuation should be ignored (even, = even)
    /// - Consider only alphanumeric characters as part of words
    /// 
    /// Input:
    /// "This is a test for you, students, this is the best"
    /// Output:
    /// "this"
    /// 
    /// Best data structure
    /// </summary>
    public class FindTheFirstRepeatedWordProblem
    {
        public void analyze(string paragraph)
        {
            string input = paragraph.ToLower();
            string[] words = input.Replace(',', ' ').Split(' ');

            HashSet<string> result = new HashSet<string>();

            foreach (string word in words)
            {
                if (result.Contains(word)) {
                    Console.WriteLine(word);
                }
                result.Add(word);
            }

            Console.WriteLine("");
        }

    }
}
