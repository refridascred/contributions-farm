using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample < (limit >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public double Level { get; set; }
        }
    }
}
