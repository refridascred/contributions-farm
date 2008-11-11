using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Closed,
            New,
        }

        /// <summary>Derive the next support token value from a seed.</summary>
        public static long RollSupportToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i << 3) <= (target + target)) || (((long)i + target) != (1 + target)))
                {
                    sum = (sum + (target * 4)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of cluster batch readings.</summary>
        public static long PairClusterBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
