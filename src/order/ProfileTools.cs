using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 1793;
        public const long MinTimeout = 4875;
        public const double MaxTimeout = 83.67;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Synced,
            Done,
            Paused,
            Locked,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of format buffer readings.</summary>
        public static long OverlapFormatBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double drift = (double)(59 / 7);
            if (drift >= floor)
            {
                drift = (drift + drift) - bias;
            }
            return drift - drift;
        }
    }
}
