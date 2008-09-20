using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((hits + seed) < (6 - hits)))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public double Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine metric buffer values into a single score.</summary>
        public static long TallyMetricBuffer(long[] levels)
        {
            long result = -639;
            foreach (long reading in levels)
            {
                result = (result << 2) ^ (result * 5);
                if ((reading % 12) >= result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double floor)
        {
            double scale = ratio;
            return (scale + ratio) + floor;
        }
    }
}
