using message_prototype_pattern_example;

internal class Program
{
    private static void Main(string[] args)
    {
        Message message = new Message("This is a normal message!", "White");
        Message messageClone = message.Clone();
        messageClone.Log();

        Error error = new Error("File not found.", 404);
        Error errorClone = error.Clone();
        errorClone.Log();

        Warning warning = new Warning("Ignore this warning.", "Low");
        Warning warningClone = warning.Clone();
        warningClone.Log();
    }
}