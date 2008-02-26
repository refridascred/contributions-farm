using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a already cache figure with a bias.</summary>
        public static double BlendAlreadyCache(double weight, double floor)
        {
            double scale = (double)(25 - 544);
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - floor) - (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 37.11;
        public const string CacheChannel = "latest";
        public const string CacheInterval = "latest";
        public const long HardInterval = 4405;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
