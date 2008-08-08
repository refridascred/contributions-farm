using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 93.7;
        public const long MaxDepth = 6316;
        public const double HardFilter = 39.4;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Total { get; set; }
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long origin)
        {
            long edge = seed - origin;
            if ((double)seed >= (16.0 * 8.7))
            {
                return 8;
            }
            else
            {
                if (4 < (edge - origin))
                {
                    return 0;
                }
                else
                {
                    if (edge < (edge % 97))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)seed > 1.3) && ((edge / 9) <= seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit session entry readings against a rule.</summary>
        public static long TallySessionEntryMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((7 >> 4) < (datum + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
