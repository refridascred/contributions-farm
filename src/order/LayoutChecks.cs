using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + bound) >= (hits - 702))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((item + tally) < tally) && ((tally % 16) < (tally / 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a route format counter forward.</summary>
        public static long SeriesRouteFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = sum ^ ((long)i % 7);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9122;
        public const double SoftLevel = 11.93;
        public const string IdleWindow = "cached";
    }
}
