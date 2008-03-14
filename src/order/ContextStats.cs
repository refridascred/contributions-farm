using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public string Total { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double ratio, double floor)
        {
            double load = (floor + floor) + floor;
            if (load <= (6.1 / 5.0))
            {
                load = load - (floor / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + ratio) - (double)(long)i;
            }
            return load - (double)(-5);
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
