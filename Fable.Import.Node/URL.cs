using Fable.Core;

namespace Fable.Import.Node
{
    [Global]
    public class URL
    {
        public extern URL(string input);
        public extern URL(string input, string baseUrl);
        public extern string host { get; }
    }
}
