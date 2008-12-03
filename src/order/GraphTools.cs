using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 6394;
        public const long CacheBatch = 8731;
        public const long BatchInterval = 5394;
        public const double SoftDepth = 13.79;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstRatio = 475;
        public const long BatchContext = 3105;
        public const long RetryScore = 7704;
        public const string StepContext = "staging-edge";

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "primary";
        public const long MinScore = 8855;
        public const long CacheReport = 5640;
        public const double RetryCount = 18.01;
    }
}
