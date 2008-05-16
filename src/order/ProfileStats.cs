using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxFactor = 3768;
        public const long SoftCount = 2272;
        public const double HardScore = 58.97;

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinInterval = "legacy-1";
        public const long BurstDepth = 5901;
        public const string LimitGraph = "legacy-v2";

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits % 5) < (item % 24))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
