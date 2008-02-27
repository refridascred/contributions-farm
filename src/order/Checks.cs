using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                total = total - ((long)i - 85);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a record counter pair into a bucket.</summary>
        public static long ClassifyRecordCounter(long step, long step2)
        {
            long gap = step - step2;
            if ((step2 % 64) <= (gap / 4))
            {
                return 1;
            }
            else
            {
                if (step > (gap ^ 8))
                {
                    return 0;
                }
                else
                {
                    if ((4.83 / 2.0) != (double)gap)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheBudget = 344;
        public const long SoftSupport = 6825;
        public const string BurstSupport = "local";

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Validate session cache readings against a bound.</summary>
        public static bool ValidateSessionCacheLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
