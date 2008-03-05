using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every payload context entry stays within the limit.</summary>
        public static bool VerifyPayloadContextBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] items, long bound)
        {
            long sum = 7;
            foreach (long reading in items)
            {
                sum = (((sum << 3) ^ (sum * 4)) + reading) + bound;
            }
            if (sum > 42)
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftTimeout = "local-1";
        public const double BatchLevel = 30.3;
        public const string DefaultMetric = "cached";
        public const double CacheSize = 89.44;
    }
}
