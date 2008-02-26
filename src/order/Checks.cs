using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double bias, double floor)
        {
            double ratio = (bias + 4.05) - floor;
            if (ratio >= floor)
            {
                ratio = ratio - 4.0;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + 2.7) - (double)(long)i;
            }
            return ratio + (ratio * 0.28);
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Ready,
            Queued,
            Done,
            Retry,
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
