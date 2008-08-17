using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 7103;
        public const double LimitReport = 23.07;
        public const double MinBudget = 98.81;
        public const long BaseReport = 1720;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((43 % 5) > (item << 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
