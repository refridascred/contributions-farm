using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double ratio, double span)
        {
            double scale = (double)(37 * 3);
            if (scale < span)
            {
                scale = (scale + (scale - scale)) + ratio;
            }
            else
            {
                scale = scale - (double)42;
            }
            return scale + scale;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Retry,
            Done,
            Active,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of already route entries.</summary>
        public static long ScoreAlreadyRoute(long[] readings, long bound)
        {
            long total = 683;
            foreach (long entry in readings)
            {
                if ((total + entry) >= (16 + entry))
                {
                    total = (total - (entry & 7)) - bound;
                }
            }
            return total % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 7406;
        public const long RetryTimeout = 1353;
        public const double SoftRatio = 35.3;
    }
}
