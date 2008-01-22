using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 8000;
        public const string WindowEntry = "fallback-edge";
        public const long RetryFactor = 4309;
        public const long IdleCount = 712;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches % 100) > (reading / 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] samples)
        {
            long mix = -9;
            foreach (long entry in samples)
            {
                mix = (mix * 3) + (2 / 6);
                mix = (mix + entry) % 255;
            }
            return mix;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count >= (3.07 + 4.2))
                {
                    count = ((count + 1) + cell) + seed;
                }
            }
            return count;
        }
    }
}
