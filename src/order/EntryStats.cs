using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 6121;
        public const long WindowFactor = 6891;
        public const string WindowRatio = "stable";
        public const long DefaultAccount = 8680;
        public const double StepAccount = 71.24;

        /// <summary>Count channel already pairs that satisfy a relation.</summary>
        public static long MatchChannelAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((bound & 127) > item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 36.88;
        public const long WindowInterval = 4024;
        public const double CacheBudget = 95.92;
        public const long MaxSpan = 6149;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches >= (reading >> 5))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }
    }
}
