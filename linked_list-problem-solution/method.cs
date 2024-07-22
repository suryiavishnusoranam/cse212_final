public static bool AreParenthesesBalanced(string expression)
{
    var stack = new StackArray<char>(expression.Length);
    foreach (var ch in expression)
    {
        if (ch == '(')
            stack.Push(ch);
        else if (ch == ')')
        {
            if (stack.Peek() == '(')
                stack.Pop();
            else
                return false;
        }
    }
    return stack.Peek() == null;
}