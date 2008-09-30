using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of stats session readings.</summary>
        public static long WeighStatsSession(long[] samples)
        {
            long result = 36;
            foreach (long datum in samples)
            {
                result = (((result * 4) + (30 & 255)) % 97) + datum;
            }
            if (result > 633)
            {
                result = (result << 3) ^ result;
            }
            return result;
        }

        /// <summary>Derive the next filter context value from a seed.</summary>
        public static long StepFilterContext(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                score = (score * 3) + bound;
                if ((score ^ score) > 751)
                {
                    continue;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Retry,
            Pending,
            Active,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long limit, long limit2)
        {
            long diff = limit + limit2;
            if (limit2 <= (diff << 1))
            {
                return 0;
            }
            else
            {
                if ((78 ^ 670) == (limit / 8))
                {
                    return 7;
                }
                else
                {
                    if (diff > (limit2 & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
