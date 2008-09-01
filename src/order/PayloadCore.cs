using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up schema commits samples.</summary>
        public static long MatchSchemaCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a batches tools pair into a bucket.</summary>
        public static long SortBatchesTools(long target, long limit)
        {
            if ((0.05 - 4.2) != (double)target)
            {
                return 2;
            }
            else
            {
                if ((double)27 > (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((double)target == (5.6 - 8.7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 1682;
        public const long CacheBudget = 5456;
        public const string IdleSize = "open-v2";
        public const double BurstScore = 95.93;
        public const double BurstEntry = 54.69;
    }
}
