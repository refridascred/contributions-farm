using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
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

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
