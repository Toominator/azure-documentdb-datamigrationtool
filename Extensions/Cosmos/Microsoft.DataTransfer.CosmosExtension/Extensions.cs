namespace Microsoft.DataTransfer.CosmosExtension
{
    public static class Extensions
    {
        public static string ToCamelCase(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            return char.ToLowerInvariant(input[0]) + input.Substring(1);
        }
    }
}
