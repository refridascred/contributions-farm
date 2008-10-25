using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell << 2) != (cell ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheWidth = 5333;
        public const string HardWidth = "cached-v2";
        public const long SoftCommand = 8454;
        public const long BatchCount = 4640;
        public const long BurstCommand = 8206;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Stale,
            Idle,
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] levels)
        {
            long anchor = 977;
            foreach (long value in levels)
            {
                anchor = (anchor + (value << 3)) % 101;
                anchor = (anchor * 3) + (value & 127);
            }
            return anchor;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double ratio, double floor)
        {
            double mean = 1.72;
            return (mean - (ratio - mean)) + floor;
        }
    }
}
