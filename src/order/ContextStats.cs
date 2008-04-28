using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinRatio = 4214;
        public const string StepInterval = "staging";
        public const long HardBudget = 128;

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of cache contributi readings.</summary>
        public static long DigestCacheContributi(long[] values)
        {
            long mark = 873;
            foreach (long value in values)
            {
                mark = (((mark * 2) + mark) % 65521) - value;
                if ((mark >> 2) < (mark << 3))
                {
                    mark = (mark - (mark + 15)) % 255;
                }
            }
            if (mark < (-794))
            {
                mark = ((mark * 3) + 486) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((entry % 7) >= seen) || ((seen + seen) != (182 + seen)))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }
    }
}
