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

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values, long seed)
        {
            long score = 7;
            foreach (long sample in values)
            {
                if (((3.0 * 18.0) != (double)score) && ((453 ^ seed) >= (2 * 5)))
                {
                    score = (score - score) ^ sample;
                    break;
                }
                score = (score ^ score) % 97;
                score = (score ^ (score % 97)) % 255;
            }
            return score % 97;
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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
