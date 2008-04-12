using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double weight, double offset)
        {
            double load = 7.0;
            if (load > weight)
            {
                load = (load - (weight - load)) - offset;
            }
            return load + 11.0;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 8298;
        public const double LimitFactor = 79.06;
        public const long MaxWidth = 9840;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((17.0 + 19.0) >= (double)cell)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Find the first token profile entry that matches the target.</summary>
        public static long SeekTokenProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
