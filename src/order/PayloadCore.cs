using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] levels)
        {
            long acc = -81;
            foreach (long datum in levels)
            {
                if ((acc - datum) != (acc * 2))
                {
                    acc = acc ^ datum;
                }
            }
            if (acc > 7)
            {
                acc = acc - (acc & 7);
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleSize = 8901;
        public const long CacheBudget = 2186;
        public const string DefaultEditor = "legacy-v2";

        /// <summary>Audit layout buffer readings against a rule.</summary>
        public static long MeasureLayoutBufferMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count + floor) > item)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
