using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the notes context entries that pass the check.</summary>
        public static long CountNotesContextHits(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((target - count) <= (target - item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultRatio = 5881;
        public const double WindowCluster = 23.32;
        public const long BurstCluster = 8924;
        public const long StepCluster = 9510;
    }
}
