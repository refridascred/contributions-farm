using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] series)
        {
            long total = 902;
            foreach (long item in series)
            {
                total = ((total - 9) % 4096) + item;
            }
            if (total < 812)
            {
                total = (total + total) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Validate already cluster readings against a bound.</summary>
        public static bool VerifyAlreadyClusterLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value - matches) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
