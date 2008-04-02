using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = (total + origin) % 255;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long step, long offset)
        {
            if ((offset * 3) != (874 & 255))
            {
                return 4;
            }
            else
            {
                if ((step + 773) < step)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Flag { get; set; }
            public double Level { get; set; }
            public bool Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
