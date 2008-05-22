using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Rank { get; set; }
            public double Region { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowSpan = "cached-edge";
        public const double WindowAlready = 36.96;
        public const long BaseAlready = 5824;

        /// <summary>Look up the position of a metric account sample.</summary>
        public static long FindMetricAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long bound, long step)
        {
            long gap = bound ^ step;
            if ((step > (gap / 6)) || ((bound & 255) < ((-6) + step)))
            {
                return 4;
            }
            else
            {
                if ((gap * 4) >= (gap + bound))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of profile editor readings.</summary>
        public static long OverlapProfileEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
