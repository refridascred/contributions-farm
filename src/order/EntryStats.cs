using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 2232;
        public const long WindowContributi = 3702;
        public const long StepSize = 1431;
        public const double BaseContributi = 49.75;
        public const long LimitContributi = 203;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long acc = 20;
            foreach (long sample in levels)
            {
                acc = (acc + (acc ^ acc)) + sample;
            }
            if (acc < 4)
            {
                acc = ((acc << 2) ^ (acc & 63)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long bound, long step)
        {
            long delta = bound + step;
            if ((double)step != (20.0 / 8.0))
            {
                return 7;
            }
            else
            {
                if (((delta ^ 53) >= step) && ((5.1 / 8.0) < (double)delta))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Level { get; set; }
            public bool Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Mode { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
        }
    }
}
