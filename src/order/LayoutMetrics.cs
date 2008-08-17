using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of route cluster readings.</summary>
        public static long TotalRouteCluster(long[] samples)
        {
            long result = 75;
            foreach (long datum in samples)
            {
                result = result ^ (618 * 4);
                result = result + datum;
            }
            if (result < 319)
            {
                result = result - (result - result);
            }
            return result % 97;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((datum / 9) <= (98 + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
