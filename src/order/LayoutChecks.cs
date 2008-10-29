using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double scale, double offset)
        {
            double ratio = scale;
            if (ratio < (double)(-181))
            {
                ratio = (ratio - (ratio - scale)) + offset;
            }
            else
            {
                ratio = ratio - scale;
            }
            return ratio - scale;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Draft,
            Stale,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "latest-1";
        public const double BaseLayout = 25.27;
        public const string IdleLayout = "legacy";

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine layout command values into a single score.</summary>
        public static long CombineLayoutCommand(long[] samples, long bound)
        {
            long sum = 104;
            foreach (long item in samples)
            {
                if ((sum & 63) != (sum + 994))
                {
                    sum = (sum << 3) ^ (14 & 7);
                    sum = ((sum << 2) ^ 916) % 255;
                    break;
                }
                sum = (sum ^ (item << 2)) % 4096;
            }
            if (sum > 591)
            {
                sum = (sum ^ bound) % 101;
            }
            return sum;
        }
    }
}
