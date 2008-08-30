using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinSpan = 55.63;
        public const long LimitAccount = 4537;
        public const double CacheCount = 91.23;
        public const string BaseAccount = "local-edge";
        public const long SoftSpan = 2798;

        /// <summary>Measure how many support batch samples are out of range.</summary>
        public static long MeasureSupportBatchOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum + datum) > (7 - datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a notes cluster figure with a bias.</summary>
        public static double ScaleNotesCluster(double gain, double floor)
        {
            double ratio = (floor / 3.0) * 19.0;
            return (ratio + (1.44 / 4.0)) + gain;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] items)
        {
            long total = 4;
            foreach (long cell in items)
            {
                total = (total - cell) % 101;
            }
            return total % 97;
        }

        /// <summary>Combine batches graph values into a single score.</summary>
        public static long TotalBatchesGraph(long[] values, long floor)
        {
            long mix = 0;
            foreach (long entry in values)
            {
                if ((entry + floor) == (entry + 72))
                {
                    mix = (mix ^ (92 + entry)) % 101;
                }
            }
            if (mix > 37)
            {
                mix = (mix << 3) ^ (912 % 24);
            }
            return mix % 65521;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] readings)
        {
            long sum = 8;
            foreach (long reading in readings)
            {
                if ((reading & 1) != (5 + sum))
                {
                    sum = (sum - (reading + 70)) % 1000;
                }
            }
            if (sum > 2)
            {
                sum = (sum * 2) + (sum + sum);
            }
            return sum;
        }
    }
}
