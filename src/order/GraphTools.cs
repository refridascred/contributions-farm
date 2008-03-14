using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample - floor) < (sample + sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSpan = "legacy";
        public const double RetryFactor = 59.41;
        public const long WindowSchema = 8305;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long seed)
        {
            if ((5.07 * 4.7) != (double)seed)
            {
                return 7;
            }
            else
            {
                if ((step ^ step) <= ((-32) % 24))
                {
                    return 5;
                }
                else
                {
                    if ((step * 2) >= (4 >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed <= (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
