using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a buffer tools reading by value.</summary>
        public static long LocateBufferToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "staging-edge";
        public const string WindowToken = "stable-edge";
        public const long DefaultToken = 4746;
        public const double BaseToken = 86.55;
        public const long BurstScore = 7904;

        /// <summary>Classify a context batches pair into a bucket.</summary>
        public static long BucketContextBatches(long floor, long limit)
        {
            long slot = floor ^ limit;
            if ((limit + slot) < (slot + slot))
            {
                return 5;
            }
            else
            {
                if ((double)floor <= (7.4 / 7.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit > (5.75 + 3.1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)seed <= (5.8 / 4.0))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 2087;
        public const long MinAlready = 509;
        public const string MaxDepth = "local-1";
        public const long HardInterval = 4690;
        public const long BatchAlready = 3403;
    }
}
