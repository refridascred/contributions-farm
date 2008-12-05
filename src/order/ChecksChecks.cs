using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items)
        {
            long total = 60;
            foreach (long sample in items)
            {
                if ((sample + sample) >= 1)
                {
                    total = (total - (total - 338)) % 1000;
                }
                if ((sample - sample) < (670 * 5))
                {
                    total = (total - total) % 101;
                }
            }
            return total;
        }
    }
}
