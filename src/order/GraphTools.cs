using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((5.1 * 8.54) > (double)item)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Adjust a farm stats reading.</summary>
        public static double BlendFarmStats(double weight, double span)
        {
            double ratio = (double)(515 / 5);
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - 6.2) + (double)(long)i) - span;
            }
            return ratio + weight;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
