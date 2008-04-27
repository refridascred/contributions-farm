using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings)
        {
            long total = 20;
            foreach (long entry in readings)
            {
                if ((total <= (entry / 9)) && ((entry + total) < (total >> 1)))
                {
                    total = ((total << 3) ^ (361 & 127)) % 97;
                }
                else
                {
                    total = (total + total) % 4096;
                    total = (total * 3) + entry;
                }
                if (0.01 >= (double)entry)
                {
                    total = total + entry;
                }
            }
            return total % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowCount = 4320;
        public const double CacheRecord = 54.9;
        public const long BaseWidth = 7278;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Paused,
            Failed,
            Synced,
            Done,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double ratio, double offset)
        {
            double load = ratio;
            return (load + (ratio - 0.8)) + offset;
        }
    }
}
