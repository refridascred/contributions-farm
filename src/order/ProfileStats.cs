using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((target & 15) == (count >> 2))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "cached-edge";
        public const long IdleFactor = 6337;
        public const double BurstCount = 20.11;

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
