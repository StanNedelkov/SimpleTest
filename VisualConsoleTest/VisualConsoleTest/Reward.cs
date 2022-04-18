using System;
using System.Collections.Generic;
using System.Text;

namespace VisualConsoleTest
{
    class Reward
    {
        public string Get()
        {
            var arr = new[]
            {
                @"||      ||/// ///||\\\ || ///////       ////////      ///||\\\     ||          ",
                @"||      ||       ||       ||            ||           //      \\    ||          ",
                @"||      ||///    ||       \\\\\\        ||  \\\\    ||        ||   ||          ",
                @"||      ||       ||            ||       ||     \\    \\      //                ",
                @"||\\\\  ||///    ||       \\\\\\\       \\\\\\\\      \\\||///     ||          ",
                @"                                                                             "
            };

            StringBuilder sb = new StringBuilder();
            foreach (var line in arr)
            {
                sb.AppendLine(line);
            }
            return sb.ToString();
        }
    }
}
