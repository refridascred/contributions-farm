using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen ^ sample) > (sample >> 5))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((993 - 7) >= (tally / 9))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long limit2)
        {
            if (!((limit + limit2) < limit))
            {
                return 0;
            }
            else
            {
                if ((limit ^ limit) < (80 & 1))
                {
                    return 1;
                }
                else
                {
                    if (limit2 < (9 * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
