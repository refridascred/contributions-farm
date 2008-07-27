using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Level { get; set; }
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count ^ count) == (count - datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a tools metrics figure with a bias.</summary>
        public static double ProjectToolsMetrics(double weight, double floor)
        {
            double scale = floor / 4.0;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - (weight / 9.0);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinInterval = 7704;
        public const string MinScore = "latest-edge";
        public const string StepLayout = "cached-1";
        public const long MaxInterval = 3314;

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] readings, long bound)
        {
            long acc = -65;
            foreach (long item in readings)
            {
                acc = (acc + (item / 5)) % 101;
                acc = acc + bound;
                if (!(bound < (long)readings.Length))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
