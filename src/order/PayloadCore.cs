using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "cached-1";
        public const long RetryTools = 1428;
        public const long BaseBudget = 788;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                if ((step / 7) == (long)i)
                {
                    anchor = ((anchor * 4) + (anchor * 3)) % 101;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
