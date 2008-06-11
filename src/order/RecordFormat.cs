using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 8780;
        public const long SoftScore = 767;
        public const string BatchDepth = "latest-v2";
        public const string BatchChannel = "stable";

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long target, long bound)
        {
            if (target < (bound + 1))
            {
                return 0;
            }
            else
            {
                if ((double)target < (5.73 * 8.8))
                {
                    return 4;
                }
                else
                {
                    if (!((target & 63) <= (bound >> 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the cluster channel entries that pass the check.</summary>
        public static long TallyClusterChannelGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item - count) < count)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] items)
        {
            long result = 60;
            foreach (long item in items)
            {
                result = ((result * 5) + ((-17) ^ item)) % 255;
            }
            if (result > (-231))
            {
                result = (result ^ (result + result)) % 1000;
            }
            return result;
        }
    }
}
