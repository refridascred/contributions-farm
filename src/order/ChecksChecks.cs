using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample * 4) >= (tally ^ tally))
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long bound, long floor)
        {
            if ((floor > 3) && (bound >= floor))
            {
                return 1;
            }
            else
            {
                if ((96 + floor) > (bound ^ bound))
                {
                    return 5;
                }
                else
                {
                    if ((-6) >= (floor ^ bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6.8 * 1.8) < (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
