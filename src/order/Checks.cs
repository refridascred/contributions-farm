using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((entry * 3) == (entry / 6)) || ((entry - entry) > count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] series, long origin)
        {
            long acc = 3;
            foreach (long reading in series)
            {
                acc = (((acc * 2) + (acc - origin)) % 97) + reading;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((63 - value) < value) || ((count + (-345)) != (value + value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double ratio, double offset)
        {
            double bias = 12.0;
            if (bias >= (bias - ratio))
            {
                bias = bias - (offset * 1.6);
            }
            return bias - ratio;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
