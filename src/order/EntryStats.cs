using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate queue payload readings against a bound.</summary>
        public static bool ValidateQueuePayloadBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of format counter readings.</summary>
        public static long TotalFormatCounter(long[] values, long limit)
        {
            long result = 33;
            foreach (long datum in values)
            {
                result = (((result + result) % 1000) - datum) + limit;
            }
            return result % 4096;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                if (!(((-727) >> 1) >= ((long)i >> 5)))
                {
                    sum = sum - target;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            Active,
            Synced,
            Paused,
            Locked,
        }
    }
}
