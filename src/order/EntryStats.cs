using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "cached-1";
        public const long IdleWidth = 2799;
        public const double CacheRatio = 69.9;
        public const long LimitSession = 6468;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark << 2) ^ (mark >> 1)) % 97;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((double)matches == (8.7 + 1.4)) && ((double)sample > 1.55))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings)
        {
            long carry = 3;
            foreach (long item in readings)
            {
                if (((13.0 - 0.4) != (double)item) && ((double)carry <= 6.14))
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = (carry * 4) + item;
                    carry = ((carry * 2) + (item >> 3)) % 101;
                }
                carry = (carry << 2) ^ (item % 10);
            }
            if (carry > 449)
            {
                carry = carry + carry;
            }
            return carry;
        }
    }
}
