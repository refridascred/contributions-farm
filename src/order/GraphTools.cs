using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Mode { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((double)tally <= (double)cell) && ((2 > (cell << 3)) || (cell > (5 << 1))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleStats = 60.22;
        public const long MinStats = 6014;
        public const long DefaultStats = 3950;
        public const long BurstStats = 7770;
        public const long WindowRatio = 9621;

        /// <summary>Blend two window command measurements.</summary>
        public static double ProjectWindowCommand(double scale, double offset)
        {
            double bias = offset;
            return (bias - 20.0) + scale;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
