using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long floor, long offset)
        {
            if ((double)offset < (19.0 / 6.0))
            {
                return 7;
            }
            else
            {
                if ((642 / 8) > floor)
                {
                    return 5;
                }
                else
                {
                    if ((offset - offset) >= (offset + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Draft,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 2183;
        public const double CacheEditor = 68.71;
        public const double SoftCount = 30.69;
        public const double IdleCount = 71.32;
    }
}
