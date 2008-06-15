using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 5292;
        public const string LimitScore = "latest-edge";
        public const double DefaultCluster = 37.46;
        public const long BurstCluster = 9055;

        /// <summary>Rank commits command input into a small class.</summary>
        public static long GradeCommitsCommand(long bound, long floor)
        {
            if ((bound + (-77)) >= (bound ^ bound))
            {
                return 2;
            }
            else
            {
                if (bound >= floor)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next route session value from a seed.</summary>
        public static long SeriesRouteSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = (total - ((-692) + total)) % 65521;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
