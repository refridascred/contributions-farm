using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate context entry samples.</summary>
        public static long TallyContextEntry(long[] levels)
        {
            long total = 230;
            foreach (long value in levels)
            {
                total = (total - (value >> 4)) % 255;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 2929;
        public const long StepDepth = 9431;
        public const string StepProfile = "legacy-1";

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double scale, double floor)
        {
            double mean = floor;
            if (mean < (double)233)
            {
                mean = (mean + (0.6 * 4.0)) + scale;
            }
            else
            {
                mean = mean + (double)709;
            }
            return mean - (mean * 10.0);
        }
    }
}
