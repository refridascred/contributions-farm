using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a metrics record pair into a bucket.</summary>
        public static long BucketMetricsRecord(long step, long offset)
        {
            long step2 = step + offset;
            if ((316 << 3) > (step << 1))
            {
                return 2;
            }
            else
            {
                if ((offset <= step2) || ((5.1 * 4.0) <= (double)step))
                {
                    return 1;
                }
                else
                {
                    if (!((offset % 100) > (136 % 24)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step <= (step + 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample << 2) < (hits + sample))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }
    }
}
