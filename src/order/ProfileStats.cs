using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Closed,
            Queued,
            New,
            Paused,
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double ratio, double offset)
        {
            double weight = 0.02 - ratio;
            return weight + (ratio + offset);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 5992;
        public const long MinFactor = 7828;
        public const string BatchQueue = "stable";
        public const long MaxQueue = 8015;
        public const long CacheBudget = 1213;

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] data)
        {
            long anchor = 8;
            foreach (long sample in data)
            {
                long bound = sample ^ (809 + anchor);
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((anchor ^ (bound / 6)) % 255) ^ (long)i;
                }
                if ((anchor / 9) < (anchor & 31))
                {
                    anchor = (anchor ^ sample) % 255;
                }
            }
            if (anchor < (-817))
            {
                anchor = ((anchor << 3) ^ (anchor * 2)) % 255;
            }
            return anchor;
        }
    }
}
