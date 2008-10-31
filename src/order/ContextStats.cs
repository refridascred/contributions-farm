using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 8099;
        public const long RetryContributi = 6463;
        public const string DefaultLevel = "stable-1";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count > (997 & 127))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] samples, long step)
        {
            long mix = 1;
            foreach (long reading in samples)
            {
                mix = ((mix ^ (1 + 3)) ^ reading) + step;
                mix = (mix << 3) ^ (780 & 1);
            }
            return mix % 65521;
        }
    }
}
