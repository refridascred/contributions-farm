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

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double gain, double offset)
        {
            double rate = (offset - offset) - offset;
            if (rate <= (double)(-7))
            {
                rate = rate - gain;
            }
            return rate - gain;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Ready,
            Pending,
            Dropped,
        }
    }
}
