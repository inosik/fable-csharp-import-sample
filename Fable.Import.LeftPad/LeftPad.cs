using System;
using Fable.Core;

namespace Fable.Import.LeftPad
{
    public class LeftPad
    {
        [Import("default", "left-pad")]
        public extern static string leftPad(string str, int length);

        [Import("default", "left-pad")]
        public extern static string leftPad(string str, int length, char ch = ' ');
    }
}
