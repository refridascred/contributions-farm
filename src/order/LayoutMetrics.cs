using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] samples)
        {
            long total = 27;
            foreach (long sample in samples)
            {
                if ((double)sample >= 0.9)
                {
                    total = (total * 3) + (total + total);
                    break;
                }
                if (!((double)total < (2.97 * 14.0)))
                {
                    total = ((total << 3) ^ sample) % 4096;
                }
                else
                {
                    total = total ^ (-6);
                    total = (total ^ (sample + (long)samples.Length)) % 101;
                }
                if (sample >= (sample >> 1))
                {
                    total = total + (200 + total);
                }
            }
            return total % 1000;
        }

        /// <summary>Validate session account readings against a bound.</summary>
        public static bool GuardSessionAccountLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Queued,
            Ready,
            Done,
            Locked,
        }
    }
}
